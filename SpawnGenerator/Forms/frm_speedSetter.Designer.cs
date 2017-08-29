namespace SpawnGenerator.Forms
{
    partial class frm_speedSetter
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
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldSpeedWalk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldSpeedRun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sniffedSpeedWalk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sniffedSpeedRun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_loadSniff = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lbl_rows = new System.Windows.Forms.Label();
            this.btn_generateSQL = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtxt_output = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_grid
            // 
            this.dgv_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.entry,
            this.oldSpeedWalk,
            this.oldSpeedRun,
            this.sniffedSpeedWalk,
            this.sniffedSpeedRun});
            this.dgv_grid.Location = new System.Drawing.Point(0, 0);
            this.dgv_grid.Name = "dgv_grid";
            this.dgv_grid.Size = new System.Drawing.Size(1094, 395);
            this.dgv_grid.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // entry
            // 
            this.entry.HeaderText = "Entry";
            this.entry.Name = "entry";
            // 
            // oldSpeedWalk
            // 
            this.oldSpeedWalk.HeaderText = "OldSpeedWalk";
            this.oldSpeedWalk.Name = "oldSpeedWalk";
            // 
            // oldSpeedRun
            // 
            this.oldSpeedRun.HeaderText = "OldSpeedRun";
            this.oldSpeedRun.Name = "oldSpeedRun";
            // 
            // sniffedSpeedWalk
            // 
            this.sniffedSpeedWalk.HeaderText = "SniffedSpeedWalk";
            this.sniffedSpeedWalk.Name = "sniffedSpeedWalk";
            // 
            // sniffedSpeedRun
            // 
            this.sniffedSpeedRun.HeaderText = "SniffedSpeedRun";
            this.sniffedSpeedRun.Name = "sniffedSpeedRun";
            // 
            // btn_loadSniff
            // 
            this.btn_loadSniff.Location = new System.Drawing.Point(31, 467);
            this.btn_loadSniff.Name = "btn_loadSniff";
            this.btn_loadSniff.Size = new System.Drawing.Size(75, 23);
            this.btn_loadSniff.TabIndex = 1;
            this.btn_loadSniff.Text = "Load Sniff(s)";
            this.btn_loadSniff.UseVisualStyleBackColor = true;
            this.btn_loadSniff.Click += new System.EventHandler(this.btn_loadSniff_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // lbl_rows
            // 
            this.lbl_rows.AutoSize = true;
            this.lbl_rows.Location = new System.Drawing.Point(12, 436);
            this.lbl_rows.Name = "lbl_rows";
            this.lbl_rows.Size = new System.Drawing.Size(46, 13);
            this.lbl_rows.TabIndex = 2;
            this.lbl_rows.Text = "Rows: 0";
            // 
            // btn_generateSQL
            // 
            this.btn_generateSQL.Location = new System.Drawing.Point(112, 467);
            this.btn_generateSQL.Name = "btn_generateSQL";
            this.btn_generateSQL.Size = new System.Drawing.Size(92, 23);
            this.btn_generateSQL.TabIndex = 3;
            this.btn_generateSQL.Text = "Generate SQL";
            this.btn_generateSQL.UseVisualStyleBackColor = true;
            this.btn_generateSQL.Click += new System.EventHandler(this.btn_generateSQL_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1098, 421);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtxt_output);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1090, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_grid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1090, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtxt_output
            // 
            this.rtxt_output.Location = new System.Drawing.Point(0, 0);
            this.rtxt_output.Name = "rtxt_output";
            this.rtxt_output.Size = new System.Drawing.Size(1090, 395);
            this.rtxt_output.TabIndex = 0;
            this.rtxt_output.Text = "";
            // 
            // frm_speedSetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 527);
            this.Controls.Add(this.btn_generateSQL);
            this.Controls.Add(this.lbl_rows);
            this.Controls.Add(this.btn_loadSniff);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_speedSetter";
            this.Text = "SpeedSetter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_speedSetter_FormClosing);
            this.Load += new System.EventHandler(this.SpeedSetter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_grid;
        private System.Windows.Forms.Button btn_loadSniff;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn entry;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldSpeedWalk;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldSpeedRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn sniffedSpeedWalk;
        private System.Windows.Forms.DataGridViewTextBoxColumn sniffedSpeedRun;
        private System.Windows.Forms.Label lbl_rows;
        private System.Windows.Forms.Button btn_generateSQL;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox rtxt_output;
    }
}