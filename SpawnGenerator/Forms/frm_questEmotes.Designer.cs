namespace SpawnGenerator.Forms
{
    partial class frm_questEmotes
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
            this.btn_loadFile = new System.Windows.Forms.Button();
            this.rtb_output = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_loadFile
            // 
            this.btn_loadFile.Location = new System.Drawing.Point(12, 12);
            this.btn_loadFile.Name = "btn_loadFile";
            this.btn_loadFile.Size = new System.Drawing.Size(776, 68);
            this.btn_loadFile.TabIndex = 9;
            this.btn_loadFile.Text = "Load File(s)";
            this.btn_loadFile.UseVisualStyleBackColor = true;
            this.btn_loadFile.Click += new System.EventHandler(this.btn_loadFile_Click);
            // 
            // rtb_output
            // 
            this.rtb_output.Location = new System.Drawing.Point(12, 86);
            this.rtb_output.Name = "rtb_output";
            this.rtb_output.Size = new System.Drawing.Size(776, 352);
            this.rtb_output.TabIndex = 10;
            this.rtb_output.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // frm_questEmotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_output);
            this.Controls.Add(this.btn_loadFile);
            this.Name = "frm_questEmotes";
            this.Text = "frm_questEmotes";
            this.Load += new System.EventHandler(this.frm_questEmotes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_loadFile;
        private System.Windows.Forms.RichTextBox rtb_output;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}