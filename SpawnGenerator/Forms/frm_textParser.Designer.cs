namespace SpawnGenerator.Forms
{
    partial class frm_textParser
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
            this.btn_filter = new System.Windows.Forms.Button();
            this.txt_filterText = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lbl_currentFileCount = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_grid
            // 
            this.dgv_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_grid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_grid.Location = new System.Drawing.Point(12, 41);
            this.dgv_grid.Name = "dgv_grid";
            this.dgv_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_grid.Size = new System.Drawing.Size(982, 540);
            this.dgv_grid.TabIndex = 1;
            // 
            // btn_loadSniff
            // 
            this.btn_loadSniff.Location = new System.Drawing.Point(1000, 12);
            this.btn_loadSniff.Name = "btn_loadSniff";
            this.btn_loadSniff.Size = new System.Drawing.Size(117, 23);
            this.btn_loadSniff.TabIndex = 2;
            this.btn_loadSniff.Text = "Load Sniff File(s)";
            this.btn_loadSniff.UseVisualStyleBackColor = true;
            this.btn_loadSniff.Click += new System.EventHandler(this.btn_loadSniff_Click);
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(1123, 39);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(119, 23);
            this.btn_filter.TabIndex = 58;
            this.btn_filter.Text = "Filter By Entry";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // txt_filterText
            // 
            this.txt_filterText.Location = new System.Drawing.Point(1000, 41);
            this.txt_filterText.Name = "txt_filterText";
            this.txt_filterText.Size = new System.Drawing.Size(117, 20);
            this.txt_filterText.TabIndex = 57;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // lbl_currentFileCount
            // 
            this.lbl_currentFileCount.AutoSize = true;
            this.lbl_currentFileCount.Location = new System.Drawing.Point(951, 12);
            this.lbl_currentFileCount.Name = "lbl_currentFileCount";
            this.lbl_currentFileCount.Size = new System.Drawing.Size(43, 13);
            this.lbl_currentFileCount.TabIndex = 60;
            this.lbl_currentFileCount.Text = "File 0/0";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 12);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(933, 18);
            this.progress.TabIndex = 59;
            // 
            // frm_textParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 596);
            this.Controls.Add(this.lbl_currentFileCount);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.txt_filterText);
            this.Controls.Add(this.btn_loadSniff);
            this.Controls.Add(this.dgv_grid);
            this.Name = "frm_textParser";
            this.Text = "frm_textParser";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_grid;
        private System.Windows.Forms.Button btn_loadSniff;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.TextBox txt_filterText;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lbl_currentFileCount;
        private System.Windows.Forms.ProgressBar progress;
    }
}