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
            this.cmb_loginDatabases = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_loginUser = new System.Windows.Forms.TextBox();
            this.txt_loginPassword = new System.Windows.Forms.TextBox();
            this.txt_loginHost = new System.Windows.Forms.TextBox();
            this.txt_loginPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_loginDatabases = new System.Windows.Forms.TextBox();
            this.btn_loginAddDatabase = new System.Windows.Forms.Button();
            this.btn_loginRemoveDatabase = new System.Windows.Forms.Button();
            this.btn_loginSaveAndTest = new System.Windows.Forms.Button();
            this.btn_openTimestampSubtractor = new System.Windows.Forms.Button();
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
            // cmb_loginDatabases
            // 
            this.cmb_loginDatabases.FormattingEnabled = true;
            this.cmb_loginDatabases.Location = new System.Drawing.Point(549, 170);
            this.cmb_loginDatabases.Name = "cmb_loginDatabases";
            this.cmb_loginDatabases.Size = new System.Drawing.Size(121, 21);
            this.cmb_loginDatabases.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DB Login (Optional, passwords are not encrypted)";
            // 
            // txt_loginUser
            // 
            this.txt_loginUser.Location = new System.Drawing.Point(549, 40);
            this.txt_loginUser.Name = "txt_loginUser";
            this.txt_loginUser.Size = new System.Drawing.Size(121, 20);
            this.txt_loginUser.TabIndex = 4;
            // 
            // txt_loginPassword
            // 
            this.txt_loginPassword.Location = new System.Drawing.Point(549, 66);
            this.txt_loginPassword.Name = "txt_loginPassword";
            this.txt_loginPassword.Size = new System.Drawing.Size(121, 20);
            this.txt_loginPassword.TabIndex = 5;
            // 
            // txt_loginHost
            // 
            this.txt_loginHost.Location = new System.Drawing.Point(549, 92);
            this.txt_loginHost.Name = "txt_loginHost";
            this.txt_loginHost.Size = new System.Drawing.Size(121, 20);
            this.txt_loginHost.TabIndex = 6;
            // 
            // txt_loginPort
            // 
            this.txt_loginPort.Location = new System.Drawing.Point(549, 118);
            this.txt_loginPort.Name = "txt_loginPort";
            this.txt_loginPort.Size = new System.Drawing.Size(121, 20);
            this.txt_loginPort.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Host:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Databases:";
            // 
            // txt_loginDatabases
            // 
            this.txt_loginDatabases.Location = new System.Drawing.Point(549, 144);
            this.txt_loginDatabases.Name = "txt_loginDatabases";
            this.txt_loginDatabases.Size = new System.Drawing.Size(121, 20);
            this.txt_loginDatabases.TabIndex = 8;
            // 
            // btn_loginAddDatabase
            // 
            this.btn_loginAddDatabase.Location = new System.Drawing.Point(676, 144);
            this.btn_loginAddDatabase.Name = "btn_loginAddDatabase";
            this.btn_loginAddDatabase.Size = new System.Drawing.Size(75, 23);
            this.btn_loginAddDatabase.TabIndex = 14;
            this.btn_loginAddDatabase.Text = "Add";
            this.btn_loginAddDatabase.UseVisualStyleBackColor = true;
            // 
            // btn_loginRemoveDatabase
            // 
            this.btn_loginRemoveDatabase.Location = new System.Drawing.Point(676, 170);
            this.btn_loginRemoveDatabase.Name = "btn_loginRemoveDatabase";
            this.btn_loginRemoveDatabase.Size = new System.Drawing.Size(75, 23);
            this.btn_loginRemoveDatabase.TabIndex = 15;
            this.btn_loginRemoveDatabase.Text = "Remove";
            this.btn_loginRemoveDatabase.UseVisualStyleBackColor = true;
            // 
            // btn_loginSaveAndTest
            // 
            this.btn_loginSaveAndTest.Location = new System.Drawing.Point(490, 212);
            this.btn_loginSaveAndTest.Name = "btn_loginSaveAndTest";
            this.btn_loginSaveAndTest.Size = new System.Drawing.Size(261, 31);
            this.btn_loginSaveAndTest.TabIndex = 16;
            this.btn_loginSaveAndTest.Text = "Save and Test Connection";
            this.btn_loginSaveAndTest.UseVisualStyleBackColor = true;
            // 
            // btn_openTimestampSubtractor
            // 
            this.btn_openTimestampSubtractor.Location = new System.Drawing.Point(29, 137);
            this.btn_openTimestampSubtractor.Name = "btn_openTimestampSubtractor";
            this.btn_openTimestampSubtractor.Size = new System.Drawing.Size(154, 36);
            this.btn_openTimestampSubtractor.TabIndex = 17;
            this.btn_openTimestampSubtractor.Text = "Timestamp Subtractor";
            this.btn_openTimestampSubtractor.UseVisualStyleBackColor = true;
            this.btn_openTimestampSubtractor.Click += new System.EventHandler(this.btn_openTimestampSubtractor_Click);
            // 
            // Saltgurka_SQL_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 255);
            this.Controls.Add(this.btn_openTimestampSubtractor);
            this.Controls.Add(this.btn_loginSaveAndTest);
            this.Controls.Add(this.btn_loginRemoveDatabase);
            this.Controls.Add(this.btn_loginAddDatabase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_loginDatabases);
            this.Controls.Add(this.txt_loginPort);
            this.Controls.Add(this.txt_loginHost);
            this.Controls.Add(this.txt_loginPassword);
            this.Controls.Add(this.txt_loginUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_loginDatabases);
            this.Controls.Add(this.btn_poolGenerator);
            this.Controls.Add(this.btn_spawnGenerator);
            this.Name = "Saltgurka_SQL_Generator";
            this.Text = "Saltgurka_SQL_Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_spawnGenerator;
        private System.Windows.Forms.Button btn_poolGenerator;
        private System.Windows.Forms.ComboBox cmb_loginDatabases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_loginUser;
        private System.Windows.Forms.TextBox txt_loginPassword;
        private System.Windows.Forms.TextBox txt_loginHost;
        private System.Windows.Forms.TextBox txt_loginPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_loginDatabases;
        private System.Windows.Forms.Button btn_loginAddDatabase;
        private System.Windows.Forms.Button btn_loginRemoveDatabase;
        private System.Windows.Forms.Button btn_loginSaveAndTest;
        private System.Windows.Forms.Button btn_openTimestampSubtractor;
    }
}