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
    public partial class frm_multiSpawnGen : Form
    {
        static DataTable spawns = new DataTable();
        static DataTable spawnData = new DataTable();
        PacketFiltering filter = new PacketFiltering();
        
        public frm_multiSpawnGen()
        {
            InitializeComponent();
        }

        private void frm_multiSpawnGen_Load(object sender, EventArgs e)
        {
            
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

            List<string> filterList = new List<string>(new string[]{ "SMSG_UPDATE_OBJECT" });
            List<string> createObjectList = filter.FilterSniffFile(filename, false, filterList);
            spawns = filter.GetDataTableForSpawns(createObjectList, true);

            //spawnData = spawns.Clone();

            //foreach (DataRow row in spawns.Rows)
            //{
            //    if (row.Field<string>(1) == creature_guid)
            //        spawnData.ImportRow(row);
            //}

            dgv_grid.Rows.Clear();
            dgv_grid.Columns.Clear();

            //for (int i = 0; i < spawns.Rows.Count; i++)
            //{
            //    dgv_grid.Rows.Add(spawns.Columns[0]);
            //}


            dgv_grid.DataSource = spawns;
            Cursor = Cursors.Default;
        }
    }
}
