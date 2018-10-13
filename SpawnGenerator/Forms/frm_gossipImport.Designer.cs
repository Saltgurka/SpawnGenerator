namespace SpawnGenerator.Forms
{
    partial class frm_gossipImport
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
            this.rtb_output = new System.Windows.Forms.RichTextBox();
            this.btn_loadSniff = new System.Windows.Forms.Button();
            this.lbl_currentFileCount = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.lbl_rows = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // rtb_output
            // 
            this.rtb_output.Location = new System.Drawing.Point(12, 112);
            this.rtb_output.Name = "rtb_output";
            this.rtb_output.Size = new System.Drawing.Size(510, 326);
            this.rtb_output.TabIndex = 7;
            this.rtb_output.Text = "";
            // 
            // btn_loadSniff
            // 
            this.btn_loadSniff.Location = new System.Drawing.Point(12, 36);
            this.btn_loadSniff.Name = "btn_loadSniff";
            this.btn_loadSniff.Size = new System.Drawing.Size(510, 70);
            this.btn_loadSniff.TabIndex = 8;
            this.btn_loadSniff.Text = "Load Sniff File(s)";
            this.btn_loadSniff.UseVisualStyleBackColor = true;
            this.btn_loadSniff.Click += new System.EventHandler(this.btn_loadSniff_Click);
            // 
            // lbl_currentFileCount
            // 
            this.lbl_currentFileCount.AutoSize = true;
            this.lbl_currentFileCount.Location = new System.Drawing.Point(476, 12);
            this.lbl_currentFileCount.Name = "lbl_currentFileCount";
            this.lbl_currentFileCount.Size = new System.Drawing.Size(43, 13);
            this.lbl_currentFileCount.TabIndex = 57;
            this.lbl_currentFileCount.Text = "File 0/0";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 12);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(406, 18);
            this.progress.TabIndex = 56;
            // 
            // lbl_rows
            // 
            this.lbl_rows.AutoSize = true;
            this.lbl_rows.Location = new System.Drawing.Point(424, 12);
            this.lbl_rows.Name = "lbl_rows";
            this.lbl_rows.Size = new System.Drawing.Size(46, 13);
            this.lbl_rows.TabIndex = 55;
            this.lbl_rows.Text = "Rows: 0";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // frm_gossipImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.lbl_currentFileCount);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.lbl_rows);
            this.Controls.Add(this.btn_loadSniff);
            this.Controls.Add(this.rtb_output);
            this.Name = "frm_gossipImport";
            this.Text = "frm_gossipImport";
            this.Load += new System.EventHandler(this.frm_gossipImport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_output;
        private System.Windows.Forms.Button btn_loadSniff;
        private System.Windows.Forms.Label lbl_currentFileCount;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label lbl_rows;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}