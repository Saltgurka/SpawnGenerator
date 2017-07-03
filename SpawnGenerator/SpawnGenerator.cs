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
    public partial class SpawnGenerator : Form
    {
        public SpawnGenerator()
        {
            InitializeComponent();
        }

        private void UpdateOutput()
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
            
            if (position.GetLength(0) < 7)
            {
                txt_result.Text = "Position string incorrect!";
                return;
            }
            if (orientation.GetLength(0) < 2)
            {
                txt_result.Text = "Orientation string incorrect!";
                return;
            }

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

        private void btn_generate_Click(object sender, EventArgs e)
        {
            UpdateOutput();
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

        private void txt_creatureGUID_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void txt_creatureEntry_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void txt_positionString_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void txt_orientation_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void txt_spawnMin_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void txt_spawnMax_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void txt_map_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void txt_spawnMask_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void txt_modelid_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void txt_equipmentId_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void txt_curhealth_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void txt_curmana_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void txt_currentWaypoint_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void txt_deathState_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void txt_movementType_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void txt_spawndist_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }
    }
}
