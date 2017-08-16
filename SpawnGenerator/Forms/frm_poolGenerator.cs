using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpawnGenerator
{
    public partial class frm_poolGenerator : Form
    {
        List<Pool_X> pool_x = new List<Pool_X>();
        public frm_poolGenerator()
        {
            InitializeComponent();
        }

        public class Pool_X
        {
            public int CreatureIndex { get; set; }
            public int Guid { get; set; }
            public int Chance { get; set; }
            public string Description { get; set; }
        }

        private void btn_generateTemplate_Click(object sender, EventArgs e)
        {
            int startEntry = 0;
            int endEntry = 0;
            int maxLimit = 0;

            if (!Int32.TryParse(txt_startEntry.Text, out startEntry))
            {
                rtxt_templateOutput.Text = "Start Entry invalid!";
                return;
            }
            if (!Int32.TryParse(txt_endEntry.Text, out endEntry))
            {
                rtxt_templateOutput.Text = "End Entry invalid!";
                return;
            }
            if (!Int32.TryParse(txt_maxLimit.Text, out maxLimit))
            {
                rtxt_templateOutput.Text = "Max Limit invalid!";
                return;
            }

            int poolAmount = endEntry - startEntry;

            rtxt_templateOutput.Text = "DELETE FROM pool_template WHERE entry BETWEEN " + startEntry + " AND " + endEntry + ";\n"
                + "INSERT INTO pool_template (entry, max_limit, description) VALUES\n";

            for (int i = 0; i < poolAmount + 1; i++)
            {
                if (i != poolAmount)
                    rtxt_templateOutput.Text += "(" + (startEntry + i) + "," + maxLimit + ",'" + txt_description.Text + (box_incDescNumTemplate.Checked ? " " + (i + 1).ToString() : "") + "'),\n";
                else // Semicolon if it's the last one
                    rtxt_templateOutput.Text += "(" + (startEntry + i) + "," + maxLimit + ",'" + txt_description.Text + (box_incDescNumTemplate.Checked ? " " + (i + 1).ToString() : "") + "');\n";
            }
        }

        private void btn_addCreatureToList_Click(object sender, EventArgs e)
        {
            cmb_creatureList.Items.Add(txt_addCreatureToList.Text);
            cmb_creatureList.SelectedItem = txt_addCreatureToList.Text;
        }

        private void btn_deleteFromCMB_Click(object sender, EventArgs e)
        {
            cmb_creatureList.Items.Remove(cmb_creatureList.SelectedItem);
            cmb_creatureList.SelectedIndex = -1;
            cmb_creatureList.Text = "";

            txt_guid.Text = "";
            txt_chance.Text = "";
            txt_poolDescription.Text = "";

            int selectedIndex = cmb_creatureList.SelectedIndex;

            bool containsItem = pool_x.Any(item => item.CreatureIndex == selectedIndex);

            if (containsItem)
            {
                pool_x.RemoveAt(selectedIndex);
            }
        }
        private void btn_generatePool_Click(object sender, EventArgs e)
        {
            int startEntry = 0;
            int endEntry = 0;
            int guid = 0;
            int creatureAmount = cmb_creatureList.Items.Count;

            if (!Int32.TryParse(txt_startEntryPool.Text, out startEntry))
            {
                rtxt_poolOutput.Text = "Start Entry invalid!";
                return;
            }
            if (!Int32.TryParse(txt_endEntryPool.Text, out endEntry))
            {
                rtxt_poolOutput.Text = "End Entry invalid!";
                return;
            }
            if (!Int32.TryParse(txt_guid.Text, out guid))
            {
                rtxt_poolOutput.Text = "GUID invalid!";
                return;
            }

            int poolAmount = endEntry - startEntry;

            rtxt_poolOutput.Text = "DELETE FROM pool_creature WHERE pool_entry BETWEEN " + startEntry + " AND " + endEntry + ";\n"
                + "INSERT INTO pool_creature (guid, pool_entry, chance, description) VALUES\n";

            for (int i = 0; i < poolAmount + 1; i++)
            {
                for (int j = 0; j < creatureAmount; j++)
                {
                    if (i != poolAmount || !(j == creatureAmount - 1))
                        rtxt_poolOutput.Text += "(" + (pool_x[j].Guid + i) + "," + (startEntry + i) + "," + pool_x[j].Chance + ",'" + pool_x[j].Description + (box_incrDescNum.Checked ? " " + (i + 1).ToString() : "") + "'),\n";
                    else if (j == creatureAmount - 1) // Semicolon if it's the last one
                        rtxt_poolOutput.Text += "(" + (pool_x[j].Guid + i) + "," + (startEntry + i) + "," + pool_x[j].Chance + ",'" + pool_x[j].Description + (box_incrDescNum.Checked ? " " + (i + 1).ToString() : "") + "');\n";
                }

                if (box_emptyRows.Checked)
                    rtxt_poolOutput.Text += "\n";
            }
        }

        private void txt_chance_TextChanged(object sender, EventArgs e)
        {
            if (cmb_creatureList.Items.Count == 0 || cmb_creatureList.SelectedIndex == -1) // No items in list or no selected item. Don't allow any input
            {
                txt_chance.Text = "";
                return;
            }
        }

        private void btn_savePool_Click(object sender, EventArgs e)
        {
            int guid = 0;
            int chance = 0;
            Int32.TryParse(txt_guid.Text, out guid);
            Int32.TryParse(txt_chance.Text, out chance);

            int selectedIndex = cmb_creatureList.SelectedIndex;

            bool containsItem = pool_x.Any(item => item.CreatureIndex == selectedIndex);

            if (!containsItem)
            {
                pool_x.Add(new Pool_X
                {
                    CreatureIndex = cmb_creatureList.SelectedIndex,
                    Guid = guid,
                    Chance = chance,
                    Description = txt_poolDescription.Text
                });
            }
            else
            {
                pool_x[selectedIndex].Guid = guid;
                pool_x[selectedIndex].Chance = chance;
                pool_x[selectedIndex].Description = txt_poolDescription.Text;
            }
        }

        private void cmb_creatureList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmb_creatureList.SelectedIndex;

            bool containsItem = pool_x.Any(item => item.CreatureIndex == selectedIndex);

            if (containsItem)
            {
                txt_guid.Text = pool_x[selectedIndex].Guid.ToString();
                txt_chance.Text = pool_x[selectedIndex].Chance.ToString();
                txt_poolDescription.Text = pool_x[selectedIndex].Description;
            }
            else
            {
                txt_guid.Text = "";
                txt_chance.Text = "";
                txt_poolDescription.Text = "";
            }
        }

        private void txt_guid_TextChanged(object sender, EventArgs e)
        {
            if (cmb_creatureList.Items.Count == 0 || cmb_creatureList.SelectedIndex == -1) // No items in list or no selected item. Don't allow any input
            {
                txt_guid.Text = "";
                return;
            }
        }

        private void txt_poolDescription_TextChanged(object sender, EventArgs e)
        {
            if (cmb_creatureList.Items.Count == 0 || cmb_creatureList.SelectedIndex == -1) // No items in list or no selected item. Don't allow any input
            {
                txt_description.Text = "";
                return;
            }
        }
    }
}
