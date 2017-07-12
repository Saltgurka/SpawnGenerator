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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grid)).BeginInit();
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
            this.dgv_grid.Location = new System.Drawing.Point(13, 13);
            this.dgv_grid.Name = "dgv_grid";
            this.dgv_grid.Size = new System.Drawing.Size(951, 568);
            this.dgv_grid.TabIndex = 0;
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
            this.btn_loadSniff.Location = new System.Drawing.Point(986, 66);
            this.btn_loadSniff.Name = "btn_loadSniff";
            this.btn_loadSniff.Size = new System.Drawing.Size(102, 23);
            this.btn_loadSniff.TabIndex = 1;
            this.btn_loadSniff.Text = "Load Sniff File";
            this.btn_loadSniff.UseVisualStyleBackColor = true;
            this.btn_loadSniff.Click += new System.EventHandler(this.btn_loadSniff_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // frm_multiSpawnGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 605);
            this.Controls.Add(this.btn_loadSniff);
            this.Controls.Add(this.dgv_grid);
            this.Name = "frm_multiSpawnGen";
            this.Text = "frm_multiSpawnGen";
            this.Load += new System.EventHandler(this.frm_multiSpawnGen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grid)).EndInit();
            this.ResumeLayout(false);

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
    }
}