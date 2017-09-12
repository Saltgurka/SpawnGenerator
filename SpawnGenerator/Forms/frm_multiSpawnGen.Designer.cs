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
            this.btn_loadSniff = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dgv_gameobjectGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtxt_SQLResult = new System.Windows.Forms.RichTextBox();
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
            this.lbl_rows = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_state = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_animprogress = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_dbscriptComment = new System.Windows.Forms.TextBox();
            this.box_dbscriptActiveObject = new System.Windows.Forms.CheckBox();
            this.box_dbscriptRunOn = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_dbscriptPathId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_dbscriptDespawnTime = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_dbscriptDelay = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_dbscriptID = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_waypointScriptId = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_waypointWaittime = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_waypointPathId = new System.Windows.Forms.TextBox();
            this.rdb_asSpawns = new System.Windows.Forms.RadioButton();
            this.rdb_asDbscript = new System.Windows.Forms.RadioButton();
            this.rdb_asWaypoints = new System.Windows.Forms.RadioButton();
            this.box_createObject2 = new System.Windows.Forms.CheckBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.lbl_currentFileCount = new System.Windows.Forms.Label();
            this.txt_filterText = new System.Windows.Forms.TextBox();
            this.btn_filter = new System.Windows.Forms.Button();
            this.box_ai = new System.Windows.Forms.CheckBox();
            this.box_filename = new System.Windows.Forms.CheckBox();
            this.cmb_typeFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gameobjectGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_grid
            // 
            this.dgv_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_grid.Location = new System.Drawing.Point(-4, 0);
            this.dgv_grid.Name = "dgv_grid";
            this.dgv_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_grid.Size = new System.Drawing.Size(982, 569);
            this.dgv_grid.TabIndex = 0;
            this.dgv_grid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_grid_RowsAdded);
            this.dgv_grid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_grid_RowsRemoved);
            // 
            // btn_loadSniff
            // 
            this.btn_loadSniff.Location = new System.Drawing.Point(999, 48);
            this.btn_loadSniff.Name = "btn_loadSniff";
            this.btn_loadSniff.Size = new System.Drawing.Size(117, 23);
            this.btn_loadSniff.TabIndex = 1;
            this.btn_loadSniff.Text = "Load Sniff File(s)";
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
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(986, 591);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_grid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(978, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Creatures";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dgv_gameobjectGrid);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(978, 565);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Gameobjects";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dgv_gameobjectGrid
            // 
            this.dgv_gameobjectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gameobjectGrid.Location = new System.Drawing.Point(-2, -2);
            this.dgv_gameobjectGrid.Name = "dgv_gameobjectGrid";
            this.dgv_gameobjectGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_gameobjectGrid.Size = new System.Drawing.Size(982, 569);
            this.dgv_gameobjectGrid.TabIndex = 1;
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
            this.txt_creatureGUID.Location = new System.Drawing.Point(6, 25);
            this.txt_creatureGUID.Name = "txt_creatureGUID";
            this.txt_creatureGUID.Size = new System.Drawing.Size(116, 20);
            this.txt_creatureGUID.TabIndex = 4;
            this.txt_creatureGUID.Text = "GUID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "GUID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "maxSpawn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "minSpawn";
            // 
            // txt_spawnMax
            // 
            this.txt_spawnMax.Location = new System.Drawing.Point(66, 68);
            this.txt_spawnMax.Name = "txt_spawnMax";
            this.txt_spawnMax.Size = new System.Drawing.Size(57, 20);
            this.txt_spawnMax.TabIndex = 21;
            this.txt_spawnMax.Text = "300";
            // 
            // txt_spawnMin
            // 
            this.txt_spawnMin.Location = new System.Drawing.Point(3, 68);
            this.txt_spawnMin.Name = "txt_spawnMin";
            this.txt_spawnMin.Size = new System.Drawing.Size(57, 20);
            this.txt_spawnMin.TabIndex = 20;
            this.txt_spawnMin.Text = "300";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "spawnmask";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Map";
            // 
            // txt_spawnMask
            // 
            this.txt_spawnMask.Location = new System.Drawing.Point(50, 112);
            this.txt_spawnMask.Name = "txt_spawnMask";
            this.txt_spawnMask.Size = new System.Drawing.Size(59, 20);
            this.txt_spawnMask.TabIndex = 25;
            this.txt_spawnMask.Text = "1";
            // 
            // txt_map
            // 
            this.txt_map.Location = new System.Drawing.Point(11, 112);
            this.txt_map.Name = "txt_map";
            this.txt_map.Size = new System.Drawing.Size(33, 20);
            this.txt_map.TabIndex = 24;
            this.txt_map.Text = "530";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "equipment_id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "modelid";
            // 
            // txt_equipmentId
            // 
            this.txt_equipmentId.Location = new System.Drawing.Point(66, 158);
            this.txt_equipmentId.Name = "txt_equipmentId";
            this.txt_equipmentId.Size = new System.Drawing.Size(59, 20);
            this.txt_equipmentId.TabIndex = 29;
            this.txt_equipmentId.Text = "0";
            // 
            // txt_modelid
            // 
            this.txt_modelid.Location = new System.Drawing.Point(6, 158);
            this.txt_modelid.Name = "txt_modelid";
            this.txt_modelid.Size = new System.Drawing.Size(54, 20);
            this.txt_modelid.TabIndex = 28;
            this.txt_modelid.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "curmana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "curhealth";
            // 
            // txt_curmana
            // 
            this.txt_curmana.Location = new System.Drawing.Point(66, 199);
            this.txt_curmana.Name = "txt_curmana";
            this.txt_curmana.Size = new System.Drawing.Size(56, 20);
            this.txt_curmana.TabIndex = 33;
            this.txt_curmana.Text = "1";
            // 
            // txt_curhealth
            // 
            this.txt_curhealth.Location = new System.Drawing.Point(4, 199);
            this.txt_curhealth.Name = "txt_curhealth";
            this.txt_curhealth.Size = new System.Drawing.Size(56, 20);
            this.txt_curhealth.TabIndex = 32;
            this.txt_curhealth.Text = "1";
            // 
            // txt_deathState
            // 
            this.txt_deathState.Location = new System.Drawing.Point(75, 237);
            this.txt_deathState.Name = "txt_deathState";
            this.txt_deathState.Size = new System.Drawing.Size(34, 20);
            this.txt_deathState.TabIndex = 39;
            this.txt_deathState.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "DeathState";
            // 
            // txt_currentWaypoint
            // 
            this.txt_currentWaypoint.Location = new System.Drawing.Point(11, 237);
            this.txt_currentWaypoint.Name = "txt_currentWaypoint";
            this.txt_currentWaypoint.Size = new System.Drawing.Size(34, 20);
            this.txt_currentWaypoint.TabIndex = 37;
            this.txt_currentWaypoint.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "curwaypoint";
            // 
            // txt_movementType
            // 
            this.txt_movementType.Location = new System.Drawing.Point(11, 283);
            this.txt_movementType.Name = "txt_movementType";
            this.txt_movementType.Size = new System.Drawing.Size(100, 20);
            this.txt_movementType.TabIndex = 41;
            this.txt_movementType.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "MovementType";
            // 
            // txt_spawndist
            // 
            this.txt_spawndist.Location = new System.Drawing.Point(11, 324);
            this.txt_spawndist.Name = "txt_spawndist";
            this.txt_spawndist.Size = new System.Drawing.Size(100, 20);
            this.txt_spawndist.TabIndex = 43;
            this.txt_spawndist.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 307);
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
            // lbl_rows
            // 
            this.lbl_rows.AutoSize = true;
            this.lbl_rows.Location = new System.Drawing.Point(999, 13);
            this.lbl_rows.Name = "lbl_rows";
            this.lbl_rows.Size = new System.Drawing.Size(46, 13);
            this.lbl_rows.TabIndex = 46;
            this.lbl_rows.Text = "Rows: 0";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(1002, 188);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(262, 401);
            this.tabControl2.TabIndex = 48;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.box_filename);
            this.tabPage3.Controls.Add(this.box_ai);
            this.tabPage3.Controls.Add(this.txt_state);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.txt_animprogress);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.txt_creatureGUID);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txt_spawnMin);
            this.tabPage3.Controls.Add(this.txt_spawnMax);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txt_spawndist);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.txt_map);
            this.tabPage3.Controls.Add(this.txt_movementType);
            this.tabPage3.Controls.Add(this.txt_spawnMask);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txt_deathState);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txt_modelid);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txt_equipmentId);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txt_currentWaypoint);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txt_curmana);
            this.tabPage3.Controls.Add(this.txt_curhealth);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(254, 375);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "spawn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_state
            // 
            this.txt_state.Location = new System.Drawing.Point(143, 68);
            this.txt_state.Name = "txt_state";
            this.txt_state.Size = new System.Drawing.Size(33, 20);
            this.txt_state.TabIndex = 47;
            this.txt_state.Text = "1";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(143, 50);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(30, 13);
            this.label23.TabIndex = 46;
            this.label23.Text = "state";
            // 
            // txt_animprogress
            // 
            this.txt_animprogress.Location = new System.Drawing.Point(143, 25);
            this.txt_animprogress.Name = "txt_animprogress";
            this.txt_animprogress.Size = new System.Drawing.Size(33, 20);
            this.txt_animprogress.TabIndex = 45;
            this.txt_animprogress.Text = "100";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(140, 5);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 13);
            this.label22.TabIndex = 44;
            this.label22.Text = "animprogress";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(254, 375);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "DBScript";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txt_dbscriptComment);
            this.groupBox1.Controls.Add(this.box_dbscriptActiveObject);
            this.groupBox1.Controls.Add(this.box_dbscriptRunOn);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txt_dbscriptPathId);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txt_dbscriptDespawnTime);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_dbscriptDelay);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_dbscriptID);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Values";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 129);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Comment";
            // 
            // txt_dbscriptComment
            // 
            this.txt_dbscriptComment.Location = new System.Drawing.Point(84, 126);
            this.txt_dbscriptComment.Name = "txt_dbscriptComment";
            this.txt_dbscriptComment.Size = new System.Drawing.Size(123, 20);
            this.txt_dbscriptComment.TabIndex = 10;
            // 
            // box_dbscriptActiveObject
            // 
            this.box_dbscriptActiveObject.AutoSize = true;
            this.box_dbscriptActiveObject.Location = new System.Drawing.Point(84, 206);
            this.box_dbscriptActiveObject.Name = "box_dbscriptActiveObject";
            this.box_dbscriptActiveObject.Size = new System.Drawing.Size(90, 17);
            this.box_dbscriptActiveObject.TabIndex = 9;
            this.box_dbscriptActiveObject.Text = "Active Object";
            this.box_dbscriptActiveObject.UseVisualStyleBackColor = true;
            // 
            // box_dbscriptRunOn
            // 
            this.box_dbscriptRunOn.AutoSize = true;
            this.box_dbscriptRunOn.Location = new System.Drawing.Point(84, 182);
            this.box_dbscriptRunOn.Name = "box_dbscriptRunOn";
            this.box_dbscriptRunOn.Size = new System.Drawing.Size(63, 17);
            this.box_dbscriptRunOn.TabIndex = 8;
            this.box_dbscriptRunOn.Text = "Run On";
            this.box_dbscriptRunOn.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "PathId";
            // 
            // txt_dbscriptPathId
            // 
            this.txt_dbscriptPathId.Location = new System.Drawing.Point(84, 100);
            this.txt_dbscriptPathId.Name = "txt_dbscriptPathId";
            this.txt_dbscriptPathId.Size = new System.Drawing.Size(123, 20);
            this.txt_dbscriptPathId.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "DespawnTime";
            // 
            // txt_dbscriptDespawnTime
            // 
            this.txt_dbscriptDespawnTime.Location = new System.Drawing.Point(84, 73);
            this.txt_dbscriptDespawnTime.Name = "txt_dbscriptDespawnTime";
            this.txt_dbscriptDespawnTime.Size = new System.Drawing.Size(123, 20);
            this.txt_dbscriptDespawnTime.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Delay";
            // 
            // txt_dbscriptDelay
            // 
            this.txt_dbscriptDelay.Location = new System.Drawing.Point(84, 46);
            this.txt_dbscriptDelay.Name = "txt_dbscriptDelay";
            this.txt_dbscriptDelay.Size = new System.Drawing.Size(123, 20);
            this.txt_dbscriptDelay.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "ID";
            // 
            // txt_dbscriptID
            // 
            this.txt_dbscriptID.Location = new System.Drawing.Point(84, 20);
            this.txt_dbscriptID.Name = "txt_dbscriptID";
            this.txt_dbscriptID.Size = new System.Drawing.Size(123, 20);
            this.txt_dbscriptID.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(254, 375);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "creature_movement_template";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txt_waypointScriptId);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txt_waypointWaittime);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txt_waypointPathId);
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 362);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Values";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 72);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "Script ID";
            // 
            // txt_waypointScriptId
            // 
            this.txt_waypointScriptId.Location = new System.Drawing.Point(75, 69);
            this.txt_waypointScriptId.Name = "txt_waypointScriptId";
            this.txt_waypointScriptId.Size = new System.Drawing.Size(160, 20);
            this.txt_waypointScriptId.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 46);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Waittime";
            // 
            // txt_waypointWaittime
            // 
            this.txt_waypointWaittime.Location = new System.Drawing.Point(75, 43);
            this.txt_waypointWaittime.Name = "txt_waypointWaittime";
            this.txt_waypointWaittime.Size = new System.Drawing.Size(160, 20);
            this.txt_waypointWaittime.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "PathId";
            // 
            // txt_waypointPathId
            // 
            this.txt_waypointPathId.Location = new System.Drawing.Point(75, 17);
            this.txt_waypointPathId.Name = "txt_waypointPathId";
            this.txt_waypointPathId.Size = new System.Drawing.Size(160, 20);
            this.txt_waypointPathId.TabIndex = 0;
            // 
            // rdb_asSpawns
            // 
            this.rdb_asSpawns.AutoSize = true;
            this.rdb_asSpawns.Checked = true;
            this.rdb_asSpawns.Location = new System.Drawing.Point(1000, 165);
            this.rdb_asSpawns.Name = "rdb_asSpawns";
            this.rdb_asSpawns.Size = new System.Drawing.Size(78, 17);
            this.rdb_asSpawns.TabIndex = 49;
            this.rdb_asSpawns.TabStop = true;
            this.rdb_asSpawns.Text = "As Spawns";
            this.rdb_asSpawns.UseVisualStyleBackColor = true;
            // 
            // rdb_asDbscript
            // 
            this.rdb_asDbscript.AutoSize = true;
            this.rdb_asDbscript.Location = new System.Drawing.Point(1091, 165);
            this.rdb_asDbscript.Name = "rdb_asDbscript";
            this.rdb_asDbscript.Size = new System.Drawing.Size(97, 17);
            this.rdb_asDbscript.TabIndex = 50;
            this.rdb_asDbscript.Text = "As DBScript 10";
            this.rdb_asDbscript.UseVisualStyleBackColor = true;
            // 
            // rdb_asWaypoints
            // 
            this.rdb_asWaypoints.AutoSize = true;
            this.rdb_asWaypoints.Location = new System.Drawing.Point(1194, 165);
            this.rdb_asWaypoints.Name = "rdb_asWaypoints";
            this.rdb_asWaypoints.Size = new System.Drawing.Size(180, 17);
            this.rdb_asWaypoints.TabIndex = 51;
            this.rdb_asWaypoints.Text = "As creature_movement_template";
            this.rdb_asWaypoints.UseVisualStyleBackColor = true;
            // 
            // box_createObject2
            // 
            this.box_createObject2.AutoSize = true;
            this.box_createObject2.Checked = true;
            this.box_createObject2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.box_createObject2.Location = new System.Drawing.Point(1122, 52);
            this.box_createObject2.Name = "box_createObject2";
            this.box_createObject2.Size = new System.Drawing.Size(118, 17);
            this.box_createObject2.TabIndex = 52;
            this.box_createObject2.Text = "Only CreateObject2";
            this.box_createObject2.UseVisualStyleBackColor = true;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(208, 7);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(780, 18);
            this.progress.TabIndex = 53;
            // 
            // lbl_currentFileCount
            // 
            this.lbl_currentFileCount.AutoSize = true;
            this.lbl_currentFileCount.Location = new System.Drawing.Point(1078, 13);
            this.lbl_currentFileCount.Name = "lbl_currentFileCount";
            this.lbl_currentFileCount.Size = new System.Drawing.Size(43, 13);
            this.lbl_currentFileCount.TabIndex = 54;
            this.lbl_currentFileCount.Text = "File 0/0";
            // 
            // txt_filterText
            // 
            this.txt_filterText.Location = new System.Drawing.Point(1002, 77);
            this.txt_filterText.Name = "txt_filterText";
            this.txt_filterText.Size = new System.Drawing.Size(115, 20);
            this.txt_filterText.TabIndex = 55;
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(1122, 74);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(117, 23);
            this.btn_filter.TabIndex = 56;
            this.btn_filter.Text = "Filter By Entry";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // box_ai
            // 
            this.box_ai.AutoSize = true;
            this.box_ai.Location = new System.Drawing.Point(66, 5);
            this.box_ai.Name = "box_ai";
            this.box_ai.Size = new System.Drawing.Size(36, 17);
            this.box_ai.TabIndex = 49;
            this.box_ai.Text = "AI";
            this.box_ai.UseVisualStyleBackColor = true;
            // 
            // box_filename
            // 
            this.box_filename.AutoSize = true;
            this.box_filename.Location = new System.Drawing.Point(143, 95);
            this.box_filename.Name = "box_filename";
            this.box_filename.Size = new System.Drawing.Size(70, 17);
            this.box_filename.TabIndex = 50;
            this.box_filename.Text = "FileName";
            this.box_filename.UseVisualStyleBackColor = true;
            // 
            // cmb_typeFilter
            // 
            this.cmb_typeFilter.FormattingEnabled = true;
            this.cmb_typeFilter.Items.AddRange(new object[] {
            "Creature",
            "Gameobject",
            "AreaTrigger",
            "Player",
            "Pet",
            "Unit"});
            this.cmb_typeFilter.Location = new System.Drawing.Point(1122, 106);
            this.cmb_typeFilter.Name = "cmb_typeFilter";
            this.cmb_typeFilter.Size = new System.Drawing.Size(121, 21);
            this.cmb_typeFilter.TabIndex = 57;
            this.cmb_typeFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frm_multiSpawnGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 612);
            this.Controls.Add(this.cmb_typeFilter);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.txt_filterText);
            this.Controls.Add(this.lbl_currentFileCount);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.box_createObject2);
            this.Controls.Add(this.rdb_asWaypoints);
            this.Controls.Add(this.rdb_asDbscript);
            this.Controls.Add(this.rdb_asSpawns);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.lbl_rows);
            this.Controls.Add(this.btn_deleteDuplicate);
            this.Controls.Add(this.btn_generateMarked);
            this.Controls.Add(this.btn_loadSniff);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_multiSpawnGen";
            this.Text = "frm_multiSpawnGen";
            this.Load += new System.EventHandler(this.frm_multiSpawnGen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gameobjectGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_grid;
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
        private System.Windows.Forms.Label lbl_rows;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_dbscriptID;
        private System.Windows.Forms.TextBox txt_dbscriptDelay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_dbscriptPathId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_dbscriptDespawnTime;
        private System.Windows.Forms.CheckBox box_dbscriptActiveObject;
        private System.Windows.Forms.CheckBox box_dbscriptRunOn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_dbscriptComment;
        private System.Windows.Forms.RadioButton rdb_asSpawns;
        private System.Windows.Forms.RadioButton rdb_asDbscript;
        private System.Windows.Forms.RadioButton rdb_asWaypoints;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_waypointPathId;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_waypointWaittime;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_waypointScriptId;
        private System.Windows.Forms.CheckBox box_createObject2;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label lbl_currentFileCount;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dgv_gameobjectGrid;
        private System.Windows.Forms.TextBox txt_state;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_animprogress;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_filterText;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.CheckBox box_ai;
        private System.Windows.Forms.CheckBox box_filename;
        private System.Windows.Forms.ComboBox cmb_typeFilter;
    }
}