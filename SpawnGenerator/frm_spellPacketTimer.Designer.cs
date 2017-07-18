namespace SpawnGenerator
{
    partial class frm_spellPacketTimer
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_grid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtxt_SQLResult = new System.Windows.Forms.RichTextBox();
            this.btn_loadSniff = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_filter = new System.Windows.Forms.TextBox();
            this.rdb_spellFilter = new System.Windows.Forms.RadioButton();
            this.rdb_casterFilter = new System.Windows.Forms.RadioButton();
            this.rdb_casterEntryFilter = new System.Windows.Forms.RadioButton();
            this.rdb_casterGuidFilter = new System.Windows.Forms.RadioButton();
            this.rdb_targetFilter = new System.Windows.Forms.RadioButton();
            this.rdb_targetEntryFilter = new System.Windows.Forms.RadioButton();
            this.btn_filter = new System.Windows.Forms.Button();
            this.gridColumn_spell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_caster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_casterEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_Guid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_targetEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridColumn_timeDiff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 591);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_grid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(975, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_grid
            // 
            this.dgv_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridColumn_spell,
            this.gridColumn_caster,
            this.gridColumn_casterEntry,
            this.gridColumn_Guid,
            this.gridColumn_target,
            this.gridColumn_targetEntry,
            this.gridColumn_time,
            this.gridColumn_timeDiff});
            this.dgv_grid.Location = new System.Drawing.Point(-4, 0);
            this.dgv_grid.Name = "dgv_grid";
            this.dgv_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_grid.Size = new System.Drawing.Size(979, 569);
            this.dgv_grid.TabIndex = 0;
            this.dgv_grid.DataSourceChanged += new System.EventHandler(this.dgv_grid_DataSourceChanged);
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
            // btn_loadSniff
            // 
            this.btn_loadSniff.Location = new System.Drawing.Point(990, 23);
            this.btn_loadSniff.Name = "btn_loadSniff";
            this.btn_loadSniff.Size = new System.Drawing.Size(117, 23);
            this.btn_loadSniff.TabIndex = 4;
            this.btn_loadSniff.Text = "Load Sniff File";
            this.btn_loadSniff.UseVisualStyleBackColor = true;
            this.btn_loadSniff.Click += new System.EventHandler(this.btn_loadSniff_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_filter);
            this.groupBox1.Controls.Add(this.rdb_targetEntryFilter);
            this.groupBox1.Controls.Add(this.rdb_targetFilter);
            this.groupBox1.Controls.Add(this.rdb_casterGuidFilter);
            this.groupBox1.Controls.Add(this.rdb_casterEntryFilter);
            this.groupBox1.Controls.Add(this.rdb_casterFilter);
            this.groupBox1.Controls.Add(this.rdb_spellFilter);
            this.groupBox1.Controls.Add(this.txt_filter);
            this.groupBox1.Location = new System.Drawing.Point(990, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 224);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtering";
            // 
            // txt_filter
            // 
            this.txt_filter.Location = new System.Drawing.Point(7, 20);
            this.txt_filter.Name = "txt_filter";
            this.txt_filter.Size = new System.Drawing.Size(100, 20);
            this.txt_filter.TabIndex = 0;
            // 
            // rdb_spellFilter
            // 
            this.rdb_spellFilter.AutoSize = true;
            this.rdb_spellFilter.Location = new System.Drawing.Point(7, 47);
            this.rdb_spellFilter.Name = "rdb_spellFilter";
            this.rdb_spellFilter.Size = new System.Drawing.Size(63, 17);
            this.rdb_spellFilter.TabIndex = 1;
            this.rdb_spellFilter.TabStop = true;
            this.rdb_spellFilter.Text = "By Spell";
            this.rdb_spellFilter.UseVisualStyleBackColor = true;
            // 
            // rdb_casterFilter
            // 
            this.rdb_casterFilter.AutoSize = true;
            this.rdb_casterFilter.Location = new System.Drawing.Point(7, 71);
            this.rdb_casterFilter.Name = "rdb_casterFilter";
            this.rdb_casterFilter.Size = new System.Drawing.Size(70, 17);
            this.rdb_casterFilter.TabIndex = 2;
            this.rdb_casterFilter.TabStop = true;
            this.rdb_casterFilter.Text = "By Caster";
            this.rdb_casterFilter.UseVisualStyleBackColor = true;
            // 
            // rdb_casterEntryFilter
            // 
            this.rdb_casterEntryFilter.AutoSize = true;
            this.rdb_casterEntryFilter.Location = new System.Drawing.Point(7, 95);
            this.rdb_casterEntryFilter.Name = "rdb_casterEntryFilter";
            this.rdb_casterEntryFilter.Size = new System.Drawing.Size(94, 17);
            this.rdb_casterEntryFilter.TabIndex = 3;
            this.rdb_casterEntryFilter.TabStop = true;
            this.rdb_casterEntryFilter.Text = "By CasterEntry";
            this.rdb_casterEntryFilter.UseVisualStyleBackColor = true;
            // 
            // rdb_casterGuidFilter
            // 
            this.rdb_casterGuidFilter.AutoSize = true;
            this.rdb_casterGuidFilter.Location = new System.Drawing.Point(7, 119);
            this.rdb_casterGuidFilter.Name = "rdb_casterGuidFilter";
            this.rdb_casterGuidFilter.Size = new System.Drawing.Size(92, 17);
            this.rdb_casterGuidFilter.TabIndex = 4;
            this.rdb_casterGuidFilter.TabStop = true;
            this.rdb_casterGuidFilter.Text = "By CasterGuid";
            this.rdb_casterGuidFilter.UseVisualStyleBackColor = true;
            // 
            // rdb_targetFilter
            // 
            this.rdb_targetFilter.AutoSize = true;
            this.rdb_targetFilter.Location = new System.Drawing.Point(7, 143);
            this.rdb_targetFilter.Name = "rdb_targetFilter";
            this.rdb_targetFilter.Size = new System.Drawing.Size(71, 17);
            this.rdb_targetFilter.TabIndex = 5;
            this.rdb_targetFilter.TabStop = true;
            this.rdb_targetFilter.Text = "By Target";
            this.rdb_targetFilter.UseVisualStyleBackColor = true;
            // 
            // rdb_targetEntryFilter
            // 
            this.rdb_targetEntryFilter.AutoSize = true;
            this.rdb_targetEntryFilter.Location = new System.Drawing.Point(7, 167);
            this.rdb_targetEntryFilter.Name = "rdb_targetEntryFilter";
            this.rdb_targetEntryFilter.Size = new System.Drawing.Size(95, 17);
            this.rdb_targetEntryFilter.TabIndex = 6;
            this.rdb_targetEntryFilter.TabStop = true;
            this.rdb_targetEntryFilter.Text = "By TargetEntry";
            this.rdb_targetEntryFilter.UseVisualStyleBackColor = true;
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(7, 191);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(100, 23);
            this.btn_filter.TabIndex = 7;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // gridColumn_spell
            // 
            this.gridColumn_spell.HeaderText = "Spell";
            this.gridColumn_spell.Name = "gridColumn_spell";
            // 
            // gridColumn_caster
            // 
            this.gridColumn_caster.HeaderText = "Caster";
            this.gridColumn_caster.Name = "gridColumn_caster";
            // 
            // gridColumn_casterEntry
            // 
            this.gridColumn_casterEntry.HeaderText = "CasterEntry";
            this.gridColumn_casterEntry.Name = "gridColumn_casterEntry";
            // 
            // gridColumn_Guid
            // 
            this.gridColumn_Guid.HeaderText = "CasterGuid";
            this.gridColumn_Guid.Name = "gridColumn_Guid";
            // 
            // gridColumn_target
            // 
            this.gridColumn_target.HeaderText = "Target";
            this.gridColumn_target.Name = "gridColumn_target";
            // 
            // gridColumn_targetEntry
            // 
            this.gridColumn_targetEntry.HeaderText = "TargetEntry";
            this.gridColumn_targetEntry.Name = "gridColumn_targetEntry";
            // 
            // gridColumn_time
            // 
            this.gridColumn_time.HeaderText = "Time";
            this.gridColumn_time.Name = "gridColumn_time";
            // 
            // gridColumn_timeDiff
            // 
            this.gridColumn_timeDiff.HeaderText = "TimeDiff";
            this.gridColumn_timeDiff.Name = "gridColumn_timeDiff";
            // 
            // frm_spellPacketTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 635);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_loadSniff);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_spellPacketTimer";
            this.Text = "frm_spellPacketTimer";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_grid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtxt_SQLResult;
        private System.Windows.Forms.Button btn_loadSniff;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.RadioButton rdb_targetEntryFilter;
        private System.Windows.Forms.RadioButton rdb_targetFilter;
        private System.Windows.Forms.RadioButton rdb_casterGuidFilter;
        private System.Windows.Forms.RadioButton rdb_casterEntryFilter;
        private System.Windows.Forms.RadioButton rdb_casterFilter;
        private System.Windows.Forms.RadioButton rdb_spellFilter;
        private System.Windows.Forms.TextBox txt_filter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_spell;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_caster;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_casterEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_Guid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_target;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_targetEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridColumn_timeDiff;
    }
}