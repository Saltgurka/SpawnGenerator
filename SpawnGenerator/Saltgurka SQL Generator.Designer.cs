namespace SpawnGenerator
{
    partial class Saltgurka_SQL_Generator
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
            this.btn_spawnGenerator = new System.Windows.Forms.Button();
            this.btn_poolGenerator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_spawnGenerator
            // 
            this.btn_spawnGenerator.Location = new System.Drawing.Point(29, 94);
            this.btn_spawnGenerator.Name = "btn_spawnGenerator";
            this.btn_spawnGenerator.Size = new System.Drawing.Size(154, 36);
            this.btn_spawnGenerator.TabIndex = 0;
            this.btn_spawnGenerator.Text = "Spawn Generator";
            this.btn_spawnGenerator.UseVisualStyleBackColor = true;
            this.btn_spawnGenerator.Click += new System.EventHandler(this.btn_spawnGenerator_Click);
            // 
            // btn_poolGenerator
            // 
            this.btn_poolGenerator.Location = new System.Drawing.Point(189, 94);
            this.btn_poolGenerator.Name = "btn_poolGenerator";
            this.btn_poolGenerator.Size = new System.Drawing.Size(154, 36);
            this.btn_poolGenerator.TabIndex = 1;
            this.btn_poolGenerator.Text = "Pool Generator";
            this.btn_poolGenerator.UseVisualStyleBackColor = true;
            this.btn_poolGenerator.Click += new System.EventHandler(this.btn_poolGenerator_Click);
            // 
            // Saltgurka_SQL_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 220);
            this.Controls.Add(this.btn_poolGenerator);
            this.Controls.Add(this.btn_spawnGenerator);
            this.Name = "Saltgurka_SQL_Generator";
            this.Text = "Saltgurka_SQL_Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_spawnGenerator;
        private System.Windows.Forms.Button btn_poolGenerator;
    }
}