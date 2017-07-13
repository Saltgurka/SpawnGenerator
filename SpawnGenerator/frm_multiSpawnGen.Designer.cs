namespace SpawnGenerator
{
    partial class frm_multiSpawnGen
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
            this.dgv_grid = new System.Windows.Forms.DataGridView();
            this.gridColumn_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_entry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_guidLow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_guidFull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_o = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_map = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_loadSniff = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtxt_SQLResult = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_generateMarked = new System.Windows.Forms.Button();
            this.txt_creatureGUID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_spawnMax = new System.Windows.Forms.TextBox();
            this.txt_spawnMin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_spawnMask = new System.Windows.Forms.TextBox();
            this.txt_map = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_equipmentId = new System.Windows.Forms.TextBox();
            this.txt_modelid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_curmana = new System.Windows.Forms.TextBox();
            this.txt_curhealth = new System.Windows.Forms.TextBox();
            this.txt_deathState = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_currentWaypoint = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_movementType = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_spawndist = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_deleteDuplicate = new System.Windows.Forms.Button();
            this.btn_moreFiles = new System.Windows.Forms.Button();
            this.lbl_rows = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_grid
            // 
            this.dgv_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridColumn_type,
            this.gridColumn_entry,
            this.gridColumn_guidLow,
            this.gridColumn_guidFull,
            this.gridColumn_x,
            this.gridColumn_y,
            this.gridColumn_z,
            this.gridColumn_o,
            this.gridColumn_map});
            this.dgv_grid.Location = new System.Drawing.Point(-4, 0);
            this.dgv_grid.Name = "dgv_grid";
            this.dgv_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_grid.Size = new System.Drawing.Size(982, 569);
            this.dgv_grid.TabIndex = 0;
            this.dgv_grid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_grid_RowsAdded);
            this.dgv_grid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_grid_RowsRemoved);
            // 
            // gridColumn_type
            // 
            this.gridColumn_type.HeaderText = "Type";
            this.gridColumn_type.Name = "gridColumn_type";
            // 
            // gridColumn_entry
            // 
            this.gridColumn_entry.HeaderText = "Entry";
            this.gridColumn_entry.Name = "gridColumn_entry";
            // 
            // gridColumn_guidLow
            // 
            this.gridColumn_guidLow.HeaderText = "GUIDLow";
            this.gridColumn_guidLow.Name = "gridColumn_guidLow";
            // 
            // gridColumn_guidFull
            // 
            this.gridColumn_guidFull.HeaderText = "GUIDFull";
            this.gridColumn_guidFull.Name = "gridColumn_guidFull";
            // 
            // gridColumn_x
            // 
            this.gridColumn_x.HeaderText = "x";
            this.gridColumn_x.Name = "gridColumn_x";
            // 
            // gridColumn_y
            // 
            this.gridColumn_y.HeaderText = "y";
            this.gridColumn_y.Name = "gridColumn_y";
            // 
            // gridColumn_z
            // 
            this.gridColumn_z.HeaderText = "z";
            this.gridColumn_z.Name = "gridColumn_z";
            // 
            // gridColumn_o
            // 
            this.gridColumn_o.HeaderText = "o";
            this.gridColumn_o.Name = "gridColumn_o";
            // 
            // gridColumn_map
            // 
            this.gridColumn_map.HeaderText = "Map";
            this.gridColumn_map.Name = "gridColumn_map";
            // 
            // btn_loadSniff
            // 
            this.btn_loadSniff.Location = new System.Drawing.Point(999, 48);
            this.btn_loadSniff.Name = "btn_loadSniff";
            this.btn_loadSniff.Size = new System.Drawing.Size(117, 23);
            this.btn_loadSniff.TabIndex = 1;
            this.btn_loadSniff.Text = "Load Sniff File";
            this.btn_loadSniff.UseVisualStyleBackColor = true;
            this.btn_loadSniff.Click += new System.EventHandler(this.btn_loadSniff_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(986, 591);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtxt_SQLResult);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(978, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtxt_SQLResult
            // 
            this.rtxt_SQLResult.Location = new System.Drawing.Point(0, 4);
            this.rtxt_SQLResult.Name = "rtxt_SQLResult";
            this.rtxt_SQLResult.Size = new System.Drawing.Size(975, 561);
            this.rtxt_SQLResult.TabIndex = 0;
            this.rtxt_SQLResult.Text = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_grid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(978, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_generateMarked
            // 
            this.btn_generateMarked.Location = new System.Drawing.Point(1000, 106);
            this.btn_generateMarked.Name = "btn_generateMarked";
            this.btn_generateMarked.Size = new System.Drawing.Size(117, 23);
            this.btn_generateMarked.TabIndex = 3;
            this.btn_generateMarked.Text = "Generate Marked";
            this.btn_generateMarked.UseVisualStyleBackColor = true;
            this.btn_generateMarked.Click += new System.EventHandler(this.btn_generateMarked_Click);
            // 
            // txt_creatureGUID
            // 
            this.txt_creatureGUID.Location = new System.Drawing.Point(999, 200);
            this.txt_creatureGUID.Name = "txt_creatureGUID";
            this.txt_creatureGUID.Size = new System.Drawing.Size(117, 20);
            this.txt_creatureGUID.TabIndex = 4;
            this.txt_creatureGUID.Text = "Creature GUID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1000, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Creature GUID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1059, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "maxSpawn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(996, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "minSpawn";
            // 
            // txt_spawnMax
            // 
            this.txt_spawnMax.Location = new System.Drawing.Point(1059, 243);
            this.txt_spawnMax.Name = "txt_spawnMax";
            this.txt_spawnMax.Size = new System.Drawing.Size(57, 20);
            this.txt_spawnMax.TabIndex = 21;
            this.txt_spawnMax.Text = "300";
            // 
            // txt_spawnMin
            // 
            this.txt_spawnMin.Location = new System.Drawing.Point(996, 243);
            this.txt_spawnMin.Name = "txt_spawnMin";
            this.txt_spawnMin.Size = new System.Drawing.Size(57, 20);
            this.txt_spawnMin.TabIndex = 20;
            this.txt_spawnMin.Text = "300";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1040, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "spawnmask";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1004, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Map";
            // 
            // txt_spawnMask
            // 
            this.txt_spawnMask.Location = new System.Drawing.Point(1043, 287);
            this.txt_spawnMask.Name = "txt_spawnMask";
            this.txt_spawnMask.Size = new System.Drawing.Size(59, 20);
            this.txt_spawnMask.TabIndex = 25;
            this.txt_spawnMask.Text = "1";
            // 
            // txt_map
            // 
            this.txt_map.Location = new System.Drawing.Point(1004, 287);
            this.txt_map.Name = "txt_map";
            this.txt_map.Size = new System.Drawing.Size(33, 20);
            this.txt_map.TabIndex = 24;
            this.txt_map.Text = "530";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1059, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "equipment_id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(999, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "modelid";
            // 
            // txt_equipmentId
            // 
            this.txt_equipmentId.Location = new System.Drawing.Point(1059, 333);
            this.txt_equipmentId.Name = "txt_equipmentId";
            this.txt_equipmentId.Size = new System.Drawing.Size(59, 20);
            this.txt_equipmentId.TabIndex = 29;
            this.txt_equipmentId.Text = "0";
            // 
            // txt_modelid
            // 
            this.txt_modelid.Location = new System.Drawing.Point(999, 333);
            this.txt_modelid.Name = "txt_modelid";
            this.txt_modelid.Size = new System.Drawing.Size(54, 20);
            this.txt_modelid.TabIndex = 28;
            this.txt_modelid.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1059, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "curmana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(997, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "curhealth";
            // 
            // txt_curmana
            // 
            this.txt_curmana.Location = new System.Drawing.Point(1059, 374);
            this.txt_curmana.Name = "txt_curmana";
            this.txt_curmana.Size = new System.Drawing.Size(56, 20);
            this.txt_curmana.TabIndex = 33;
            this.txt_curmana.Text = "XXXX";
            // 
            // txt_curhealth
            // 
            this.txt_curhealth.Location = new System.Drawing.Point(997, 374);
            this.txt_curhealth.Name = "txt_curhealth";
            this.txt_curhealth.Size = new System.Drawing.Size(56, 20);
            this.txt_curhealth.TabIndex = 32;
            this.txt_curhealth.Text = "XXXX";
            // 
            // txt_deathState
            // 
            this.txt_deathState.Location = new System.Drawing.Point(1068, 412);
            this.txt_deathState.Name = "txt_deathState";
            this.txt_deathState.Size = new System.Drawing.Size(34, 20);
            this.txt_deathState.TabIndex = 39;
            this.txt_deathState.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1057, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "DeathState";
            // 
            // txt_currentWaypoint
            // 
            this.txt_currentWaypoint.Location = new System.Drawing.Point(1004, 412);
            this.txt_currentWaypoint.Name = "txt_currentWaypoint";
            this.txt_currentWaypoint.Size = new System.Drawing.Size(34, 20);
            this.txt_currentWaypoint.TabIndex = 37;
            this.txt_currentWaypoint.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(996, 396);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "curwaypoint";
            // 
            // txt_movementType
            // 
            this.txt_movementType.Location = new System.Drawing.Point(1004, 458);
            this.txt_movementType.Name = "txt_movementType";
            this.txt_movementType.Size = new System.Drawing.Size(100, 20);
            this.txt_movementType.TabIndex = 41;
            this.txt_movementType.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1018, 442);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "MovementType";
            // 
            // txt_spawndist
            // 
            this.txt_spawndist.Location = new System.Drawing.Point(1004, 499);
            this.txt_spawndist.Name = "txt_spawndist";
            this.txt_spawndist.Size = new System.Drawing.Size(100, 20);
            this.txt_spawndist.TabIndex = 43;
            this.txt_spawndist.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1024, 482);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "spawndist";
            // 
            // btn_deleteDuplicate
            // 
            this.btn_deleteDuplicate.Location = new System.Drawing.Point(1000, 135);
            this.btn_deleteDuplicate.Name = "btn_deleteDuplicate";
            this.btn_deleteDuplicate.Size = new System.Drawing.Size(117, 23);
            this.btn_deleteDuplicate.TabIndex = 44;
            this.btn_deleteDuplicate.Text = "Delete Duplicates";
            this.btn_deleteDuplicate.UseVisualStyleBackColor = true;
            this.btn_deleteDuplicate.Click += new System.EventHandler(this.btn_deleteDuplicate_Click);
            // 
            // btn_moreFiles
            // 
            this.btn_moreFiles.Enabled = false;
            this.btn_moreFiles.Location = new System.Drawing.Point(999, 77);
            this.btn_moreFiles.Name = "btn_moreFiles";
            this.btn_moreFiles.Size = new System.Drawing.Size(117, 23);
            this.btn_moreFiles.TabIndex = 45;
            this.btn_moreFiles.Text = "Load More Files";
            this.btn_moreFiles.UseVisualStyleBackColor = true;
            this.btn_moreFiles.Click += new System.EventHandler(this.btn_moreFiles_Click);
            // 
            // lbl_rows
            // 
            this.lbl_rows.AutoSize = true;
            this.lbl_rows.Location = new System.Drawing.Point(999, 13);
            this.lbl_rows.Name = "lbl_rows";
            this.lbl_rows.Size = new System.Drawing.Size(46, 13);
            this.lbl_rows.TabIndex = 46;
            this.lbl_rows.Text = "Rows: 0";
            // 
            // frm_multiSpawnGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 605);
            this.Controls.Add(this.lbl_rows);
            this.Controls.Add(this.btn_moreFiles);
            this.Controls.Add(this.btn_deleteDuplicate);
            this.Controls.Add(this.txt_spawndist);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_movementType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_deathState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_currentWaypoint);
            this.Controls.Add(this.txt_curmana);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_curhealth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_equipmentId);
            this.Controls.Add(this.txt_modelid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_spawnMask);
            this.Controls.Add(this.txt_map);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_spawnMax);
            this.Controls.Add(this.txt_spawnMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_creatureGUID);
            this.Controls.Add(this.btn_generateMarked);
            this.Controls.Add(this.btn_loadSniff);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_multiSpawnGen";
            this.Text = "frm_multiSpawnGen";
            this.Load += new System.EventHandler(this.frm_multiSpawnGen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_entry;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_guidLow;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_guidFull;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_x;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_y;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_z;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_o;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_map;
        private System.Windows.Forms.Button btn_loadSniff;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtxt_SQLResult;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_generateMarked;
        private System.Windows.Forms.TextBox txt_creatureGUID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_spawnMax;
        private System.Windows.Forms.TextBox txt_spawnMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_spawnMask;
        private System.Windows.Forms.TextBox txt_map;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_equipmentId;
        private System.Windows.Forms.TextBox txt_modelid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_curmana;
        private System.Windows.Forms.TextBox txt_curhealth;
        private System.Windows.Forms.TextBox txt_deathState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_currentWaypoint;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_movementType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_spawndist;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_deleteDuplicate;
        private System.Windows.Forms.Button btn_moreFiles;
        private System.Windows.Forms.Label lbl_rows;
    }
}