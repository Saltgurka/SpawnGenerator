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
    public partial class frm_textParser : Form
    {
        static DataTable spawns = new DataTable();
        PacketFiltering filter = new PacketFiltering();
        public frm_textParser()
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
            openFileDialog.Multiselect = true;
            openFileDialog.CheckFileExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                int numOfFiles = openFileDialog.FileNames.Length;
                int currentFile = 0;
                progress.Step = 100 / numOfFiles;

                foreach (String file in openFileDialog.FileNames)
                {
                    currentFile++;
                    lbl_currentFileCount.Text = "File " + currentFile + "/" + numOfFiles;
                    progress.PerformStep();
                    FillDataTable(file);
                }

                lbl_currentFileCount.Text = "Done!";
                progress.Value = 0;
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

            List<string> filterList = new List<string>(new string[] { "SMSG_CHAT" });
            List<string> textList = filter.FilterSniffFile(filename, false, filterList);

            spawns.Merge(filter.GetDataTableForTexts(textList, filename));

            dgv_grid.DataSource = null;
            dgv_grid.DataSource = spawns;
            Cursor = Cursors.Default;
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgv_grid.DataSource;
            bs.Filter = dgv_grid.Columns[0].HeaderText.ToString() + " LIKE '%" + txt_filterText.Text + "%'";
            dgv_grid.DataSource = bs;
        }
    }
}
