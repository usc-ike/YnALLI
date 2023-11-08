using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace YnALLP {
    
    public partial class Form1 : Form {

        OpenFileDialog Dialog;

        public Form1() {
            InitializeComponent();
        }

        private void FileChoose_Click(object sender, EventArgs e) {
            Dialog = new OpenFileDialog();

            Dialog.Filter = "LUA files|*.lua";
            Dialog.FilterIndex = 2;
            Dialog.RestoreDirectory = true;

            if (Dialog.ShowDialog() == DialogResult.OK) {
                FileChooseLabel.Text = Dialog.FileName;
            }

            
        }

        private async void Generate_Click(object sender, EventArgs e) {
            if (Dialog == null || !Dialog.CheckFileExists) {
                MessageBox.Show("Specified file path does not exist");
                return;
            }
            string[] data = File.ReadAllLines(Dialog.FileName);
            string[] processedData = ProcessFile(data);

            DirectoryInfo LuaDir = Directory.CreateDirectory("Output");
            File.WriteAllLines("Output" + "\\" + Path.GetFileName(Dialog.FileName), processedData);
            ProcessStartInfo startInfo = new ProcessStartInfo {
                Arguments = "Output",
                FileName = "explorer.exe"
            };
            Process.Start(startInfo);

        }

        private void AutoConfigurationList_SelectedIndexChanged(object sender, EventArgs e) {
            SnowBar.Enabled = AutoConfigurationList.GetItemCheckState(4) == CheckState.Checked;
            CoastBar.Enabled = AutoConfigurationList.GetItemCheckState(5) == CheckState.Checked;
            OceanBar.Enabled = AutoConfigurationList.GetItemCheckState(8) == CheckState.Checked;
        }

        private void ToggleProcessMode(bool automatic) {
            ManualPlacementText.Enabled = !automatic;
            AutoConfigurationList.Enabled = automatic;
            GrasslandBar.Enabled = automatic;
            PlainsBar.Enabled = automatic;
            TundraBar.Enabled = automatic;
            DesertBar.Enabled = automatic;
            SnowBar.Enabled = automatic && AutoConfigurationList.GetItemCheckState(4) == CheckState.Checked;
            CoastBar.Enabled = automatic && AutoConfigurationList.GetItemCheckState(5) == CheckState.Checked;
            OceanBar.Enabled = automatic && AutoConfigurationList.GetItemCheckState(8) == CheckState.Checked;
            Generate.Enabled = true;
        }

        private void AutoRB_CheckedChanged(object sender, EventArgs e) {
            ToggleProcessMode(true);
        }

        private void ManualRB_CheckedChanged(object sender, EventArgs e) {
            ToggleProcessMode(false);
        }

        private string[] ProcessFile(string[] source) {
            string dimensionPatternW = @"^local g_iW = \d*$";
            string dimensionPatternH = @"^local g_iH = \d*$";
            string dataPattern = @"^MapToConvert\[\d+\]\[\d+\]=.*$";
            List<MapCell> cells = new List<MapCell>();
            
            for(int i=0; i<source.Length; ++i) {
                if (Regex.IsMatch(source[i], dataPattern)) {
                    cells.Add(new MapCell(i, source[i]));
                    continue;
                }
                if (Regex.IsMatch(source[i], dimensionPatternW)) {
                    string widthS = Regex.Match(source[i], @"\d+").Value;
                    MapCell.dimensionX = Int32.Parse(widthS);
                }else if(Regex.IsMatch(source[i], dimensionPatternH)) {
                    string heightS = Regex.Match(source[i], @"\d+").Value;
                    MapCell.dimensionY = Int32.Parse(heightS);
                }
            }
            
            if(ManualRB.Checked) {
                string[] manualList = ManualPlacementText.Text.Split('\n');
                foreach (string line in manualList) {
                    Regex rgx = new Regex(@"^(?<x>\d+),(?<y>\d+).*$");
                    if(!Regex.IsMatch(line, @"^(?<x>\d+),(?<y>\d+).*$")) {
                        continue;
                    }
                    Match match = rgx.Match(line);
                    int x = Int32.Parse(match.Groups["x"].Value);
                    int y = Int32.Parse(match.Groups["y"].Value);
                    if(MapCell.ToIndex(x,y) > cells.Count) {
                        MessageBox.Show(string.Format("Coordinates x:{0}, y:{1} skipped due to it being out of bounds", x, y));
                        continue;
                    }

                    cells[MapCell.ToIndex(x, y)].InsertLeyLine();
#if DEBUG
                    //Console.WriteLine(string.Format("x:{0}, y:{1}", x, y));
                    //Console.WriteLine(cells[MapCell.ToIndex(x,y)].GetLine());
#endif
                }
            } else {
                List<int> grassland = new List<int>();
                List<int> plains = new List<int>();
                List<int> tundra = new List<int>();
                List<int> desert = new List<int>();
                List<int> snow = new List<int>();
                List<int> coast = new List<int>();
                List<int> ocean = new List<int>();
                for(int i=0; i< cells.Count; ++i) {
                    //Console.WriteLine(string.Format("Terrain: {0}\nFeature: {1}\nResource: {2}", cells[i].terrain, cells[i].feature, cells[i].resource));
                    if (cells[i].resource != "{-1,0}") continue;
                    //Mountain
                    if (AutoConfigurationList.GetItemCheckState(0) == CheckState.Unchecked && cells[i].isMountain) continue;
                    //Wood
                    if(AutoConfigurationList.GetItemCheckState(1) == CheckState.Unchecked && cells[i].isWood) continue;
                    //Floodplain
                    if(AutoConfigurationList.GetItemCheckState(2) == CheckState.Unchecked && cells[i].isFloodplain) continue;
                    //Marsh
                    if(AutoConfigurationList.GetItemCheckState(3) == CheckState.Unchecked && cells[i].isMarsh) continue;
                    //Snow
                    if(AutoConfigurationList.GetItemCheckState(4) == CheckState.Unchecked && cells[i].terrainType == Terrain.Snow) continue;
                    //Coast
                    //Lake
                    if(AutoConfigurationList.GetItemCheckState(5) == CheckState.Unchecked && cells[i].terrainType == Terrain.Coast) continue;
                    //Reef
                    if (AutoConfigurationList.GetItemCheckState(7) == CheckState.Unchecked && cells[i].isReef) continue;
                    //Ocean
                    if(AutoConfigurationList.GetItemCheckState(8) == CheckState.Unchecked && cells[i].terrainType == Terrain.Ocean) continue;

                    switch (cells[i].terrainType) {
                        case Terrain.Grass:
                            grassland.Add(i);
                            break;
                        case Terrain.Plains:
                            plains.Add(i);
                            break;
                        case Terrain.Tundra:
                            tundra.Add(i);
                            break;
                        case Terrain.Desert:
                            desert.Add(i);
                            break;
                        case Terrain.Snow:
                            snow.Add(i);
                            break;
                        case Terrain.Coast:
                            if(AutoConfigurationList.GetItemCheckState(6) == CheckState.Checked && cells[i].isLake) {
                                coast.Add(i);
                            }else if(AutoConfigurationList.GetItemCheckState(6) == CheckState.Unchecked) {
                                coast.Add(i);
                            }
                            break;
                        case Terrain.Ocean:
                            ocean.Add(i);
                            break;
                    }
                }

                int total = MapCell.dimensionX * MapCell.dimensionY;
                int availableTiles = GrasslandBar.Value + PlainsBar.Value + TundraBar.Value + DesertBar.Value;
                int availableMax = 40;
                if(snow.Count > 0) {
                    availableTiles += SnowBar.Value;
                    availableMax += 10;
                }
                if(coast.Count > 0) {
                    availableTiles += CoastBar.Value;
                    availableMax += 10;
                }
                if(ocean.Count > 0) {
                    availableTiles += OceanBar.Value;
                    availableMax += 10;
                }
                float verifiedPercentage = 0.03f * ((float)availableTiles / availableMax);
                int verifiedAvailable = (int)(total * verifiedPercentage);
#if DEBUG
                Console.WriteLine(string.Format("{0}:{1} => {2}",total, verifiedPercentage, verifiedAvailable));
#endif
                int grassTiles = (int)((float)GrasslandBar.Value / availableTiles * verifiedAvailable);
                int plainsTiles = (int)((float)PlainsBar.Value / availableTiles * verifiedAvailable);
                int tundraTiles = (int)((float)TundraBar.Value / availableTiles * verifiedAvailable);
                int desertTiles = (int)((float)DesertBar.Value / availableTiles * verifiedAvailable);
                int snowTiles = snow.Count > 0 ? (int)((float)SnowBar.Value / availableTiles * verifiedAvailable) : 0;
                int coastTiles = coast.Count > 0 ? (int)((float)CoastBar.Value / availableTiles * verifiedAvailable) : 0;
                int oceanTiles = ocean.Count > 0 ? (int)((float)OceanBar.Value / availableTiles * verifiedAvailable) : 0;
#if DEBUG
                Console.WriteLine(string.Format("Grass: {0}, Plains: {1}, Tundra: {2}, Desert: {3}, Snow: {4}, Coast:{5}, Ocean: {6}", grassTiles, plainsTiles, tundraTiles, desertTiles, snowTiles, coastTiles, oceanTiles));
#endif
                Random rnd = new Random();
                List<int> grassRes = grassland.OrderBy(x => rnd.Next()).Take(grassTiles).ToList();
                rnd = new Random();
                List<int> plainsRes = plains.OrderBy(x => rnd.Next()).Take(plainsTiles).ToList();
                rnd = new Random();
                List<int> tundraRes = tundra.OrderBy(x => rnd.Next()).Take(tundraTiles).ToList();
                rnd = new Random();
                List<int> desertRes = desert.OrderBy(x => rnd.Next()).Take(desertTiles).ToList();
                rnd = new Random();
                List<int> snowRes = snow.OrderBy(x => rnd.Next()).Take(snowTiles).ToList();
                rnd = new Random();
                List<int> coastRes = coast.OrderBy(x => rnd.Next()).Take(coastTiles).ToList();
                rnd = new Random();
                List<int> oceanRes = ocean.OrderBy(x => rnd.Next()).Take(oceanTiles).ToList();

                List<int> selectedLeyLines = new List<int>(grassRes.Count + plainsRes.Count + tundraRes.Count + desertRes.Count + snowRes.Count + coastRes.Count + oceanRes.Count);
                selectedLeyLines.AddRange(grassRes);
                selectedLeyLines.AddRange(plainsRes);
                selectedLeyLines.AddRange(tundraRes);
                selectedLeyLines.AddRange(desertRes);
                selectedLeyLines.AddRange(snowRes);
                selectedLeyLines.AddRange(coastRes);
                selectedLeyLines.AddRange(oceanRes);

                List<string> selectedCoords = new List<string>();
                for(int i=0; i<selectedLeyLines.Count; ++i) {
                    cells[selectedLeyLines[i]].InsertLeyLine();
                    selectedCoords.Add(cells[selectedLeyLines[i]].GetCoord());
                }
                DirectoryInfo LuaDir = Directory.CreateDirectory("Output");
                File.WriteAllLines("Output" + "\\" + "Coords.txt", selectedCoords.ToArray());

            }

            foreach (var i in cells) {
                source[i.index] = i.GetLine();
            }


            return source;
        }


        private void GrasslandBar_Scroll(object sender, EventArgs e) {
            GrasslandLabel.Text = GrasslandBar.Value.ToString();
        }

        private void PlainsBar_Scroll(object sender, EventArgs e) {
            PlainsLabel.Text = PlainsBar.Value.ToString();
        }

        private void TundraBar_Scroll(object sender, EventArgs e) {
            TundraLabel.Text = TundraBar.Value.ToString();
        }

        private void DesertBar_Scroll(object sender, EventArgs e) {
            DesertLabel.Text = DesertBar.Value.ToString();
        }

        private void SnowBar_Scroll(object sender, EventArgs e) {
            SnowLabel.Text = SnowBar.Value.ToString();
        }

        private void CoastBar_Scroll(object sender, EventArgs e) {
            CoastLabel.Text = CoastBar.Value.ToString();
        }

        private void OceanBar_Scroll(object sender, EventArgs e) {
            OceanLabel.Text = OceanBar.Value.ToString();
        }

        
    }

    public enum Terrain {
        Grass,
        Plains,
        Tundra,
        Desert,
        Snow,
        Coast,
        Ocean
    }

    public class MapCell {
        public static int dimensionX;
        public static int dimensionY;
        private static Regex rgx = new Regex(@"^MapToConvert\[(?<x>\d+)\]\[(?<y>\d+)\]={(?<terrain>[^,]+),(?<feature>[^,]+),(?<continent>[^,]+),(?<river>{{-?\d,-?\d},{-?\d,-?\d},{-?\d,-?\d}}),(?<resource>{[^,]+,-?\d}),(?<cliff>{-?\d,-?\d,-?\d}),(?<lowland>-?\d)}(?<extra>.*$)");
        public int index;
        public int x;
        public int y;
        public string terrain;
        public string feature;
        public string continent;
        public string river;
        public string resource;
        public string cliff;
        public string lowland;
        public string extra;

        public bool isMountain;
        public bool isWood;
        public bool isFloodplain;
        public bool isMarsh;
        public Terrain terrainType;
        public bool isReef;
        public bool isLake;

        public static int ToIndex(int x, int y) {
            return y * dimensionX + x;
        }

        public MapCell(int index, string data) {
            this.index = index;
            Match match = rgx.Match(data);
#if DEBUG
            //Console.WriteLine(string.Format("X: {0}, Y: {1}", match.Groups["x"], match.Groups["y"]));
#endif
            try {
                x = Int32.Parse(match.Groups["x"].Value);
                y = Int32.Parse(match.Groups["y"].Value);
            }catch(Exception) {
                MessageBox.Show(string.Format("Line \n{0}\ncontains corrupted data. Rebuild the Lua file to fix it.", data));
                Application.Exit();
            }
            
            terrain = match.Groups["terrain"].Value;
            feature = match.Groups["feature"].Value;
            continent = match.Groups["continent"].Value;
            river = match.Groups["river"].Value;
            resource = match.Groups["resource"].Value;
            cliff = match.Groups["cliff"].Value;
            lowland = match.Groups["lowland"].Value;
            extra = match.Groups["extra"].Value;

            isMountain = terrain.Contains("MOUNTAIN");
            isWood = feature.Contains("FOREST") || feature.Contains("JUNGLE");
            isFloodplain = feature.Contains("FLOODPLAIN");
            isMarsh = feature.Contains("MARSH");
            if (terrain.Contains("GRASS")) {
                terrainType = Terrain.Grass;
            }else if (terrain.Contains("PLAIN")) {
                terrainType = Terrain.Plains;
            }else if (terrain.Contains("TUNDRA")) {
                terrainType = Terrain.Tundra;
            }else if (terrain.Contains("DESERT")) {
                terrainType = Terrain.Desert;
            }else if (terrain.Contains("SNOW")) {
                terrainType = Terrain.Snow;
            }else if (terrain.Contains("COAST")) {
                terrainType = Terrain.Coast;
            }else if (terrain.Contains("OCEAN")) {
                terrainType = Terrain.Ocean;
            } else {
                MessageBox.Show(string.Format("Unidentified Terrain: {0}", terrain));
            }
            isReef = feature.Contains("REEF");
            isLake = extra.Contains("Lake");

        }

        public void InsertLeyLine() {
            resource = "{\"RESOURCE_LEY_LINE\",1}";
        }

        public string GetCoord() {
            return string.Format("{0},{1}", x, y);
        }

        public string GetLine() {
            return string.Format("MapToConvert[{0}][{1}]={{{2},{3},{4},{5},{6},{7},{8}}}{9}", x, y, terrain, feature, continent, river, resource, cliff, lowland, extra);
        }
    }
}
