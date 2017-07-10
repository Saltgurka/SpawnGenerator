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
    public partial class Timestamp_Subtractor : Form
    {
        public Timestamp_Subtractor()
        {
            InitializeComponent();
        }
        
        private int[] SplitTimestampString(string timestampString)
        {
            string[] timestampStrings = timestampString.Split(':','.');

            int hours;
            int minutes;
            int seconds;
            int milliseconds;

            if (!Int32.TryParse(timestampStrings[0], out hours))
            {
                txt_difference.Text = "Error! Correct Format: XX:XX:XX.XXX";
                return null;
            }

            if (!Int32.TryParse(timestampStrings[1], out minutes))
            {
                txt_difference.Text = "Error! Correct Format: XX:XX:XX.XXX";
                return null;
            }

            if (!Int32.TryParse(timestampStrings[2], out seconds))
            {
                txt_difference.Text = "Error! Correct Format: XX:XX:XX.XXX";
                return null;
            }

            if (!Int32.TryParse(timestampStrings[3], out milliseconds))
            {
                txt_difference.Text = "Error! Correct Format: XX:XX:XX.XXX";
                return null;
            }

            int[] timestampSplitResult = new int[] { hours, minutes, seconds, milliseconds };

            return timestampSplitResult;
        }

        private void CalculateDiff()
        {
            // txt_difference.Text = 

            int[] timeStamp1 = SplitTimestampString(txt_timestamp1.Text);
            int[] timeStamp2 = SplitTimestampString(txt_timestamp2.Text);

            if (timeStamp1 == null || timeStamp2 == null || timeStamp1.GetLength(0) < 3 || timeStamp2.GetLength(0) < 3)
            {
                txt_difference.Text = "Error! Correct Format: XX:XX:XX.XXX";
                return;
            }

            DateTime t1 = new System.DateTime(1, 1, 1, timeStamp1[0], timeStamp1[1], timeStamp1[2], timeStamp1[3]);
            DateTime t2 = new System.DateTime(1, 1, 1, timeStamp2[0], timeStamp2[1], timeStamp2[2], timeStamp2[3]);

            // diff1 gets 185 days, 14 hours, and 47 minutes.
            TimeSpan diff = t1.Subtract(t2);

            double diffResult;

            if (rdb_diffAsMilliseconds.Checked)
                diffResult = diff.TotalMilliseconds;
            else
                diffResult = diff.TotalSeconds;

            txt_difference.Text = diffResult.ToString(System.Globalization.CultureInfo.InvariantCulture);
        }

        private void txt_timestamp1_TextChanged(object sender, EventArgs e)
        {
            CalculateDiff();
        }

        private void txt_timestamp2_TextChanged(object sender, EventArgs e)
        {
            CalculateDiff();
        }

        private void txt_difference_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_timestamp1_Click(object sender, EventArgs e)
        {
            txt_timestamp1.Text = "";
        }

        private void txt_timestamp2_Click(object sender, EventArgs e)
        {
            txt_timestamp2.Text = "";
        }

        private void rdb_diffAsSeconds_CheckedChanged(object sender, EventArgs e)
        {
            CalculateDiff();
        }

        private void rdb_diffAsMilliseconds_CheckedChanged(object sender, EventArgs e)
        {
            CalculateDiff();
        }
    }
}
