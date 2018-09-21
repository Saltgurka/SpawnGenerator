using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpawnGenerator.Forms
{
    public partial class frm_petSpells : Form
    {
        public frm_petSpells()
        {
            InitializeComponent();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            string[] lines = null;
            lines = rtb_input.Text.Split(new char[] { '\n' });

            rtb_output.Text = "";

            int s1 = 0;
            int s2 = 0;
            int s3 = 0;
            int s4 = 0;
            int s5 = 0;
            int s6 = 0;
            int s7 = 0;
            int s8 = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("(ActionButtons) [0] SpellID:"))
                {
                    string[] line = lines[i].Split(':');
                    s1 = int.Parse(line[1]);
                }
                if (lines[i].Contains("(ActionButtons) [1] SpellID:"))
                {
                    string[] line = lines[i].Split(':');
                    s2 = int.Parse(line[1]);
                }
                if (lines[i].Contains("(ActionButtons) [2] SpellID:"))
                {
                    string[] line = lines[i].Split(':');
                    s3 = int.Parse(line[1]);
                }
                if (lines[i].Contains("(ActionButtons) [3] SpellID:"))
                {
                    string[] line = lines[i].Split(':');
                    s4 = int.Parse(line[1]);
                }
                if (lines[i].Contains("(ActionButtons) [4] SpellID:"))
                {
                    string[] line = lines[i].Split(':');
                    s5 = int.Parse(line[1]);
                }
                if (lines[i].Contains("(ActionButtons) [5] SpellID:"))
                {
                    string[] line = lines[i].Split(':');
                    s6 = int.Parse(line[1]);
                }
                if (lines[i].Contains("(ActionButtons) [6] SpellID:"))
                {
                    string[] line = lines[i].Split(':');
                    s7 = int.Parse(line[1]);
                }
                if (lines[i].Contains("(ActionButtons) [7] SpellID:"))
                {
                    string[] line = lines[i].Split(':');
                    s8 = int.Parse(line[1]);
                }
            }
            rtb_output.Text += "DELETE FROM creature_template_spells WHERE entry IN(" + txt_entry.Text + ");\n" +
                "INSERT INTO creature_template_spells (entry,spell1,spell2,spell3,spell4,spell5,spell6,spell7,spell8) VALUES\n(" +
                txt_entry.Text + "," +
                s1.ToString() + "," +
                s2.ToString() + "," +
                s3.ToString() + "," +
                s4.ToString() + "," +
                s5.ToString() + "," +
                s6.ToString() + "," +
                s7.ToString() + "," +
                s8.ToString() +
                ");";
        }
    }
}
