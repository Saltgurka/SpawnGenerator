namespace SpawnGenerator.Forms
{
    partial class frm_DBImport
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
            this.btn_loadSniff = new System.Windows.Forms.Button();
            this.box_createObject2 = new System.Windows.Forms.CheckBox();
            this.rtxt_SQLResult = new System.Windows.Forms.RichTextBox();
            this.cmb_typeFilter = new System.Windows.Forms.ComboBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.lbl_currentFileCount = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lbl_affectedRows = new System.Windows.Forms.Label();
            this.lbl_currentFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_loadSniff
            // 
            this.btn_loadSniff.Location = new System.Drawing.Point(51, 85);
            this.btn_loadSniff.Name = "btn_loadSniff";
            this.btn_loadSniff.Size = new System.Drawing.Size(117, 23);
            this.btn_loadSniff.TabIndex = 2;
            this.btn_loadSniff.Text = "Load Sniff File(s)";
            this.btn_loadSniff.UseVisualStyleBackColor = true;
            this.btn_loadSniff.Click += new System.EventHandler(this.btn_loadSniff_Click);
            // 
            // box_createObject2
            // 
            this.box_createObject2.AutoSize = true;
            this.box_createObject2.Location = new System.Drawing.Point(224, 85);
            this.box_createObject2.Name = "box_createObject2";
            this.box_createObject2.Size = new System.Drawing.Size(118, 17);
            this.box_createObject2.TabIndex = 53;
            this.box_createObject2.Text = "Only CreateObject2";
            this.box_createObject2.UseVisualStyleBackColor = true;
            // 
            // rtxt_SQLResult
            // 
            this.rtxt_SQLResult.Location = new System.Drawing.Point(51, 138);
            this.rtxt_SQLResult.Name = "rtxt_SQLResult";
            this.rtxt_SQLResult.Size = new System.Drawing.Size(291, 233);
            this.rtxt_SQLResult.TabIndex = 54;
            this.rtxt_SQLResult.Text = "";
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
            this.cmb_typeFilter.Location = new System.Drawing.Point(370, 81);
            this.cmb_typeFilter.Name = "cmb_typeFilter";
            this.cmb_typeFilter.Size = new System.Drawing.Size(121, 21);
            this.cmb_typeFilter.TabIndex = 58;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(8, 12);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(780, 18);
            this.progress.TabIndex = 59;
            // 
            // lbl_currentFileCount
            // 
            this.lbl_currentFileCount.AutoSize = true;
            this.lbl_currentFileCount.Location = new System.Drawing.Point(367, 33);
            this.lbl_currentFileCount.Name = "lbl_currentFileCount";
            this.lbl_currentFileCount.Size = new System.Drawing.Size(43, 13);
            this.lbl_currentFileCount.TabIndex = 60;
            this.lbl_currentFileCount.Text = "File 0/0";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(382, 138);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(291, 233);
            this.richTextBox1.TabIndex = 61;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // lbl_affectedRows
            // 
            this.lbl_affectedRows.AutoSize = true;
            this.lbl_affectedRows.Location = new System.Drawing.Point(519, 81);
            this.lbl_affectedRows.Name = "lbl_affectedRows";
            this.lbl_affectedRows.Size = new System.Drawing.Size(83, 13);
            this.lbl_affectedRows.TabIndex = 62;
            this.lbl_affectedRows.Text = "Affected Rows: ";
            // 
            // lbl_currentFileName
            // 
            this.lbl_currentFileName.AutoSize = true;
            this.lbl_currentFileName.Location = new System.Drawing.Point(70, 55);
            this.lbl_currentFileName.Name = "lbl_currentFileName";
            this.lbl_currentFileName.Size = new System.Drawing.Size(0, 13);
            this.lbl_currentFileName.TabIndex = 63;
            // 
            // frm_DBImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_currentFileName);
            this.Controls.Add(this.lbl_affectedRows);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbl_currentFileCount);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.cmb_typeFilter);
            this.Controls.Add(this.rtxt_SQLResult);
            this.Controls.Add(this.box_createObject2);
            this.Controls.Add(this.btn_loadSniff);
            this.Name = "frm_DBImport";
            this.Text = "frm_DBImport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_loadSniff;
        private System.Windows.Forms.CheckBox box_createObject2;
        private System.Windows.Forms.RichTextBox rtxt_SQLResult;
        private System.Windows.Forms.ComboBox cmb_typeFilter;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label lbl_currentFileCount;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lbl_affectedRows;
        private System.Windows.Forms.Label lbl_currentFileName;
    }
}