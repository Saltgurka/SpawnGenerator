namespace SpawnGenerator.Forms
{
    partial class frm_chanceCalc
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
            this.btn_true = new System.Windows.Forms.Button();
            this.btn_false = new System.Windows.Forms.Button();
            this.txt_true = new System.Windows.Forms.TextBox();
            this.txt_false = new System.Windows.Forms.TextBox();
            this.lbl_trueChance = new System.Windows.Forms.Label();
            this.lbl_falseChance = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_true
            // 
            this.btn_true.Location = new System.Drawing.Point(12, 58);
            this.btn_true.Name = "btn_true";
            this.btn_true.Size = new System.Drawing.Size(124, 43);
            this.btn_true.TabIndex = 0;
            this.btn_true.Text = "True";
            this.btn_true.UseVisualStyleBackColor = true;
            this.btn_true.Click += new System.EventHandler(this.btn_true_Click);
            // 
            // btn_false
            // 
            this.btn_false.Location = new System.Drawing.Point(142, 58);
            this.btn_false.Name = "btn_false";
            this.btn_false.Size = new System.Drawing.Size(124, 43);
            this.btn_false.TabIndex = 1;
            this.btn_false.Text = "False";
            this.btn_false.UseVisualStyleBackColor = true;
            this.btn_false.Click += new System.EventHandler(this.btn_false_Click);
            // 
            // txt_true
            // 
            this.txt_true.Location = new System.Drawing.Point(12, 32);
            this.txt_true.Name = "txt_true";
            this.txt_true.Size = new System.Drawing.Size(124, 20);
            this.txt_true.TabIndex = 2;
            // 
            // txt_false
            // 
            this.txt_false.Location = new System.Drawing.Point(143, 32);
            this.txt_false.Name = "txt_false";
            this.txt_false.Size = new System.Drawing.Size(123, 20);
            this.txt_false.TabIndex = 3;
            // 
            // lbl_trueChance
            // 
            this.lbl_trueChance.AutoSize = true;
            this.lbl_trueChance.Location = new System.Drawing.Point(12, 13);
            this.lbl_trueChance.Name = "lbl_trueChance";
            this.lbl_trueChance.Size = new System.Drawing.Size(21, 13);
            this.lbl_trueChance.TabIndex = 4;
            this.lbl_trueChance.Text = "0%";
            // 
            // lbl_falseChance
            // 
            this.lbl_falseChance.AutoSize = true;
            this.lbl_falseChance.Location = new System.Drawing.Point(143, 13);
            this.lbl_falseChance.Name = "lbl_falseChance";
            this.lbl_falseChance.Size = new System.Drawing.Size(21, 13);
            this.lbl_falseChance.TabIndex = 5;
            this.lbl_falseChance.Text = "0%";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(12, 107);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(254, 43);
            this.btn_calculate.TabIndex = 6;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // frm_chanceCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 167);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.lbl_falseChance);
            this.Controls.Add(this.lbl_trueChance);
            this.Controls.Add(this.txt_false);
            this.Controls.Add(this.txt_true);
            this.Controls.Add(this.btn_false);
            this.Controls.Add(this.btn_true);
            this.Name = "frm_chanceCalc";
            this.Text = "frm_chanceCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_true;
        private System.Windows.Forms.Button btn_false;
        private System.Windows.Forms.TextBox txt_true;
        private System.Windows.Forms.TextBox txt_false;
        private System.Windows.Forms.Label lbl_trueChance;
        private System.Windows.Forms.Label lbl_falseChance;
        private System.Windows.Forms.Button btn_calculate;
    }
}