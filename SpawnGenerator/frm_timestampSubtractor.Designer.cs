namespace SpawnGenerator
{
    partial class frm_timestampSubtractor
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
            this.rdb_diffAsSeconds = new System.Windows.Forms.RadioButton();
            this.rdb_diffAsMilliseconds = new System.Windows.Forms.RadioButton();
            this.lbl_lastChanged1 = new System.Windows.Forms.Label();
            this.lbl_lastChanged2 = new System.Windows.Forms.Label();
            this.box_wipe = new System.Windows.Forms.CheckBox();
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
            this.txt_difference.Location = new System.Drawing.Point(83, 84);
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
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Difference (s)";
            // 
            // rdb_diffAsSeconds
            // 
            this.rdb_diffAsSeconds.AutoSize = true;
            this.rdb_diffAsSeconds.Checked = true;
            this.rdb_diffAsSeconds.Location = new System.Drawing.Point(83, 60);
            this.rdb_diffAsSeconds.Name = "rdb_diffAsSeconds";
            this.rdb_diffAsSeconds.Size = new System.Drawing.Size(67, 17);
            this.rdb_diffAsSeconds.TabIndex = 7;
            this.rdb_diffAsSeconds.TabStop = true;
            this.rdb_diffAsSeconds.Text = "Seconds";
            this.rdb_diffAsSeconds.UseVisualStyleBackColor = true;
            this.rdb_diffAsSeconds.CheckedChanged += new System.EventHandler(this.rdb_diffAsSeconds_CheckedChanged);
            // 
            // rdb_diffAsMilliseconds
            // 
            this.rdb_diffAsMilliseconds.AutoSize = true;
            this.rdb_diffAsMilliseconds.Location = new System.Drawing.Point(175, 60);
            this.rdb_diffAsMilliseconds.Name = "rdb_diffAsMilliseconds";
            this.rdb_diffAsMilliseconds.Size = new System.Drawing.Size(82, 17);
            this.rdb_diffAsMilliseconds.TabIndex = 8;
            this.rdb_diffAsMilliseconds.Text = "Milliseconds";
            this.rdb_diffAsMilliseconds.UseVisualStyleBackColor = true;
            this.rdb_diffAsMilliseconds.CheckedChanged += new System.EventHandler(this.rdb_diffAsMilliseconds_CheckedChanged);
            // 
            // lbl_lastChanged1
            // 
            this.lbl_lastChanged1.AutoSize = true;
            this.lbl_lastChanged1.Location = new System.Drawing.Point(273, 11);
            this.lbl_lastChanged1.Name = "lbl_lastChanged1";
            this.lbl_lastChanged1.Size = new System.Drawing.Size(0, 13);
            this.lbl_lastChanged1.TabIndex = 9;
            // 
            // lbl_lastChanged2
            // 
            this.lbl_lastChanged2.AutoSize = true;
            this.lbl_lastChanged2.Location = new System.Drawing.Point(273, 34);
            this.lbl_lastChanged2.Name = "lbl_lastChanged2";
            this.lbl_lastChanged2.Size = new System.Drawing.Size(0, 13);
            this.lbl_lastChanged2.TabIndex = 10;
            // 
            // box_wipe
            // 
            this.box_wipe.AutoSize = true;
            this.box_wipe.Checked = true;
            this.box_wipe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.box_wipe.Location = new System.Drawing.Point(263, 60);
            this.box_wipe.Name = "box_wipe";
            this.box_wipe.Size = new System.Drawing.Size(92, 17);
            this.box_wipe.TabIndex = 11;
            this.box_wipe.Text = "Wipe on Click";
            this.box_wipe.UseVisualStyleBackColor = true;
            // 
            // Timestamp_Subtractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 119);
            this.Controls.Add(this.box_wipe);
            this.Controls.Add(this.lbl_lastChanged2);
            this.Controls.Add(this.lbl_lastChanged1);
            this.Controls.Add(this.rdb_diffAsMilliseconds);
            this.Controls.Add(this.rdb_diffAsSeconds);
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
        private System.Windows.Forms.RadioButton rdb_diffAsSeconds;
        private System.Windows.Forms.RadioButton rdb_diffAsMilliseconds;
        private System.Windows.Forms.Label lbl_lastChanged1;
        private System.Windows.Forms.Label lbl_lastChanged2;
        private System.Windows.Forms.CheckBox box_wipe;
    }
}