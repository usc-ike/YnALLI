namespace YnALLP {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.FileChooseLabel = new System.Windows.Forms.Label();
            this.FileChoose = new System.Windows.Forms.Button();
            this.Generate = new System.Windows.Forms.Button();
            this.AutomaticPanel = new System.Windows.Forms.Panel();
            this.SnowLabel = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.OceanBar = new System.Windows.Forms.TrackBar();
            this.CoastBar = new System.Windows.Forms.TrackBar();
            this.SnowBar = new System.Windows.Forms.TrackBar();
            this.OceanLabel = new System.Windows.Forms.Label();
            this.CoastLabel = new System.Windows.Forms.Label();
            this.DesertLabel = new System.Windows.Forms.Label();
            this.TundraLabel = new System.Windows.Forms.Label();
            this.PlainsLabel = new System.Windows.Forms.Label();
            this.GrasslandLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DesertBar = new System.Windows.Forms.TrackBar();
            this.TundraBar = new System.Windows.Forms.TrackBar();
            this.PlainsBar = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GrasslandBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.AutoConfigurationList = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ManualPlacementText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ManualRB = new System.Windows.Forms.RadioButton();
            this.AutoRB = new System.Windows.Forms.RadioButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
            this.AutomaticPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OceanBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoastBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnowBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesertBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TundraBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlainsBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrasslandBar)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FileChooseLabel);
            this.panel1.Controls.Add(this.FileChoose);
            this.panel1.Location = new System.Drawing.Point(41, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 97);
            this.panel1.TabIndex = 0;
            // 
            // FileChooseLabel
            // 
            this.FileChooseLabel.AutoSize = true;
            this.FileChooseLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.FileChooseLabel.Location = new System.Drawing.Point(180, 27);
            this.FileChooseLabel.MaximumSize = new System.Drawing.Size(450, 48);
            this.FileChooseLabel.Name = "FileChooseLabel";
            this.FileChooseLabel.Size = new System.Drawing.Size(108, 16);
            this.FileChooseLabel.TabIndex = 1;
            this.FileChooseLabel.Text = "No File Chosen";
            // 
            // FileChoose
            // 
            this.FileChoose.Location = new System.Drawing.Point(15, 15);
            this.FileChoose.Name = "FileChoose";
            this.FileChoose.Size = new System.Drawing.Size(141, 68);
            this.FileChoose.TabIndex = 0;
            this.FileChoose.Text = "Choose File";
            this.FileChoose.UseVisualStyleBackColor = true;
            this.FileChoose.Click += new System.EventHandler(this.FileChoose_Click);
            // 
            // Generate
            // 
            this.Generate.Enabled = false;
            this.Generate.Location = new System.Drawing.Point(624, 656);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(127, 65);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Generate Ley Lines";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // AutomaticPanel
            // 
            this.AutomaticPanel.Controls.Add(this.SnowLabel);
            this.AutomaticPanel.Controls.Add(this.Label10);
            this.AutomaticPanel.Controls.Add(this.OceanBar);
            this.AutomaticPanel.Controls.Add(this.CoastBar);
            this.AutomaticPanel.Controls.Add(this.SnowBar);
            this.AutomaticPanel.Controls.Add(this.OceanLabel);
            this.AutomaticPanel.Controls.Add(this.CoastLabel);
            this.AutomaticPanel.Controls.Add(this.DesertLabel);
            this.AutomaticPanel.Controls.Add(this.TundraLabel);
            this.AutomaticPanel.Controls.Add(this.PlainsLabel);
            this.AutomaticPanel.Controls.Add(this.GrasslandLabel);
            this.AutomaticPanel.Controls.Add(this.label9);
            this.AutomaticPanel.Controls.Add(this.DesertBar);
            this.AutomaticPanel.Controls.Add(this.TundraBar);
            this.AutomaticPanel.Controls.Add(this.PlainsBar);
            this.AutomaticPanel.Controls.Add(this.label8);
            this.AutomaticPanel.Controls.Add(this.label7);
            this.AutomaticPanel.Controls.Add(this.label6);
            this.AutomaticPanel.Controls.Add(this.label5);
            this.AutomaticPanel.Controls.Add(this.label4);
            this.AutomaticPanel.Controls.Add(this.label3);
            this.AutomaticPanel.Controls.Add(this.GrasslandBar);
            this.AutomaticPanel.Controls.Add(this.label2);
            this.AutomaticPanel.Controls.Add(this.AutoConfigurationList);
            this.AutomaticPanel.Location = new System.Drawing.Point(41, 192);
            this.AutomaticPanel.Name = "AutomaticPanel";
            this.AutomaticPanel.Size = new System.Drawing.Size(370, 497);
            this.AutomaticPanel.TabIndex = 2;
            // 
            // SnowLabel
            // 
            this.SnowLabel.AutoSize = true;
            this.SnowLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SnowLabel.Location = new System.Drawing.Point(325, 375);
            this.SnowLabel.Name = "SnowLabel";
            this.SnowLabel.Size = new System.Drawing.Size(15, 16);
            this.SnowLabel.TabIndex = 23;
            this.SnowLabel.Text = "0";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(18, 375);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(32, 12);
            this.Label10.TabIndex = 22;
            this.Label10.Text = "Snow";
            // 
            // OceanBar
            // 
            this.OceanBar.Enabled = false;
            this.OceanBar.Location = new System.Drawing.Point(74, 444);
            this.OceanBar.Name = "OceanBar";
            this.OceanBar.Size = new System.Drawing.Size(245, 45);
            this.OceanBar.TabIndex = 13;
            this.OceanBar.Scroll += new System.EventHandler(this.OceanBar_Scroll);
            // 
            // CoastBar
            // 
            this.CoastBar.Enabled = false;
            this.CoastBar.Location = new System.Drawing.Point(74, 409);
            this.CoastBar.Name = "CoastBar";
            this.CoastBar.Size = new System.Drawing.Size(245, 45);
            this.CoastBar.TabIndex = 12;
            this.CoastBar.Scroll += new System.EventHandler(this.CoastBar_Scroll);
            // 
            // SnowBar
            // 
            this.SnowBar.Enabled = false;
            this.SnowBar.Location = new System.Drawing.Point(74, 375);
            this.SnowBar.Name = "SnowBar";
            this.SnowBar.Size = new System.Drawing.Size(245, 45);
            this.SnowBar.TabIndex = 21;
            this.SnowBar.Scroll += new System.EventHandler(this.SnowBar_Scroll);
            // 
            // OceanLabel
            // 
            this.OceanLabel.AutoSize = true;
            this.OceanLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OceanLabel.Location = new System.Drawing.Point(325, 444);
            this.OceanLabel.Name = "OceanLabel";
            this.OceanLabel.Size = new System.Drawing.Size(15, 16);
            this.OceanLabel.TabIndex = 20;
            this.OceanLabel.Text = "0";
            // 
            // CoastLabel
            // 
            this.CoastLabel.AutoSize = true;
            this.CoastLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CoastLabel.Location = new System.Drawing.Point(325, 409);
            this.CoastLabel.Name = "CoastLabel";
            this.CoastLabel.Size = new System.Drawing.Size(15, 16);
            this.CoastLabel.TabIndex = 19;
            this.CoastLabel.Text = "0";
            // 
            // DesertLabel
            // 
            this.DesertLabel.AutoSize = true;
            this.DesertLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DesertLabel.Location = new System.Drawing.Point(325, 342);
            this.DesertLabel.Name = "DesertLabel";
            this.DesertLabel.Size = new System.Drawing.Size(15, 16);
            this.DesertLabel.TabIndex = 18;
            this.DesertLabel.Text = "0";
            // 
            // TundraLabel
            // 
            this.TundraLabel.AutoSize = true;
            this.TundraLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TundraLabel.Location = new System.Drawing.Point(325, 307);
            this.TundraLabel.Name = "TundraLabel";
            this.TundraLabel.Size = new System.Drawing.Size(15, 16);
            this.TundraLabel.TabIndex = 17;
            this.TundraLabel.Text = "0";
            // 
            // PlainsLabel
            // 
            this.PlainsLabel.AutoSize = true;
            this.PlainsLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PlainsLabel.Location = new System.Drawing.Point(325, 275);
            this.PlainsLabel.Name = "PlainsLabel";
            this.PlainsLabel.Size = new System.Drawing.Size(15, 16);
            this.PlainsLabel.TabIndex = 16;
            this.PlainsLabel.Text = "0";
            // 
            // GrasslandLabel
            // 
            this.GrasslandLabel.AutoSize = true;
            this.GrasslandLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GrasslandLabel.Location = new System.Drawing.Point(325, 243);
            this.GrasslandLabel.Name = "GrasslandLabel";
            this.GrasslandLabel.Size = new System.Drawing.Size(15, 16);
            this.GrasslandLabel.TabIndex = 15;
            this.GrasslandLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(313, 36);
            this.label9.TabIndex = 14;
            this.label9.Text = "Adjust the bars below to change the distribution of leylines \r\nbetween different " +
    "tile types. Higher values mean more Ley \r\nLines in the selected terrain";
            // 
            // DesertBar
            // 
            this.DesertBar.Enabled = false;
            this.DesertBar.Location = new System.Drawing.Point(74, 342);
            this.DesertBar.Name = "DesertBar";
            this.DesertBar.Size = new System.Drawing.Size(245, 45);
            this.DesertBar.TabIndex = 11;
            this.DesertBar.Scroll += new System.EventHandler(this.DesertBar_Scroll);
            // 
            // TundraBar
            // 
            this.TundraBar.Enabled = false;
            this.TundraBar.Location = new System.Drawing.Point(74, 307);
            this.TundraBar.Name = "TundraBar";
            this.TundraBar.Size = new System.Drawing.Size(245, 45);
            this.TundraBar.TabIndex = 10;
            this.TundraBar.Scroll += new System.EventHandler(this.TundraBar_Scroll);
            // 
            // PlainsBar
            // 
            this.PlainsBar.Enabled = false;
            this.PlainsBar.Location = new System.Drawing.Point(74, 275);
            this.PlainsBar.Name = "PlainsBar";
            this.PlainsBar.Size = new System.Drawing.Size(245, 45);
            this.PlainsBar.TabIndex = 9;
            this.PlainsBar.Scroll += new System.EventHandler(this.PlainsBar_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ocean";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "Coast";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "Desert";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tundra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Plains";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Grassland";
            // 
            // GrasslandBar
            // 
            this.GrasslandBar.Enabled = false;
            this.GrasslandBar.Location = new System.Drawing.Point(74, 242);
            this.GrasslandBar.Name = "GrasslandBar";
            this.GrasslandBar.Size = new System.Drawing.Size(245, 45);
            this.GrasslandBar.TabIndex = 2;
            this.GrasslandBar.Scroll += new System.EventHandler(this.GrasslandBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "By default, Ley Lines will only be injected on non-snow land \r\ntiles with no feat" +
    "ures. Check each box to override these \r\nrestrictions";
            // 
            // AutoConfigurationList
            // 
            this.AutoConfigurationList.BackColor = System.Drawing.SystemColors.Control;
            this.AutoConfigurationList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AutoConfigurationList.CheckOnClick = true;
            this.AutoConfigurationList.Enabled = false;
            this.AutoConfigurationList.FormattingEnabled = true;
            this.AutoConfigurationList.Items.AddRange(new object[] {
            "Allow Ley Lines on Mountain/Volcano tiles",
            "Allow Ley Lines on Wood/Rainforest tiles",
            "Allow Ley Lines on Floodplain tiles",
            "Allow Ley Lines on Marsh tiles",
            "Allow Ley Lines on Snow tiles",
            "Allow Ley Lines on Coast tiles",
            "Only allow coastal Ley Lines on Lake tiles",
            "Allow Ley Lines on Reef tiles",
            "Allow Ley Lines on Ocean Tiles (You\'re a monster!)"});
            this.AutoConfigurationList.Location = new System.Drawing.Point(16, 53);
            this.AutoConfigurationList.Name = "AutoConfigurationList";
            this.AutoConfigurationList.Size = new System.Drawing.Size(312, 126);
            this.AutoConfigurationList.TabIndex = 0;
            this.AutoConfigurationList.SelectedIndexChanged += new System.EventHandler(this.AutoConfigurationList_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ManualPlacementText);
            this.panel2.Location = new System.Drawing.Point(433, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 448);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert the coordinates (one per line) in the x,y format.\r\nExample:\r\n3,10\r\n40,55\r\n" +
    "";
            // 
            // ManualPlacementText
            // 
            this.ManualPlacementText.Enabled = false;
            this.ManualPlacementText.Location = new System.Drawing.Point(14, 64);
            this.ManualPlacementText.Multiline = true;
            this.ManualPlacementText.Name = "ManualPlacementText";
            this.ManualPlacementText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ManualPlacementText.Size = new System.Drawing.Size(294, 365);
            this.ManualPlacementText.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.ManualRB);
            this.groupBox1.Controls.Add(this.AutoRB);
            this.groupBox1.Location = new System.Drawing.Point(41, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 37);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Ley Line Injection Mode:";
            // 
            // ManualRB
            // 
            this.ManualRB.AutoSize = true;
            this.ManualRB.Location = new System.Drawing.Point(392, 15);
            this.ManualRB.Name = "ManualRB";
            this.ManualRB.Size = new System.Drawing.Size(59, 16);
            this.ManualRB.TabIndex = 1;
            this.ManualRB.TabStop = true;
            this.ManualRB.Text = "Manual";
            this.ManualRB.UseVisualStyleBackColor = true;
            this.ManualRB.CheckedChanged += new System.EventHandler(this.ManualRB_CheckedChanged);
            // 
            // AutoRB
            // 
            this.AutoRB.AutoSize = true;
            this.AutoRB.Location = new System.Drawing.Point(16, 15);
            this.AutoRB.Name = "AutoRB";
            this.AutoRB.Size = new System.Drawing.Size(75, 16);
            this.AutoRB.TabIndex = 0;
            this.AutoRB.TabStop = true;
            this.AutoRB.Text = "Automatic";
            this.AutoRB.UseVisualStyleBackColor = true;
            this.AutoRB.CheckedChanged += new System.EventHandler(this.AutoRB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 728);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AutomaticPanel);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Yet (not) Another Ley Line Injector by FinnarkTV (Alpha v1.0.0)";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AutomaticPanel.ResumeLayout(false);
            this.AutomaticPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OceanBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoastBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnowBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesertBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TundraBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlainsBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrasslandBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FileChooseLabel;
        private System.Windows.Forms.Button FileChoose;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Panel AutomaticPanel;
        private System.Windows.Forms.CheckedListBox AutoConfigurationList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ManualPlacementText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ManualRB;
        private System.Windows.Forms.RadioButton AutoRB;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label OceanLabel;
        private System.Windows.Forms.Label CoastLabel;
        private System.Windows.Forms.Label DesertLabel;
        private System.Windows.Forms.Label TundraLabel;
        private System.Windows.Forms.Label PlainsLabel;
        private System.Windows.Forms.Label GrasslandLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar OceanBar;
        private System.Windows.Forms.TrackBar CoastBar;
        private System.Windows.Forms.TrackBar DesertBar;
        private System.Windows.Forms.TrackBar TundraBar;
        private System.Windows.Forms.TrackBar PlainsBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar GrasslandBar;
        private System.Windows.Forms.Label SnowLabel;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.TrackBar SnowBar;
    }
}

