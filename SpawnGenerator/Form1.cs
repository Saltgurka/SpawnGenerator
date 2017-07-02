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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            string guid = txt_creatureGUID.Text;
            if (txt_creatureGUID.Text == "Creature GUID")
            {
                guid = "XXX";
            }

            string entry = txt_creatureEntry.Text;
            if (txt_creatureEntry.Text == "Creature Entry")
            {
                entry = "XXX";
            }

            // Split string on spaces.
            string[] position = txt_positionString.Text.Split(' ');
            string[] orientation = txt_orientation.Text.Split(' ');

            txt_result.Text = "(" 
                + guid + "," 
                + entry + "," 
                + txt_map.Text + "," 
                + txt_spawnMask.Text + "," 
                + txt_modelid.Text + "," 
                + txt_equipmentId.Text + ","
                + position[3] + ","
                + position[5] + ","
                + position[7] + ","
                + orientation[2] + ","
                + txt_spawnMin.Text + ","
                + txt_spawnMax.Text + ","
                + txt_spawndist.Text + ","
                + txt_currentWaypoint.Text + ","
                + txt_curhealth.Text + ","
                + txt_curmana.Text + ","
                + txt_deathState.Text + ","
                + txt_movementType.Text + "),";
        }

        private void txt_creatureGUID_MouseClick(object sender, MouseEventArgs e)
        {
            txt_creatureGUID.Text = "";
        }

        private void txt_creatureEntry_MouseClick(object sender, MouseEventArgs e)
        {
            txt_creatureEntry.Text = "";
        }

        private void txt_positionString_MouseClick(object sender, MouseEventArgs e)
        {
            txt_positionString.Text = "";
        }

        private void txt_orientation_MouseClick(object sender, MouseEventArgs e)
        {
            txt_orientation.Text = "";
        }

        private void txt_curhealth_MouseClick(object sender, MouseEventArgs e)
        {
            txt_curhealth.Text = "";
        }

        private void txt_curmana_MouseClick(object sender, MouseEventArgs e)
        {
            txt_curmana.Text = "";
        }
    }
}
