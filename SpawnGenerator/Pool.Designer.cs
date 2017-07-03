namespace SpawnGenerator
{
    partial class Pool
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
            this.txt_startEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_endEntry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maxLimit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.rtxt_templateOutput = new System.Windows.Forms.RichTextBox();
            this.btn_generateTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_startEntry
            // 
            this.txt_startEntry.Location = new System.Drawing.Point(557, 75);
            this.txt_startEntry.Name = "txt_startEntry";
            this.txt_startEntry.Size = new System.Drawing.Size(100, 20);
            this.txt_startEntry.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Entry";
            // 
            // txt_endEntry
            // 
            this.txt_endEntry.Location = new System.Drawing.Point(664, 75);
            this.txt_endEntry.Name = "txt_endEntry";
            this.txt_endEntry.Size = new System.Drawing.Size(100, 20);
            this.txt_endEntry.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Entry";
            // 
            // txt_maxLimit
            // 
            this.txt_maxLimit.Location = new System.Drawing.Point(771, 75);
            this.txt_maxLimit.Name = "txt_maxLimit";
            this.txt_maxLimit.Size = new System.Drawing.Size(100, 20);
            this.txt_maxLimit.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(771, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max Limit";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(557, 114);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(314, 20);
            this.txt_description.TabIndex = 6;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(554, 98);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(60, 13);
            this.Description.TabIndex = 7;
            this.Description.Text = "Description";
            // 
            // rtxt_templateOutput
            // 
            this.rtxt_templateOutput.Location = new System.Drawing.Point(557, 231);
            this.rtxt_templateOutput.Name = "rtxt_templateOutput";
            this.rtxt_templateOutput.Size = new System.Drawing.Size(314, 130);
            this.rtxt_templateOutput.TabIndex = 8;
            this.rtxt_templateOutput.Text = "";
            // 
            // btn_generateTemplate
            // 
            this.btn_generateTemplate.Location = new System.Drawing.Point(557, 156);
            this.btn_generateTemplate.Name = "btn_generateTemplate";
            this.btn_generateTemplate.Size = new System.Drawing.Size(314, 56);
            this.btn_generateTemplate.TabIndex = 9;
            this.btn_generateTemplate.Text = "Generate Template";
            this.btn_generateTemplate.UseVisualStyleBackColor = true;
            this.btn_generateTemplate.Click += new System.EventHandler(this.btn_generateTemplate_Click);
            // 
            // Pool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 613);
            this.Controls.Add(this.btn_generateTemplate);
            this.Controls.Add(this.rtxt_templateOutput);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_maxLimit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_endEntry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_startEntry);
            this.Name = "Pool";
            this.Text = "Pool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_startEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_endEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maxLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.RichTextBox rtxt_templateOutput;
        private System.Windows.Forms.Button btn_generateTemplate;
    }
}