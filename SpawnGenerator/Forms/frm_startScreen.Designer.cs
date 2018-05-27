namespace SpawnGenerator
{
    partial class Saltgurka_SQL_Generator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_loginDatabases = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_loginUser = new System.Windows.Forms.TextBox();
            this.txt_loginPassword = new System.Windows.Forms.TextBox();
            this.txt_loginHost = new System.Windows.Forms.TextBox();
            this.txt_loginPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_loginDatabases = new System.Windows.Forms.TextBox();
            this.btn_loginAddDatabase = new System.Windows.Forms.Button();
            this.btn_loginRemoveDatabase = new System.Windows.Forms.Button();
            this.btn_loginSaveAndTest = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.separateWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.singleSpawnGenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.multiSpawnGenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timestampSubtractorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sniffPacketFiltererToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.poolGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleSpawnGenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiSpawnGenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timestampSubtractorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sniffPacketFiltererToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poolGeneratorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.spellPacketTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chanceCalcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedSetterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waypointGenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBImporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_DBLogin = new System.Windows.Forms.Panel();
            this.textParserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel_DBLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_loginDatabases
            // 
            this.cmb_loginDatabases.Enabled = false;
            this.cmb_loginDatabases.FormattingEnabled = true;
            this.cmb_loginDatabases.Location = new System.Drawing.Point(92, 164);
            this.cmb_loginDatabases.Name = "cmb_loginDatabases";
            this.cmb_loginDatabases.Size = new System.Drawing.Size(121, 21);
            this.cmb_loginDatabases.TabIndex = 2;
            this.cmb_loginDatabases.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DB Login (Optional, passwords are not encrypted)";
            // 
            // txt_loginUser
            // 
            this.txt_loginUser.Location = new System.Drawing.Point(92, 34);
            this.txt_loginUser.Name = "txt_loginUser";
            this.txt_loginUser.Size = new System.Drawing.Size(121, 20);
            this.txt_loginUser.TabIndex = 4;
            // 
            // txt_loginPassword
            // 
            this.txt_loginPassword.Location = new System.Drawing.Point(92, 60);
            this.txt_loginPassword.Name = "txt_loginPassword";
            this.txt_loginPassword.Size = new System.Drawing.Size(121, 20);
            this.txt_loginPassword.TabIndex = 5;
            // 
            // txt_loginHost
            // 
            this.txt_loginHost.Location = new System.Drawing.Point(92, 86);
            this.txt_loginHost.Name = "txt_loginHost";
            this.txt_loginHost.Size = new System.Drawing.Size(121, 20);
            this.txt_loginHost.TabIndex = 6;
            // 
            // txt_loginPort
            // 
            this.txt_loginPort.Location = new System.Drawing.Point(92, 112);
            this.txt_loginPort.Name = "txt_loginPort";
            this.txt_loginPort.Size = new System.Drawing.Size(121, 20);
            this.txt_loginPort.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Host:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Databases:";
            // 
            // txt_loginDatabases
            // 
            this.txt_loginDatabases.Location = new System.Drawing.Point(92, 138);
            this.txt_loginDatabases.Name = "txt_loginDatabases";
            this.txt_loginDatabases.Size = new System.Drawing.Size(121, 20);
            this.txt_loginDatabases.TabIndex = 8;
            // 
            // btn_loginAddDatabase
            // 
            this.btn_loginAddDatabase.Enabled = false;
            this.btn_loginAddDatabase.Location = new System.Drawing.Point(219, 138);
            this.btn_loginAddDatabase.Name = "btn_loginAddDatabase";
            this.btn_loginAddDatabase.Size = new System.Drawing.Size(75, 23);
            this.btn_loginAddDatabase.TabIndex = 14;
            this.btn_loginAddDatabase.Text = "Add";
            this.btn_loginAddDatabase.UseVisualStyleBackColor = true;
            this.btn_loginAddDatabase.Visible = false;
            // 
            // btn_loginRemoveDatabase
            // 
            this.btn_loginRemoveDatabase.Enabled = false;
            this.btn_loginRemoveDatabase.Location = new System.Drawing.Point(219, 164);
            this.btn_loginRemoveDatabase.Name = "btn_loginRemoveDatabase";
            this.btn_loginRemoveDatabase.Size = new System.Drawing.Size(75, 23);
            this.btn_loginRemoveDatabase.TabIndex = 15;
            this.btn_loginRemoveDatabase.Text = "Remove";
            this.btn_loginRemoveDatabase.UseVisualStyleBackColor = true;
            this.btn_loginRemoveDatabase.Visible = false;
            // 
            // btn_loginSaveAndTest
            // 
            this.btn_loginSaveAndTest.Location = new System.Drawing.Point(33, 206);
            this.btn_loginSaveAndTest.Name = "btn_loginSaveAndTest";
            this.btn_loginSaveAndTest.Size = new System.Drawing.Size(261, 31);
            this.btn_loginSaveAndTest.TabIndex = 16;
            this.btn_loginSaveAndTest.Text = "Save";
            this.btn_loginSaveAndTest.UseVisualStyleBackColor = true;
            this.btn_loginSaveAndTest.Click += new System.EventHandler(this.btn_loginSaveAndTest_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.separateWindowToolStripMenuItem,
            this.dBLoginToolStripMenuItem,
            this.singleSpawnGenToolStripMenuItem,
            this.multiSpawnGenToolStripMenuItem,
            this.timestampSubtractorToolStripMenuItem,
            this.sniffPacketFiltererToolStripMenuItem,
            this.poolGeneratorToolStripMenuItem1,
            this.spellPacketTimerToolStripMenuItem,
            this.chanceCalcToolStripMenuItem,
            this.speedSetterToolStripMenuItem,
            this.waypointGenToolStripMenuItem,
            this.dBImporterToolStripMenuItem,
            this.textParserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1478, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // separateWindowToolStripMenuItem
            // 
            this.separateWindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.singleSpawnGenToolStripMenuItem1,
            this.multiSpawnGenToolStripMenuItem1,
            this.timestampSubtractorToolStripMenuItem1,
            this.sniffPacketFiltererToolStripMenuItem1,
            this.poolGeneratorToolStripMenuItem});
            this.separateWindowToolStripMenuItem.Name = "separateWindowToolStripMenuItem";
            this.separateWindowToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.separateWindowToolStripMenuItem.Text = "Separate Window";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // singleSpawnGenToolStripMenuItem1
            // 
            this.singleSpawnGenToolStripMenuItem1.Name = "singleSpawnGenToolStripMenuItem1";
            this.singleSpawnGenToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.singleSpawnGenToolStripMenuItem1.Text = "Single Spawn Gen";
            this.singleSpawnGenToolStripMenuItem1.Click += new System.EventHandler(this.singleSpawnGenToolStripMenuItem1_Click);
            // 
            // multiSpawnGenToolStripMenuItem1
            // 
            this.multiSpawnGenToolStripMenuItem1.Name = "multiSpawnGenToolStripMenuItem1";
            this.multiSpawnGenToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.multiSpawnGenToolStripMenuItem1.Text = "Multi-Spawn Gen";
            this.multiSpawnGenToolStripMenuItem1.Click += new System.EventHandler(this.multiSpawnGenToolStripMenuItem1_Click);
            // 
            // timestampSubtractorToolStripMenuItem1
            // 
            this.timestampSubtractorToolStripMenuItem1.Name = "timestampSubtractorToolStripMenuItem1";
            this.timestampSubtractorToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.timestampSubtractorToolStripMenuItem1.Text = "Timestamp Subtractor";
            this.timestampSubtractorToolStripMenuItem1.Click += new System.EventHandler(this.timestampSubtractorToolStripMenuItem1_Click);
            // 
            // sniffPacketFiltererToolStripMenuItem1
            // 
            this.sniffPacketFiltererToolStripMenuItem1.Name = "sniffPacketFiltererToolStripMenuItem1";
            this.sniffPacketFiltererToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.sniffPacketFiltererToolStripMenuItem1.Text = "Sniff Packet Filterer";
            this.sniffPacketFiltererToolStripMenuItem1.Click += new System.EventHandler(this.sniffPacketFiltererToolStripMenuItem1_Click);
            // 
            // poolGeneratorToolStripMenuItem
            // 
            this.poolGeneratorToolStripMenuItem.Name = "poolGeneratorToolStripMenuItem";
            this.poolGeneratorToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.poolGeneratorToolStripMenuItem.Text = "Pool Generator";
            this.poolGeneratorToolStripMenuItem.Click += new System.EventHandler(this.poolGeneratorToolStripMenuItem_Click);
            // 
            // dBLoginToolStripMenuItem
            // 
            this.dBLoginToolStripMenuItem.Name = "dBLoginToolStripMenuItem";
            this.dBLoginToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.dBLoginToolStripMenuItem.Text = "DB Login";
            this.dBLoginToolStripMenuItem.Click += new System.EventHandler(this.dBLoginToolStripMenuItem_Click);
            // 
            // singleSpawnGenToolStripMenuItem
            // 
            this.singleSpawnGenToolStripMenuItem.Name = "singleSpawnGenToolStripMenuItem";
            this.singleSpawnGenToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.singleSpawnGenToolStripMenuItem.Text = "Single Spawn Gen";
            this.singleSpawnGenToolStripMenuItem.Click += new System.EventHandler(this.singleSpawnGenToolStripMenuItem_Click);
            // 
            // multiSpawnGenToolStripMenuItem
            // 
            this.multiSpawnGenToolStripMenuItem.Name = "multiSpawnGenToolStripMenuItem";
            this.multiSpawnGenToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.multiSpawnGenToolStripMenuItem.Text = "Multi-Spawn Gen";
            this.multiSpawnGenToolStripMenuItem.Click += new System.EventHandler(this.multiSpawnGenToolStripMenuItem_Click);
            // 
            // timestampSubtractorToolStripMenuItem
            // 
            this.timestampSubtractorToolStripMenuItem.Name = "timestampSubtractorToolStripMenuItem";
            this.timestampSubtractorToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.timestampSubtractorToolStripMenuItem.Text = "Timestamp Subtractor";
            this.timestampSubtractorToolStripMenuItem.Click += new System.EventHandler(this.timestampSubtractorToolStripMenuItem_Click);
            // 
            // sniffPacketFiltererToolStripMenuItem
            // 
            this.sniffPacketFiltererToolStripMenuItem.Name = "sniffPacketFiltererToolStripMenuItem";
            this.sniffPacketFiltererToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.sniffPacketFiltererToolStripMenuItem.Text = "Sniff Packet Filterer";
            this.sniffPacketFiltererToolStripMenuItem.Click += new System.EventHandler(this.sniffPacketFiltererToolStripMenuItem_Click);
            // 
            // poolGeneratorToolStripMenuItem1
            // 
            this.poolGeneratorToolStripMenuItem1.Name = "poolGeneratorToolStripMenuItem1";
            this.poolGeneratorToolStripMenuItem1.Size = new System.Drawing.Size(98, 20);
            this.poolGeneratorToolStripMenuItem1.Text = "Pool Generator";
            this.poolGeneratorToolStripMenuItem1.Click += new System.EventHandler(this.poolGeneratorToolStripMenuItem1_Click);
            // 
            // spellPacketTimerToolStripMenuItem
            // 
            this.spellPacketTimerToolStripMenuItem.Name = "spellPacketTimerToolStripMenuItem";
            this.spellPacketTimerToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.spellPacketTimerToolStripMenuItem.Text = "Spell Packet Timer";
            this.spellPacketTimerToolStripMenuItem.Click += new System.EventHandler(this.spellPacketTimerToolStripMenuItem_Click);
            // 
            // chanceCalcToolStripMenuItem
            // 
            this.chanceCalcToolStripMenuItem.Name = "chanceCalcToolStripMenuItem";
            this.chanceCalcToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.chanceCalcToolStripMenuItem.Text = "Chance Calc";
            this.chanceCalcToolStripMenuItem.Click += new System.EventHandler(this.chanceCalcToolStripMenuItem_Click);
            // 
            // speedSetterToolStripMenuItem
            // 
            this.speedSetterToolStripMenuItem.Name = "speedSetterToolStripMenuItem";
            this.speedSetterToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.speedSetterToolStripMenuItem.Text = "SpeedSetter";
            this.speedSetterToolStripMenuItem.Click += new System.EventHandler(this.speedSetterToolStripMenuItem_Click);
            // 
            // waypointGenToolStripMenuItem
            // 
            this.waypointGenToolStripMenuItem.Name = "waypointGenToolStripMenuItem";
            this.waypointGenToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.waypointGenToolStripMenuItem.Text = "WaypointGen";
            this.waypointGenToolStripMenuItem.Click += new System.EventHandler(this.waypointGenToolStripMenuItem_Click);
            // 
            // dBImporterToolStripMenuItem
            // 
            this.dBImporterToolStripMenuItem.Name = "dBImporterToolStripMenuItem";
            this.dBImporterToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.dBImporterToolStripMenuItem.Text = "DB Importer";
            this.dBImporterToolStripMenuItem.Click += new System.EventHandler(this.dBImporterToolStripMenuItem_Click);
            // 
            // panel_DBLogin
            // 
            this.panel_DBLogin.Controls.Add(this.txt_loginPort);
            this.panel_DBLogin.Controls.Add(this.cmb_loginDatabases);
            this.panel_DBLogin.Controls.Add(this.btn_loginSaveAndTest);
            this.panel_DBLogin.Controls.Add(this.label1);
            this.panel_DBLogin.Controls.Add(this.btn_loginRemoveDatabase);
            this.panel_DBLogin.Controls.Add(this.txt_loginUser);
            this.panel_DBLogin.Controls.Add(this.btn_loginAddDatabase);
            this.panel_DBLogin.Controls.Add(this.txt_loginPassword);
            this.panel_DBLogin.Controls.Add(this.label6);
            this.panel_DBLogin.Controls.Add(this.txt_loginHost);
            this.panel_DBLogin.Controls.Add(this.label5);
            this.panel_DBLogin.Controls.Add(this.txt_loginDatabases);
            this.panel_DBLogin.Controls.Add(this.label4);
            this.panel_DBLogin.Controls.Add(this.label2);
            this.panel_DBLogin.Controls.Add(this.label3);
            this.panel_DBLogin.Location = new System.Drawing.Point(12, 27);
            this.panel_DBLogin.Name = "panel_DBLogin";
            this.panel_DBLogin.Size = new System.Drawing.Size(318, 256);
            this.panel_DBLogin.TabIndex = 22;
            // 
            // textParserToolStripMenuItem
            // 
            this.textParserToolStripMenuItem.Name = "textParserToolStripMenuItem";
            this.textParserToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.textParserToolStripMenuItem.Text = "TextParser";
            this.textParserToolStripMenuItem.Click += new System.EventHandler(this.textParserToolStripMenuItem_Click);
            // 
            // Saltgurka_SQL_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 858);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_DBLogin);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Saltgurka_SQL_Generator";
            this.Text = "tbc-db SQL Generator";
            this.Load += new System.EventHandler(this.Saltgurka_SQL_Generator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_DBLogin.ResumeLayout(false);
            this.panel_DBLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_loginDatabases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_loginUser;
        private System.Windows.Forms.TextBox txt_loginPassword;
        private System.Windows.Forms.TextBox txt_loginHost;
        private System.Windows.Forms.TextBox txt_loginPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_loginDatabases;
        private System.Windows.Forms.Button btn_loginAddDatabase;
        private System.Windows.Forms.Button btn_loginRemoveDatabase;
        private System.Windows.Forms.Button btn_loginSaveAndTest;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem singleSpawnGenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiSpawnGenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timestampSubtractorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sniffPacketFiltererToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem separateWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem singleSpawnGenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem multiSpawnGenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem timestampSubtractorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sniffPacketFiltererToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem poolGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poolGeneratorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem spellPacketTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chanceCalcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speedSetterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waypointGenToolStripMenuItem;
        private System.Windows.Forms.Panel panel_DBLogin;
        private System.Windows.Forms.ToolStripMenuItem dBLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBImporterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textParserToolStripMenuItem;
    }
}