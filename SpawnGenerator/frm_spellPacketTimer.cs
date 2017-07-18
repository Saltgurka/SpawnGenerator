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
    public partial class frm_spellPacketTimer : Form
    {
        static DataTable spellTable = new DataTable();
        PacketFiltering filter = new PacketFiltering();
        public frm_spellPacketTimer()
        {
            InitializeComponent();
        }

        private void btn_loadSniff_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Open File";
            openFileDialog.Filter = "Parsed Sniff File (*.txt)|*.txt";
            openFileDialog.FileName = "*.txt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.ShowReadOnly = false;
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FillDataTable(openFileDialog.FileName);
                //btn_moreFiles.Enabled = true;
                //btn_loadSniff.Enabled = false;
            }
            else
            {
                // This code runs if the dialog was cancelled
                return;
            }
        }

        private void FillDataTable(string filename)
        {
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            List<string> filterList = new List<string>(new string[] { "SMSG_SPELL_START" });
            List<string> createObjectList = filter.FilterSniffFile(filename, false, filterList);
            spellTable = filter.GetDataTableForSpells(createObjectList);

            //dgv_grid.Rows.Clear();
            dgv_grid.Columns.Clear();

            dgv_grid.DataSource = spellTable;
            Cursor = Cursors.Default;
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            int filterType;
            if (rdb_spellFilter.Checked)
                filterType = 0;
            else if (rdb_casterFilter.Checked)
                filterType = 1;
            else if (rdb_casterEntryFilter.Checked)
                filterType = 2;
            else if (rdb_casterGuidFilter.Checked)
                filterType = 3;
            else if (rdb_targetFilter.Checked)
                filterType = 4;
            else if (rdb_targetEntryFilter.Checked)
                filterType = 5;
            else
                return;

            BindingSource bs = new BindingSource();
            bs.DataSource = dgv_grid.DataSource;
            bs.Filter = dgv_grid.Columns[filterType].HeaderText.ToString() + " LIKE '%" + txt_filter.Text + "%'";
            dgv_grid.DataSource = bs;

        }

        private void dgv_grid_DataSourceChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_grid.Rows.Count - 1; i++)
            {
                if (i == 0)
                    dgv_grid[7, 0].Value = "0";
                else
                {
                    int[] timeStamp1 = SplitTimestampString(dgv_grid[6, i].Value.ToString());
                    int[] timeStamp2 = SplitTimestampString(dgv_grid[6, i - 1].Value.ToString());

                    if (timeStamp1 == null || timeStamp2 == null || timeStamp1.GetLength(0) < 3 || timeStamp2.GetLength(0) < 3)
                    {
                        return;
                    }

                    DateTime t1 = new System.DateTime(1, 1, 1, timeStamp1[0], timeStamp1[1], timeStamp1[2], timeStamp1[3]);
                    DateTime t2 = new System.DateTime(1, 1, 1, timeStamp2[0], timeStamp2[1], timeStamp2[2], timeStamp2[3]);

                    // diff1 gets 185 days, 14 hours, and 47 minutes.
                    TimeSpan diff = t1.Subtract(t2);

                    double diffResult;

                    diffResult = diff.TotalMilliseconds;

                    dgv_grid[7, i].Value = diffResult;
                }
            }
        }

        private int[] SplitTimestampString(string timestampString)
        {
            string[] timestampStrings = timestampString.Split(':', '.');

            int hours;
            int minutes;
            int seconds;
            int milliseconds;

            if (!Int32.TryParse(timestampStrings[0], out hours))
            {
                return null;
            }

            if (!Int32.TryParse(timestampStrings[1], out minutes))
            {
                return null;
            }

            if (!Int32.TryParse(timestampStrings[2], out seconds))
            {
                return null;
            }

            if (!Int32.TryParse(timestampStrings[3], out milliseconds))
            {
                return null;
            }

            int[] timestampSplitResult = new int[] { hours, minutes, seconds, milliseconds };

            return timestampSplitResult;
        }
    }
}
