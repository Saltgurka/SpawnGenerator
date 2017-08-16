namespace SpawnGenerator
{
    partial class frm_poolGenerator
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
            this.label1241 = new System.Windows.Forms.Label();
            this.rtxt_templateOutput = new System.Windows.Forms.RichTextBox();
            this.btn_generateTemplate = new System.Windows.Forms.Button();
            this.cmb_creatureList = new System.Windows.Forms.ComboBox();
            this.txt_addCreatureToList = new System.Windows.Forms.TextBox();
            this.btn_addCreatureToList = new System.Windows.Forms.Button();
            this.btn_deleteFromCMB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_chance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_endEntryPool = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_startEntryPool = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_poolDescription = new System.Windows.Forms.TextBox();
            this.rtxt_poolOutput = new System.Windows.Forms.RichTextBox();
            this.btn_generatePool = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_guid = new System.Windows.Forms.TextBox();
            this.btn_savePool = new System.Windows.Forms.Button();
            this.box_emptyRows = new System.Windows.Forms.CheckBox();
            this.box_incrDescNum = new System.Windows.Forms.CheckBox();
            this.box_incDescNumTemplate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_startEntry
            // 
            this.txt_startEntry.Location = new System.Drawing.Point(12, 27);
            this.txt_startEntry.Name = "txt_startEntry";
            this.txt_startEntry.Size = new System.Drawing.Size(100, 20);
            this.txt_startEntry.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Entry";
            // 
            // txt_endEntry
            // 
            this.txt_endEntry.Location = new System.Drawing.Point(119, 27);
            this.txt_endEntry.Name = "txt_endEntry";
            this.txt_endEntry.Size = new System.Drawing.Size(100, 20);
            this.txt_endEntry.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Entry";
            // 
            // txt_maxLimit
            // 
            this.txt_maxLimit.Location = new System.Drawing.Point(226, 27);
            this.txt_maxLimit.Name = "txt_maxLimit";
            this.txt_maxLimit.Size = new System.Drawing.Size(100, 20);
            this.txt_maxLimit.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max Limit";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(12, 66);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(314, 20);
            this.txt_description.TabIndex = 6;
            // 
            // label1241
            // 
            this.label1241.AutoSize = true;
            this.label1241.Location = new System.Drawing.Point(9, 50);
            this.label1241.Name = "label1241";
            this.label1241.Size = new System.Drawing.Size(60, 13);
            this.label1241.TabIndex = 7;
            this.label1241.Text = "Description";
            // 
            // rtxt_templateOutput
            // 
            this.rtxt_templateOutput.Location = new System.Drawing.Point(12, 210);
            this.rtxt_templateOutput.Name = "rtxt_templateOutput";
            this.rtxt_templateOutput.Size = new System.Drawing.Size(314, 130);
            this.rtxt_templateOutput.TabIndex = 8;
            this.rtxt_templateOutput.Text = "";
            // 
            // btn_generateTemplate
            // 
            this.btn_generateTemplate.Location = new System.Drawing.Point(12, 135);
            this.btn_generateTemplate.Name = "btn_generateTemplate";
            this.btn_generateTemplate.Size = new System.Drawing.Size(314, 56);
            this.btn_generateTemplate.TabIndex = 9;
            this.btn_generateTemplate.Text = "Generate Template";
            this.btn_generateTemplate.UseVisualStyleBackColor = true;
            this.btn_generateTemplate.Click += new System.EventHandler(this.btn_generateTemplate_Click);
            // 
            // cmb_creatureList
            // 
            this.cmb_creatureList.FormattingEnabled = true;
            this.cmb_creatureList.Location = new System.Drawing.Point(380, 127);
            this.cmb_creatureList.Name = "cmb_creatureList";
            this.cmb_creatureList.Size = new System.Drawing.Size(121, 21);
            this.cmb_creatureList.TabIndex = 10;
            this.cmb_creatureList.SelectedIndexChanged += new System.EventHandler(this.cmb_creatureList_SelectedIndexChanged);
            // 
            // txt_addCreatureToList
            // 
            this.txt_addCreatureToList.Location = new System.Drawing.Point(380, 101);
            this.txt_addCreatureToList.Name = "txt_addCreatureToList";
            this.txt_addCreatureToList.Size = new System.Drawing.Size(121, 20);
            this.txt_addCreatureToList.TabIndex = 11;
            // 
            // btn_addCreatureToList
            // 
            this.btn_addCreatureToList.Location = new System.Drawing.Point(507, 99);
            this.btn_addCreatureToList.Name = "btn_addCreatureToList";
            this.btn_addCreatureToList.Size = new System.Drawing.Size(75, 23);
            this.btn_addCreatureToList.TabIndex = 12;
            this.btn_addCreatureToList.Text = "Add";
            this.btn_addCreatureToList.UseVisualStyleBackColor = true;
            this.btn_addCreatureToList.Click += new System.EventHandler(this.btn_addCreatureToList_Click);
            // 
            // btn_deleteFromCMB
            // 
            this.btn_deleteFromCMB.Location = new System.Drawing.Point(507, 125);
            this.btn_deleteFromCMB.Name = "btn_deleteFromCMB";
            this.btn_deleteFromCMB.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteFromCMB.TabIndex = 17;
            this.btn_deleteFromCMB.Text = "Delete";
            this.btn_deleteFromCMB.UseVisualStyleBackColor = true;
            this.btn_deleteFromCMB.Click += new System.EventHandler(this.btn_deleteFromCMB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Chance";
            // 
            // txt_chance
            // 
            this.txt_chance.Location = new System.Drawing.Point(486, 173);
            this.txt_chance.Name = "txt_chance";
            this.txt_chance.Size = new System.Drawing.Size(100, 20);
            this.txt_chance.TabIndex = 22;
            this.txt_chance.TextChanged += new System.EventHandler(this.txt_chance_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "End Entry";
            // 
            // txt_endEntryPool
            // 
            this.txt_endEntryPool.Location = new System.Drawing.Point(487, 27);
            this.txt_endEntryPool.Name = "txt_endEntryPool";
            this.txt_endEntryPool.Size = new System.Drawing.Size(100, 20);
            this.txt_endEntryPool.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Start Entry";
            // 
            // txt_startEntryPool
            // 
            this.txt_startEntryPool.Location = new System.Drawing.Point(380, 27);
            this.txt_startEntryPool.Name = "txt_startEntryPool";
            this.txt_startEntryPool.Size = new System.Drawing.Size(100, 20);
            this.txt_startEntryPool.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Description";
            // 
            // txt_poolDescription
            // 
            this.txt_poolDescription.Location = new System.Drawing.Point(380, 212);
            this.txt_poolDescription.Name = "txt_poolDescription";
            this.txt_poolDescription.Size = new System.Drawing.Size(314, 20);
            this.txt_poolDescription.TabIndex = 24;
            this.txt_poolDescription.TextChanged += new System.EventHandler(this.txt_poolDescription_TextChanged);
            // 
            // rtxt_poolOutput
            // 
            this.rtxt_poolOutput.Location = new System.Drawing.Point(380, 357);
            this.rtxt_poolOutput.Name = "rtxt_poolOutput";
            this.rtxt_poolOutput.Size = new System.Drawing.Size(314, 130);
            this.rtxt_poolOutput.TabIndex = 27;
            this.rtxt_poolOutput.Text = "";
            // 
            // btn_generatePool
            // 
            this.btn_generatePool.Location = new System.Drawing.Point(380, 284);
            this.btn_generatePool.Name = "btn_generatePool";
            this.btn_generatePool.Size = new System.Drawing.Size(314, 56);
            this.btn_generatePool.TabIndex = 28;
            this.btn_generatePool.Text = "Generate Pool";
            this.btn_generatePool.UseVisualStyleBackColor = true;
            this.btn_generatePool.Click += new System.EventHandler(this.btn_generatePool_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Start GUID";
            // 
            // txt_guid
            // 
            this.txt_guid.Location = new System.Drawing.Point(380, 173);
            this.txt_guid.Name = "txt_guid";
            this.txt_guid.Size = new System.Drawing.Size(100, 20);
            this.txt_guid.TabIndex = 29;
            this.txt_guid.TextChanged += new System.EventHandler(this.txt_guid_TextChanged);
            // 
            // btn_savePool
            // 
            this.btn_savePool.Location = new System.Drawing.Point(593, 173);
            this.btn_savePool.Name = "btn_savePool";
            this.btn_savePool.Size = new System.Drawing.Size(75, 23);
            this.btn_savePool.TabIndex = 31;
            this.btn_savePool.Text = "Save";
            this.btn_savePool.UseVisualStyleBackColor = true;
            this.btn_savePool.Click += new System.EventHandler(this.btn_savePool_Click);
            // 
            // box_emptyRows
            // 
            this.box_emptyRows.AutoSize = true;
            this.box_emptyRows.Location = new System.Drawing.Point(383, 54);
            this.box_emptyRows.Name = "box_emptyRows";
            this.box_emptyRows.Size = new System.Drawing.Size(162, 17);
            this.box_emptyRows.TabIndex = 32;
            this.box_emptyRows.Text = "Empty Row Between Groups";
            this.box_emptyRows.UseVisualStyleBackColor = true;
            // 
            // box_incrDescNum
            // 
            this.box_incrDescNum.AutoSize = true;
            this.box_incrDescNum.Location = new System.Drawing.Point(551, 54);
            this.box_incrDescNum.Name = "box_incrDescNum";
            this.box_incrDescNum.Size = new System.Drawing.Size(183, 17);
            this.box_incrDescNum.TabIndex = 35;
            this.box_incrDescNum.Text = "Incrementing Description Number";
            this.box_incrDescNum.UseVisualStyleBackColor = true;
            // 
            // box_incDescNumTemplate
            // 
            this.box_incDescNumTemplate.AutoSize = true;
            this.box_incDescNumTemplate.Location = new System.Drawing.Point(12, 99);
            this.box_incDescNumTemplate.Name = "box_incDescNumTemplate";
            this.box_incDescNumTemplate.Size = new System.Drawing.Size(183, 17);
            this.box_incDescNumTemplate.TabIndex = 36;
            this.box_incDescNumTemplate.Text = "Incrementing Description Number";
            this.box_incDescNumTemplate.UseVisualStyleBackColor = true;
            // 
            // Pool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 613);
            this.Controls.Add(this.box_incDescNumTemplate);
            this.Controls.Add(this.box_incrDescNum);
            this.Controls.Add(this.box_emptyRows);
            this.Controls.Add(this.btn_savePool);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_guid);
            this.Controls.Add(this.btn_generatePool);
            this.Controls.Add(this.rtxt_poolOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_poolDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_chance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_endEntryPool);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_startEntryPool);
            this.Controls.Add(this.btn_deleteFromCMB);
            this.Controls.Add(this.btn_addCreatureToList);
            this.Controls.Add(this.txt_addCreatureToList);
            this.Controls.Add(this.cmb_creatureList);
            this.Controls.Add(this.btn_generateTemplate);
            this.Controls.Add(this.rtxt_templateOutput);
            this.Controls.Add(this.label1241);
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
        private System.Windows.Forms.Label label1241;
        private System.Windows.Forms.RichTextBox rtxt_templateOutput;
        private System.Windows.Forms.Button btn_generateTemplate;
        private System.Windows.Forms.ComboBox cmb_creatureList;
        private System.Windows.Forms.TextBox txt_addCreatureToList;
        private System.Windows.Forms.Button btn_addCreatureToList;
        private System.Windows.Forms.Button btn_deleteFromCMB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_chance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_endEntryPool;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_startEntryPool;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_poolDescription;
        private System.Windows.Forms.RichTextBox rtxt_poolOutput;
        private System.Windows.Forms.Button btn_generatePool;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_guid;
        private System.Windows.Forms.Button btn_savePool;
        private System.Windows.Forms.CheckBox box_emptyRows;
        private System.Windows.Forms.CheckBox box_incrDescNum;
        private System.Windows.Forms.CheckBox box_incDescNumTemplate;
    }
}