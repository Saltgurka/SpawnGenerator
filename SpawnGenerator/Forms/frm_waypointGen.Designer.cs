namespace SpawnGenerator.Forms
{
    partial class frm_waypointGen
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
            this.rtb_input = new System.Windows.Forms.RichTextBox();
            this.rtb_output = new System.Windows.Forms.RichTextBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.txt_entry = new System.Windows.Forms.TextBox();
            this.txt_pathId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtb_input
            // 
            this.rtb_input.Location = new System.Drawing.Point(13, 13);
            this.rtb_input.Name = "rtb_input";
            this.rtb_input.Size = new System.Drawing.Size(259, 116);
            this.rtb_input.TabIndex = 0;
            this.rtb_input.Text = "";
            // 
            // rtb_output
            // 
            this.rtb_output.Location = new System.Drawing.Point(13, 265);
            this.rtb_output.Name = "rtb_output";
            this.rtb_output.Size = new System.Drawing.Size(259, 116);
            this.rtb_output.TabIndex = 1;
            this.rtb_output.Text = "";
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(13, 213);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(259, 46);
            this.btn_generate.TabIndex = 2;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // txt_entry
            // 
            this.txt_entry.Location = new System.Drawing.Point(13, 136);
            this.txt_entry.Name = "txt_entry";
            this.txt_entry.Size = new System.Drawing.Size(259, 20);
            this.txt_entry.TabIndex = 3;
            this.txt_entry.Text = "Entry";
            this.txt_entry.Click += new System.EventHandler(this.txt_entry_Click);
            // 
            // txt_pathId
            // 
            this.txt_pathId.Location = new System.Drawing.Point(13, 163);
            this.txt_pathId.Name = "txt_pathId";
            this.txt_pathId.Size = new System.Drawing.Size(259, 20);
            this.txt_pathId.TabIndex = 4;
            this.txt_pathId.Text = "PathId";
            this.txt_pathId.Click += new System.EventHandler(this.txt_pathId_Click);
            // 
            // frm_waypointGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 393);
            this.Controls.Add(this.txt_pathId);
            this.Controls.Add(this.txt_entry);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.rtb_output);
            this.Controls.Add(this.rtb_input);
            this.Name = "frm_waypointGen";
            this.Text = "frm_waypointGen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_input;
        private System.Windows.Forms.RichTextBox rtb_output;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.TextBox txt_entry;
        private System.Windows.Forms.TextBox txt_pathId;
    }
}