namespace SpawnGenerator
{
    partial class frm_filterer
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
            this.btn_addBlacklistedPacket = new System.Windows.Forms.Button();
            this.btn_removeBlacklistedPacket = new System.Windows.Forms.Button();
            this.txt_addBlacklistEntry = new System.Windows.Forms.TextBox();
            this.clb_packetBlackList = new System.Windows.Forms.CheckedListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_loadSource = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.clb_packetWhitelist = new System.Windows.Forms.CheckedListBox();
            this.txt_addWhitelistEntry = new System.Windows.Forms.TextBox();
            this.btn_removeWhitelistEntry = new System.Windows.Forms.Button();
            this.btn_addWhitelistEntry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdb_blacklist = new System.Windows.Forms.RadioButton();
            this.rdb_whitelist = new System.Windows.Forms.RadioButton();
            this.btn_checkAllBlacklist = new System.Windows.Forms.Button();
            this.btn_checkNoneBlacklist = new System.Windows.Forms.Button();
            this.btn_checkNoneWhitelist = new System.Windows.Forms.Button();
            this.btn_checkAllWhitelist = new System.Windows.Forms.Button();
            this.btn_removeAllBlacklistEntries = new System.Windows.Forms.Button();
            this.btn_removeAllWhitelistEntries = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_openDestination = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addBlacklistedPacket
            // 
            this.btn_addBlacklistedPacket.Location = new System.Drawing.Point(286, 74);
            this.btn_addBlacklistedPacket.Name = "btn_addBlacklistedPacket";
            this.btn_addBlacklistedPacket.Size = new System.Drawing.Size(75, 23);
            this.btn_addBlacklistedPacket.TabIndex = 1;
            this.btn_addBlacklistedPacket.Text = "Add";
            this.btn_addBlacklistedPacket.UseVisualStyleBackColor = true;
            this.btn_addBlacklistedPacket.Click += new System.EventHandler(this.btn_addPacket_Click);
            // 
            // btn_removeBlacklistedPacket
            // 
            this.btn_removeBlacklistedPacket.Location = new System.Drawing.Point(286, 104);
            this.btn_removeBlacklistedPacket.Name = "btn_removeBlacklistedPacket";
            this.btn_removeBlacklistedPacket.Size = new System.Drawing.Size(75, 23);
            this.btn_removeBlacklistedPacket.TabIndex = 2;
            this.btn_removeBlacklistedPacket.Text = "Remove";
            this.btn_removeBlacklistedPacket.UseVisualStyleBackColor = true;
            this.btn_removeBlacklistedPacket.Click += new System.EventHandler(this.btn_removePacket_Click);
            // 
            // txt_addBlacklistEntry
            // 
            this.txt_addBlacklistEntry.Location = new System.Drawing.Point(26, 76);
            this.txt_addBlacklistEntry.Name = "txt_addBlacklistEntry";
            this.txt_addBlacklistEntry.Size = new System.Drawing.Size(254, 20);
            this.txt_addBlacklistEntry.TabIndex = 3;
            // 
            // clb_packetBlackList
            // 
            this.clb_packetBlackList.FormattingEnabled = true;
            this.clb_packetBlackList.Items.AddRange(new object[] {
            "SMSG_TIME_SYNC_REQUEST",
            "CMSG_TIME_SYNC_RESPONSE",
            "SMSG_WARDEN_DATA",
            "CMSG_WARDEN_DATA",
            "SMSG_UPDATE_WORLD_STATE",
            "CMSG_QUERY_PLAYER_NAME",
            "SMSG_QUERY_PLAYER_NAME_RESPONSE",
            "CMSG_QUERY_QUEST_INFO",
            "SMSG_QUERY_QUEST_INFO_RESPONSE",
            "CMSG_MOVE_SET_FACING",
            "CMSG_MOVE_SET_PITCH",
            "CMSG_MOVE_START_STRAFE_RIGHT",
            "CMSG_MOVE_START_STRAFE_LEFT",
            "CMSG_MOVE_START_TURN_RIGHT",
            "CMSG_MOVE_START_TURN_LEFT",
            "CMSG_MOVE_START_FORWARD",
            "CMSG_MOVE_START_ASCEND",
            "CMSG_MOVE_HEARTBEAT",
            "CMSG_MOVE_STOP",
            "CMSG_MOVE_STOP_STRAFE",
            "CMSG_PING",
            "SMSG_PONG",
            "SMSG_BATTLE_PAY_DISTRIBUTION_UPDATE",
            "CMSG_UI_TIME_REQUEST",
            "SMSG_UI_TIME",
            "SMSG_PET_STABLE_RESULT",
            "CMSG_SAVE_ENABLED_ADDONS",
            "CMSG_SAVE_CLIENT_VARIABLES",
            "CMSG_UPDATE_ACCOUNT_DATA",
            "CMSG_CANCEL_TRADE",
            "CMSG_DISCARDED_TIME_SYNC_ACKS",
            "CMSG_QUERY_REALM_NAME",
            "SMSG_REALM_QUERY_RESPONSE",
            "CMSG_QUERY_GUILD_INFO",
            "SMSG_QUERY_GUILD_INFO_RESPONSE",
            "CMSG_LOG_DISCONNECT"});
            this.clb_packetBlackList.Location = new System.Drawing.Point(26, 102);
            this.clb_packetBlackList.Name = "clb_packetBlackList";
            this.clb_packetBlackList.Size = new System.Drawing.Size(254, 319);
            this.clb_packetBlackList.TabIndex = 4;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btn_loadSource
            // 
            this.btn_loadSource.Location = new System.Drawing.Point(395, 104);
            this.btn_loadSource.Name = "btn_loadSource";
            this.btn_loadSource.Size = new System.Drawing.Size(114, 23);
            this.btn_loadSource.TabIndex = 5;
            this.btn_loadSource.Text = "Load Source";
            this.btn_loadSource.UseVisualStyleBackColor = true;
            this.btn_loadSource.Click += new System.EventHandler(this.btn_loadSource_Click);
            // 
            // clb_packetWhitelist
            // 
            this.clb_packetWhitelist.FormattingEnabled = true;
            this.clb_packetWhitelist.Items.AddRange(new object[] {
            "SMSG_CHAT",
            "SMSG_EMOTE"});
            this.clb_packetWhitelist.Location = new System.Drawing.Point(633, 102);
            this.clb_packetWhitelist.Name = "clb_packetWhitelist";
            this.clb_packetWhitelist.Size = new System.Drawing.Size(254, 319);
            this.clb_packetWhitelist.TabIndex = 10;
            // 
            // txt_addWhitelistEntry
            // 
            this.txt_addWhitelistEntry.Location = new System.Drawing.Point(633, 76);
            this.txt_addWhitelistEntry.Name = "txt_addWhitelistEntry";
            this.txt_addWhitelistEntry.Size = new System.Drawing.Size(254, 20);
            this.txt_addWhitelistEntry.TabIndex = 9;
            // 
            // btn_removeWhitelistEntry
            // 
            this.btn_removeWhitelistEntry.Location = new System.Drawing.Point(552, 104);
            this.btn_removeWhitelistEntry.Name = "btn_removeWhitelistEntry";
            this.btn_removeWhitelistEntry.Size = new System.Drawing.Size(75, 23);
            this.btn_removeWhitelistEntry.TabIndex = 8;
            this.btn_removeWhitelistEntry.Text = "Remove";
            this.btn_removeWhitelistEntry.UseVisualStyleBackColor = true;
            this.btn_removeWhitelistEntry.Click += new System.EventHandler(this.btn_removeWhitelistEntry_Click);
            // 
            // btn_addWhitelistEntry
            // 
            this.btn_addWhitelistEntry.Location = new System.Drawing.Point(552, 74);
            this.btn_addWhitelistEntry.Name = "btn_addWhitelistEntry";
            this.btn_addWhitelistEntry.Size = new System.Drawing.Size(75, 23);
            this.btn_addWhitelistEntry.TabIndex = 7;
            this.btn_addWhitelistEntry.Text = "Add";
            this.btn_addWhitelistEntry.UseVisualStyleBackColor = true;
            this.btn_addWhitelistEntry.Click += new System.EventHandler(this.btn_addWhitelistEntry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Blacklist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(728, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Whitelist";
            // 
            // rdb_blacklist
            // 
            this.rdb_blacklist.AutoSize = true;
            this.rdb_blacklist.Checked = true;
            this.rdb_blacklist.Location = new System.Drawing.Point(387, 74);
            this.rdb_blacklist.Name = "rdb_blacklist";
            this.rdb_blacklist.Size = new System.Drawing.Size(64, 17);
            this.rdb_blacklist.TabIndex = 13;
            this.rdb_blacklist.TabStop = true;
            this.rdb_blacklist.Text = "Blacklist";
            this.rdb_blacklist.UseVisualStyleBackColor = true;
            // 
            // rdb_whitelist
            // 
            this.rdb_whitelist.AutoSize = true;
            this.rdb_whitelist.Location = new System.Drawing.Point(458, 74);
            this.rdb_whitelist.Name = "rdb_whitelist";
            this.rdb_whitelist.Size = new System.Drawing.Size(65, 17);
            this.rdb_whitelist.TabIndex = 14;
            this.rdb_whitelist.Text = "Whitelist";
            this.rdb_whitelist.UseVisualStyleBackColor = true;
            // 
            // btn_checkAllBlacklist
            // 
            this.btn_checkAllBlacklist.Location = new System.Drawing.Point(26, 17);
            this.btn_checkAllBlacklist.Name = "btn_checkAllBlacklist";
            this.btn_checkAllBlacklist.Size = new System.Drawing.Size(75, 23);
            this.btn_checkAllBlacklist.TabIndex = 15;
            this.btn_checkAllBlacklist.Text = "Check All";
            this.btn_checkAllBlacklist.UseVisualStyleBackColor = true;
            this.btn_checkAllBlacklist.Click += new System.EventHandler(this.btn_checkAllBlacklist_Click);
            // 
            // btn_checkNoneBlacklist
            // 
            this.btn_checkNoneBlacklist.Location = new System.Drawing.Point(26, 46);
            this.btn_checkNoneBlacklist.Name = "btn_checkNoneBlacklist";
            this.btn_checkNoneBlacklist.Size = new System.Drawing.Size(75, 23);
            this.btn_checkNoneBlacklist.TabIndex = 16;
            this.btn_checkNoneBlacklist.Text = "Check None";
            this.btn_checkNoneBlacklist.UseVisualStyleBackColor = true;
            this.btn_checkNoneBlacklist.Click += new System.EventHandler(this.btn_checkNoneBlacklist_Click);
            // 
            // btn_checkNoneWhitelist
            // 
            this.btn_checkNoneWhitelist.Location = new System.Drawing.Point(633, 46);
            this.btn_checkNoneWhitelist.Name = "btn_checkNoneWhitelist";
            this.btn_checkNoneWhitelist.Size = new System.Drawing.Size(75, 23);
            this.btn_checkNoneWhitelist.TabIndex = 18;
            this.btn_checkNoneWhitelist.Text = "Check None";
            this.btn_checkNoneWhitelist.UseVisualStyleBackColor = true;
            this.btn_checkNoneWhitelist.Click += new System.EventHandler(this.btn_checkNoneWhitelist_Click);
            // 
            // btn_checkAllWhitelist
            // 
            this.btn_checkAllWhitelist.Location = new System.Drawing.Point(633, 17);
            this.btn_checkAllWhitelist.Name = "btn_checkAllWhitelist";
            this.btn_checkAllWhitelist.Size = new System.Drawing.Size(75, 23);
            this.btn_checkAllWhitelist.TabIndex = 17;
            this.btn_checkAllWhitelist.Text = "Check All";
            this.btn_checkAllWhitelist.UseVisualStyleBackColor = true;
            this.btn_checkAllWhitelist.Click += new System.EventHandler(this.btn_checkAllWhitelist_Click);
            // 
            // btn_removeAllBlacklistEntries
            // 
            this.btn_removeAllBlacklistEntries.Location = new System.Drawing.Point(286, 133);
            this.btn_removeAllBlacklistEntries.Name = "btn_removeAllBlacklistEntries";
            this.btn_removeAllBlacklistEntries.Size = new System.Drawing.Size(75, 23);
            this.btn_removeAllBlacklistEntries.TabIndex = 19;
            this.btn_removeAllBlacklistEntries.Text = "Remove All";
            this.btn_removeAllBlacklistEntries.UseVisualStyleBackColor = true;
            this.btn_removeAllBlacklistEntries.Click += new System.EventHandler(this.btn_removeAllBlacklistEntries_Click);
            // 
            // btn_removeAllWhitelistEntries
            // 
            this.btn_removeAllWhitelistEntries.Location = new System.Drawing.Point(552, 133);
            this.btn_removeAllWhitelistEntries.Name = "btn_removeAllWhitelistEntries";
            this.btn_removeAllWhitelistEntries.Size = new System.Drawing.Size(75, 23);
            this.btn_removeAllWhitelistEntries.TabIndex = 20;
            this.btn_removeAllWhitelistEntries.Text = "Remove All";
            this.btn_removeAllWhitelistEntries.UseVisualStyleBackColor = true;
            this.btn_removeAllWhitelistEntries.Click += new System.EventHandler(this.btn_removeAllWhitelistEntries_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Filtered file saves to the program .exe folder";
            // 
            // btn_openDestination
            // 
            this.btn_openDestination.Location = new System.Drawing.Point(395, 134);
            this.btn_openDestination.Name = "btn_openDestination";
            this.btn_openDestination.Size = new System.Drawing.Size(114, 23);
            this.btn_openDestination.TabIndex = 22;
            this.btn_openDestination.Text = "Open Destination";
            this.btn_openDestination.UseVisualStyleBackColor = true;
            this.btn_openDestination.Click += new System.EventHandler(this.btn_openDestination_Click);
            // 
            // frm_filterer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 489);
            this.Controls.Add(this.btn_openDestination);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_removeAllWhitelistEntries);
            this.Controls.Add(this.btn_removeAllBlacklistEntries);
            this.Controls.Add(this.btn_checkNoneWhitelist);
            this.Controls.Add(this.btn_checkAllWhitelist);
            this.Controls.Add(this.btn_checkNoneBlacklist);
            this.Controls.Add(this.btn_checkAllBlacklist);
            this.Controls.Add(this.rdb_whitelist);
            this.Controls.Add(this.rdb_blacklist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clb_packetWhitelist);
            this.Controls.Add(this.txt_addWhitelistEntry);
            this.Controls.Add(this.btn_removeWhitelistEntry);
            this.Controls.Add(this.btn_addWhitelistEntry);
            this.Controls.Add(this.btn_loadSource);
            this.Controls.Add(this.clb_packetBlackList);
            this.Controls.Add(this.txt_addBlacklistEntry);
            this.Controls.Add(this.btn_removeBlacklistedPacket);
            this.Controls.Add(this.btn_addBlacklistedPacket);
            this.Name = "frm_filterer";
            this.Text = "Frm_Filterer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_addBlacklistedPacket;
        private System.Windows.Forms.Button btn_removeBlacklistedPacket;
        private System.Windows.Forms.TextBox txt_addBlacklistEntry;
        private System.Windows.Forms.CheckedListBox clb_packetBlackList;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btn_loadSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.CheckedListBox clb_packetWhitelist;
        private System.Windows.Forms.TextBox txt_addWhitelistEntry;
        private System.Windows.Forms.Button btn_removeWhitelistEntry;
        private System.Windows.Forms.Button btn_addWhitelistEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdb_blacklist;
        private System.Windows.Forms.RadioButton rdb_whitelist;
        private System.Windows.Forms.Button btn_checkAllBlacklist;
        private System.Windows.Forms.Button btn_checkNoneBlacklist;
        private System.Windows.Forms.Button btn_checkNoneWhitelist;
        private System.Windows.Forms.Button btn_checkAllWhitelist;
        private System.Windows.Forms.Button btn_removeAllBlacklistEntries;
        private System.Windows.Forms.Button btn_removeAllWhitelistEntries;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_openDestination;
    }
}