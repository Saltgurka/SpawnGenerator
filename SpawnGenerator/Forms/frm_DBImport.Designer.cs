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
            this.box_gameobjectsCreateObject2 = new System.Windows.Forms.CheckBox();
            this.rtxt_SQLResult = new System.Windows.Forms.RichTextBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.lbl_currentFileCount = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lbl_affectedRows = new System.Windows.Forms.Label();
            this.lbl_currentFileName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.box_gameobjects = new System.Windows.Forms.CheckBox();
            this.box_creatures = new System.Windows.Forms.CheckBox();
            this.box_creaturesCreateObject2 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_loadSniff
            // 
            this.btn_loadSniff.Location = new System.Drawing.Point(51, 85);
            this.btn_loadSniff.Name = "btn_loadSniff";
            this.btn_loadSniff.Size = new System.Drawing.Size(193, 40);
            this.btn_loadSniff.TabIndex = 2;
            this.btn_loadSniff.Text = "Load Sniff File(s)";
            this.btn_loadSniff.UseVisualStyleBackColor = true;
            this.btn_loadSniff.Click += new System.EventHandler(this.btn_loadSniff_Click);
            // 
            // box_gameobjectsCreateObject2
            // 
            this.box_gameobjectsCreateObject2.AutoSize = true;
            this.box_gameobjectsCreateObject2.Location = new System.Drawing.Point(102, 3);
            this.box_gameobjectsCreateObject2.Name = "box_gameobjectsCreateObject2";
            this.box_gameobjectsCreateObject2.Size = new System.Drawing.Size(118, 17);
            this.box_gameobjectsCreateObject2.TabIndex = 53;
            this.box_gameobjectsCreateObject2.Text = "Only CreateObject2";
            this.box_gameobjectsCreateObject2.UseVisualStyleBackColor = true;
            // 
            // rtxt_SQLResult
            // 
            this.rtxt_SQLResult.Location = new System.Drawing.Point(51, 138);
            this.rtxt_SQLResult.Name = "rtxt_SQLResult";
            this.rtxt_SQLResult.Size = new System.Drawing.Size(291, 233);
            this.rtxt_SQLResult.TabIndex = 54;
            this.rtxt_SQLResult.Text = "";
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
            this.lbl_affectedRows.Location = new System.Drawing.Point(518, 85);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.33962F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.66038F));
            this.tableLayoutPanel1.Controls.Add(this.box_creaturesCreateObject2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.box_creatures, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.box_gameobjects, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.box_gameobjectsCreateObject2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(261, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(224, 53);
            this.tableLayoutPanel1.TabIndex = 65;
            // 
            // box_gameobjects
            // 
            this.box_gameobjects.AutoSize = true;
            this.box_gameobjects.Checked = true;
            this.box_gameobjects.CheckState = System.Windows.Forms.CheckState.Checked;
            this.box_gameobjects.Location = new System.Drawing.Point(3, 3);
            this.box_gameobjects.Name = "box_gameobjects";
            this.box_gameobjects.Size = new System.Drawing.Size(88, 17);
            this.box_gameobjects.TabIndex = 54;
            this.box_gameobjects.Text = "Gameobjects";
            this.box_gameobjects.UseVisualStyleBackColor = true;
            // 
            // box_creatures
            // 
            this.box_creatures.AutoSize = true;
            this.box_creatures.Checked = true;
            this.box_creatures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.box_creatures.Location = new System.Drawing.Point(3, 29);
            this.box_creatures.Name = "box_creatures";
            this.box_creatures.Size = new System.Drawing.Size(71, 17);
            this.box_creatures.TabIndex = 55;
            this.box_creatures.Text = "Creatures";
            this.box_creatures.UseVisualStyleBackColor = true;
            // 
            // box_creaturesCreateObject2
            // 
            this.box_creaturesCreateObject2.AutoSize = true;
            this.box_creaturesCreateObject2.Checked = true;
            this.box_creaturesCreateObject2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.box_creaturesCreateObject2.Location = new System.Drawing.Point(102, 29);
            this.box_creaturesCreateObject2.Name = "box_creaturesCreateObject2";
            this.box_creaturesCreateObject2.Size = new System.Drawing.Size(118, 17);
            this.box_creaturesCreateObject2.TabIndex = 56;
            this.box_creaturesCreateObject2.Text = "Only CreateObject2";
            this.box_creaturesCreateObject2.UseVisualStyleBackColor = true;
            // 
            // frm_DBImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbl_currentFileName);
            this.Controls.Add(this.lbl_affectedRows);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbl_currentFileCount);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.rtxt_SQLResult);
            this.Controls.Add(this.btn_loadSniff);
            this.Name = "frm_DBImport";
            this.Text = "frm_DBImport";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_loadSniff;
        private System.Windows.Forms.CheckBox box_gameobjectsCreateObject2;
        private System.Windows.Forms.RichTextBox rtxt_SQLResult;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label lbl_currentFileCount;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lbl_affectedRows;
        private System.Windows.Forms.Label lbl_currentFileName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox box_creaturesCreateObject2;
        private System.Windows.Forms.CheckBox box_creatures;
        private System.Windows.Forms.CheckBox box_gameobjects;
    }
}