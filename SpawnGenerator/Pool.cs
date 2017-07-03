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
    public partial class Pool : Form
    {
        public Pool()
        {
            InitializeComponent();
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

            rtxt_templateOutput.Text = "DELETE FROM pool_template WHERE entry BETWEEN " + startEntry + " AND " + endEntry + ";\nINSERT INTO pool_template (entry, max_limit, description) VALUES\n";

            for (int i = 0; i < poolAmount+1; i++)
            {
                if (i != poolAmount)
                    rtxt_templateOutput.Text += "(" + (startEntry + i) + "," + maxLimit + ",'" + txt_description.Text + "'),\n";
                else // Semicolon if it's the last one
                    rtxt_templateOutput.Text += "(" + (startEntry + i) + "," + maxLimit + ",'" + txt_description.Text + "');\n";
            }
        }
    }
}
