using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpawnGenerator.Forms
{
    public partial class frm_waypointGen : Form
    {
        public frm_waypointGen()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            string[] lines = null;
            lines = rtb_input.Text.Split(new char[] { '\n' });
            int point = 1;

            rtb_output.Text = "INSERT INTO `creature_movement_template` (`entry`,`pathId`,`point`,`position_x`,`position_y`,`position_z`,`waittime`,`script_id`,`orientation`) VALUES\n";

            for (int i = 0; i < lines.Length; i++)
            {
                double x = 0;
                double y = 0;
                double z = 0;
                double o = 0;

                if (lines[i].Contains("X:"))
                {
                    string[] xLine = lines[i].Split('X');
                    string[] xCoord = xLine[1].Split(' ');
                    x = double.Parse(xCoord[1], CultureInfo.InvariantCulture.NumberFormat);
                }

                if (lines[i].Contains("Y:"))
                {
                    string[] yLine = lines[i].Split('Y');
                    string[] yCoord = yLine[1].Split(' ');
                    y = double.Parse(yCoord[1], CultureInfo.InvariantCulture.NumberFormat);
                }

                if (lines[i].Contains("Z:"))
                {
                    string[] zLine = lines[i].Split('Z');
                    string[] zCoord = zLine[1].Split(' ');
                    z = double.Parse(zCoord[1], CultureInfo.InvariantCulture.NumberFormat);
                }

                rtb_output.Text += "(" + txt_entry.Text + "," + txt_pathId.Text + "," + point + "," + x + "," + y + "," + z + ",0,0,100),\n";
                point++;
            }
        }

        private void txt_entry_Click(object sender, EventArgs e)
        {
            txt_entry.Text = "";
        }

        private void txt_pathId_Click(object sender, EventArgs e)
        {
            txt_pathId.Text = "";
        }
    }
}
