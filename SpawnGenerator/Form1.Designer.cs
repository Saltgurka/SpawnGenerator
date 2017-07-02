namespace SpawnGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_creatureEntry = new System.Windows.Forms.TextBox();
            this.txt_creatureGUID = new System.Windows.Forms.TextBox();
            this.txt_positionString = new System.Windows.Forms.TextBox();
            this.txt_orientation = new System.Windows.Forms.TextBox();
            this.txt_map = new System.Windows.Forms.TextBox();
            this.txt_spawnMask = new System.Windows.Forms.TextBox();
            this.txt_modelid = new System.Windows.Forms.TextBox();
            this.txt_equipmentId = new System.Windows.Forms.TextBox();
            this.txt_spawnMin = new System.Windows.Forms.TextBox();
            this.txt_spawnMax = new System.Windows.Forms.TextBox();
            this.txt_curhealth = new System.Windows.Forms.TextBox();
            this.txt_curmana = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_currentWaypoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_deathState = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_movementType = new System.Windows.Forms.TextBox();
            this.txt_spawndist = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt_creatureEntry
            // 
            this.txt_creatureEntry.Location = new System.Drawing.Point(214, 13);
            this.txt_creatureEntry.Name = "txt_creatureEntry";
            this.txt_creatureEntry.Size = new System.Drawing.Size(100, 20);
            this.txt_creatureEntry.TabIndex = 0;
            this.txt_creatureEntry.Text = "Creature Entry";
            this.txt_creatureEntry.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_creatureEntry_MouseClick);
            this.txt_creatureEntry.TextChanged += new System.EventHandler(this.txt_creatureEntry_TextChanged);
            // 
            // txt_creatureGUID
            // 
            this.txt_creatureGUID.Location = new System.Drawing.Point(108, 13);
            this.txt_creatureGUID.Name = "txt_creatureGUID";
            this.txt_creatureGUID.Size = new System.Drawing.Size(100, 20);
            this.txt_creatureGUID.TabIndex = 1;
            this.txt_creatureGUID.Text = "Creature GUID";
            this.txt_creatureGUID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_creatureGUID_MouseClick);
            this.txt_creatureGUID.TextChanged += new System.EventHandler(this.txt_creatureGUID_TextChanged);
            // 
            // txt_positionString
            // 
            this.txt_positionString.Location = new System.Drawing.Point(108, 52);
            this.txt_positionString.Name = "txt_positionString";
            this.txt_positionString.Size = new System.Drawing.Size(293, 20);
            this.txt_positionString.TabIndex = 2;
            this.txt_positionString.Text = "[0] Position: X: XXX.XXX Y: XXX.XXX Z: XXX.XXX";
            this.txt_positionString.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_positionString_MouseClick);
            this.txt_positionString.TextChanged += new System.EventHandler(this.txt_positionString_TextChanged);
            // 
            // txt_orientation
            // 
            this.txt_orientation.Location = new System.Drawing.Point(407, 52);
            this.txt_orientation.Name = "txt_orientation";
            this.txt_orientation.Size = new System.Drawing.Size(128, 20);
            this.txt_orientation.TabIndex = 3;
            this.txt_orientation.Text = "[0] Orientation: X.XXXX";
            this.txt_orientation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_orientation_MouseClick);
            this.txt_orientation.TextChanged += new System.EventHandler(this.txt_orientation_TextChanged);
            // 
            // txt_map
            // 
            this.txt_map.Location = new System.Drawing.Point(234, 104);
            this.txt_map.Name = "txt_map";
            this.txt_map.Size = new System.Drawing.Size(33, 20);
            this.txt_map.TabIndex = 4;
            this.txt_map.Text = "530";
            this.txt_map.TextChanged += new System.EventHandler(this.txt_map_TextChanged);
            // 
            // txt_spawnMask
            // 
            this.txt_spawnMask.Location = new System.Drawing.Point(273, 104);
            this.txt_spawnMask.Name = "txt_spawnMask";
            this.txt_spawnMask.Size = new System.Drawing.Size(59, 20);
            this.txt_spawnMask.TabIndex = 5;
            this.txt_spawnMask.Text = "1";
            this.txt_spawnMask.TextChanged += new System.EventHandler(this.txt_spawnMask_TextChanged);
            // 
            // txt_modelid
            // 
            this.txt_modelid.Location = new System.Drawing.Point(338, 104);
            this.txt_modelid.Name = "txt_modelid";
            this.txt_modelid.Size = new System.Drawing.Size(63, 20);
            this.txt_modelid.TabIndex = 6;
            this.txt_modelid.Text = "0";
            this.txt_modelid.TextChanged += new System.EventHandler(this.txt_modelid_TextChanged);
            // 
            // txt_equipmentId
            // 
            this.txt_equipmentId.Location = new System.Drawing.Point(407, 104);
            this.txt_equipmentId.Name = "txt_equipmentId";
            this.txt_equipmentId.Size = new System.Drawing.Size(67, 20);
            this.txt_equipmentId.TabIndex = 7;
            this.txt_equipmentId.Text = "0";
            this.txt_equipmentId.TextChanged += new System.EventHandler(this.txt_equipmentId_TextChanged);
            // 
            // txt_spawnMin
            // 
            this.txt_spawnMin.Location = new System.Drawing.Point(108, 104);
            this.txt_spawnMin.Name = "txt_spawnMin";
            this.txt_spawnMin.Size = new System.Drawing.Size(57, 20);
            this.txt_spawnMin.TabIndex = 8;
            this.txt_spawnMin.Text = "300";
            this.txt_spawnMin.TextChanged += new System.EventHandler(this.txt_spawnMin_TextChanged);
            // 
            // txt_spawnMax
            // 
            this.txt_spawnMax.Location = new System.Drawing.Point(171, 104);
            this.txt_spawnMax.Name = "txt_spawnMax";
            this.txt_spawnMax.Size = new System.Drawing.Size(57, 20);
            this.txt_spawnMax.TabIndex = 9;
            this.txt_spawnMax.Text = "300";
            this.txt_spawnMax.TextChanged += new System.EventHandler(this.txt_spawnMax_TextChanged);
            // 
            // txt_curhealth
            // 
            this.txt_curhealth.Location = new System.Drawing.Point(108, 148);
            this.txt_curhealth.Name = "txt_curhealth";
            this.txt_curhealth.Size = new System.Drawing.Size(70, 20);
            this.txt_curhealth.TabIndex = 10;
            this.txt_curhealth.Text = "XXXX";
            this.txt_curhealth.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_curhealth_MouseClick);
            this.txt_curhealth.TextChanged += new System.EventHandler(this.txt_curhealth_TextChanged);
            // 
            // txt_curmana
            // 
            this.txt_curmana.Location = new System.Drawing.Point(182, 148);
            this.txt_curmana.Name = "txt_curmana";
            this.txt_curmana.Size = new System.Drawing.Size(70, 20);
            this.txt_curmana.TabIndex = 11;
            this.txt_curmana.Text = "XXXX";
            this.txt_curmana.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_curmana_MouseClick);
            this.txt_curmana.TextChanged += new System.EventHandler(this.txt_curmana_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "currentwaypoint";
            // 
            // txt_currentWaypoint
            // 
            this.txt_currentWaypoint.Location = new System.Drawing.Point(261, 148);
            this.txt_currentWaypoint.Name = "txt_currentWaypoint";
            this.txt_currentWaypoint.Size = new System.Drawing.Size(79, 20);
            this.txt_currentWaypoint.TabIndex = 13;
            this.txt_currentWaypoint.Text = "0";
            this.txt_currentWaypoint.TextChanged += new System.EventHandler(this.txt_currentWaypoint_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "DeathState";
            // 
            // txt_deathState
            // 
            this.txt_deathState.Location = new System.Drawing.Point(346, 148);
            this.txt_deathState.Name = "txt_deathState";
            this.txt_deathState.Size = new System.Drawing.Size(79, 20);
            this.txt_deathState.TabIndex = 15;
            this.txt_deathState.Text = "0";
            this.txt_deathState.TextChanged += new System.EventHandler(this.txt_deathState_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "curhealth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "curmana";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "minSpawn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "maxSpawn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Map";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "modelid";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "equipment_id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(270, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "spawnmask";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(122, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "MovementType";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(234, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "spawndist";
            // 
            // txt_movementType
            // 
            this.txt_movementType.Location = new System.Drawing.Point(108, 192);
            this.txt_movementType.Name = "txt_movementType";
            this.txt_movementType.Size = new System.Drawing.Size(100, 20);
            this.txt_movementType.TabIndex = 26;
            this.txt_movementType.Text = "0";
            this.txt_movementType.TextChanged += new System.EventHandler(this.txt_movementType_TextChanged);
            // 
            // txt_spawndist
            // 
            this.txt_spawndist.Location = new System.Drawing.Point(214, 192);
            this.txt_spawndist.Name = "txt_spawndist";
            this.txt_spawndist.Size = new System.Drawing.Size(100, 20);
            this.txt_spawndist.TabIndex = 27;
            this.txt_spawndist.Text = "0";
            this.txt_spawndist.TextChanged += new System.EventHandler(this.txt_spawndist_TextChanged);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(27, 306);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(545, 20);
            this.txt_result.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(171, 290);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(238, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Result: (Generates automatically on field change)";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 357);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(545, 60);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 468);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_spawndist);
            this.Controls.Add(this.txt_movementType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_deathState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_currentWaypoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_curmana);
            this.Controls.Add(this.txt_curhealth);
            this.Controls.Add(this.txt_spawnMax);
            this.Controls.Add(this.txt_spawnMin);
            this.Controls.Add(this.txt_equipmentId);
            this.Controls.Add(this.txt_modelid);
            this.Controls.Add(this.txt_spawnMask);
            this.Controls.Add(this.txt_map);
            this.Controls.Add(this.txt_orientation);
            this.Controls.Add(this.txt_positionString);
            this.Controls.Add(this.txt_creatureGUID);
            this.Controls.Add(this.txt_creatureEntry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_creatureEntry;
        private System.Windows.Forms.TextBox txt_creatureGUID;
        private System.Windows.Forms.TextBox txt_positionString;
        private System.Windows.Forms.TextBox txt_orientation;
        private System.Windows.Forms.TextBox txt_map;
        private System.Windows.Forms.TextBox txt_spawnMask;
        private System.Windows.Forms.TextBox txt_modelid;
        private System.Windows.Forms.TextBox txt_equipmentId;
        private System.Windows.Forms.TextBox txt_spawnMin;
        private System.Windows.Forms.TextBox txt_spawnMax;
        private System.Windows.Forms.TextBox txt_curhealth;
        private System.Windows.Forms.TextBox txt_curmana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_currentWaypoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_deathState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_movementType;
        private System.Windows.Forms.TextBox txt_spawndist;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

