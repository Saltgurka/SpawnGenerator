namespace SpawnGenerator
{
    partial class Timestamp_Subtractor
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
            this.txt_timestamp1 = new System.Windows.Forms.TextBox();
            this.txt_timestamp2 = new System.Windows.Forms.TextBox();
            this.txt_difference = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_timestamp1
            // 
            this.txt_timestamp1.Location = new System.Drawing.Point(83, 11);
            this.txt_timestamp1.Name = "txt_timestamp1";
            this.txt_timestamp1.Size = new System.Drawing.Size(183, 20);
            this.txt_timestamp1.TabIndex = 0;
            this.txt_timestamp1.Click += new System.EventHandler(this.txt_timestamp1_Click);
            this.txt_timestamp1.TextChanged += new System.EventHandler(this.txt_timestamp1_TextChanged);
            // 
            // txt_timestamp2
            // 
            this.txt_timestamp2.Location = new System.Drawing.Point(83, 34);
            this.txt_timestamp2.Name = "txt_timestamp2";
            this.txt_timestamp2.Size = new System.Drawing.Size(183, 20);
            this.txt_timestamp2.TabIndex = 1;
            this.txt_timestamp2.Click += new System.EventHandler(this.txt_timestamp2_Click);
            this.txt_timestamp2.TextChanged += new System.EventHandler(this.txt_timestamp2_TextChanged);
            // 
            // txt_difference
            // 
            this.txt_difference.Location = new System.Drawing.Point(83, 57);
            this.txt_difference.Name = "txt_difference";
            this.txt_difference.Size = new System.Drawing.Size(183, 20);
            this.txt_difference.TabIndex = 3;
            this.txt_difference.TextChanged += new System.EventHandler(this.txt_difference_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Timestamp 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Timestamp 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Difference (s)";
            // 
            // Timestamp_Subtractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 89);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_difference);
            this.Controls.Add(this.txt_timestamp2);
            this.Controls.Add(this.txt_timestamp1);
            this.Name = "Timestamp_Subtractor";
            this.Text = "Timestamp_Subtractor";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_timestamp1;
        private System.Windows.Forms.TextBox txt_timestamp2;
        private System.Windows.Forms.TextBox txt_difference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}