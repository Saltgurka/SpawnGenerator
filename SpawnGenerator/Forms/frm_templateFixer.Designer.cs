namespace SpawnGenerator.Forms
{
    partial class frm_templateFixer
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
            this.btn_generate = new System.Windows.Forms.Button();
            this.rtb_output = new System.Windows.Forms.RichTextBox();
            this.rtb_input = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(12, 270);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(776, 46);
            this.btn_generate.TabIndex = 7;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // rtb_output
            // 
            this.rtb_output.Location = new System.Drawing.Point(12, 322);
            this.rtb_output.Name = "rtb_output";
            this.rtb_output.Size = new System.Drawing.Size(776, 116);
            this.rtb_output.TabIndex = 6;
            this.rtb_output.Text = "";
            // 
            // rtb_input
            // 
            this.rtb_input.Location = new System.Drawing.Point(12, 12);
            this.rtb_input.Name = "rtb_input";
            this.rtb_input.Size = new System.Drawing.Size(776, 252);
            this.rtb_input.TabIndex = 5;
            this.rtb_input.Text = "";
            // 
            // frm_templateFixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.rtb_output);
            this.Controls.Add(this.rtb_input);
            this.Name = "frm_templateFixer";
            this.Text = "frm_templateFixer";
            this.Load += new System.EventHandler(this.frm_templateFixer_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.RichTextBox rtb_output;
        private System.Windows.Forms.RichTextBox rtb_input;
    }
}