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
                btn_moreFiles.Enabled = true;
                btn_loadSniff.Enabled = false;
            }
            else
            {
                // This code runs if the dialog was cancelled
                return;
            }
        }


        private void btn_moreFiles_Click(object sender, EventArgs e)
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
                MergeAdditionalData(openFileDialog.FileName);
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

            dgv_grid.Rows.Clear();
            dgv_grid.Columns.Clear();

            dgv_grid.DataSource = spawns;
            Cursor = Cursors.Default;
        }

        private void MergeAdditionalData(string filename)
        {
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            List<string> filterList = new List<string>(new string[] { "SMSG_UPDATE_OBJECT" });
            List<string> createObjectList = filter.FilterSniffFile(filename, false, filterList);

            spawns.Merge(filter.GetDataTableForSpawns(createObjectList, true));

            dgv_grid.DataSource = null;
            dgv_grid.DataSource = spawns;
            Cursor = Cursors.Default;
        }

        private void btn_generateMarked_Click(object sender, EventArgs e)
        {
            if (dgv_grid.SelectedRows.Count == 0)
                return;

            if (rdb_asSpawns.Checked)
            {
                int guid;

                if (!Int32.TryParse(txt_creatureGUID.Text, out guid))
                {
                    rtxt_SQLResult.Text = "Creature GUID invalid!";
                    return;
                }

                string output;
                output = "INSERT INTO creature (guid, id, map, spawnMask, modelid, equipment_id, position_x, position_y, position_z, orientation, spawntimesecsmin, spawntimesecsmax, spawndist, currentwaypoint, curhealth, curmana, DeathState, MovementType) VALUES\n";

                foreach (DataGridViewRow row in dgv_grid.SelectedRows)
                {
                    output += "("
                        + guid + ","
                        + row.Cells[1].Value + ","
                        + txt_map.Text + ","
                        + txt_spawnMask.Text + ","
                        + txt_modelid.Text + ","
                        + txt_equipmentId.Text + ","
                        + row.Cells[4].Value + ","
                        + row.Cells[5].Value + ","
                        + row.Cells[6].Value + ","
                        + row.Cells[7].Value + ","
                        + txt_spawnMin.Text + ","
                        + txt_spawnMax.Text + ","
                        + txt_spawndist.Text + ","
                        + txt_currentWaypoint.Text + ","
                        + txt_curhealth.Text + ","
                        + txt_curmana.Text + ","
                        + txt_deathState.Text + ","
                        + txt_movementType.Text + "),\n";

                    guid++;
                }

                rtxt_SQLResult.Text = output;
            }
            else if (rdb_asDbscript.Checked)
            {
                int pathId;

                if (!Int32.TryParse(txt_dbscriptPathId.Text, out pathId))
                {
                    rtxt_SQLResult.Text = "PathId invalid!";
                    return;
                }

                string output;
                output = "INSERT INTO `dbscripts_on_creature_movement` (`id`,`delay`,`command`,`datalong`,`datalong2`,`datalong3`,`dataint`,`dataint2`,`dataint3`,`dataint4`,`buddy_entry`,`search_radius`,`data_flags`,`comments`,`x`,`y`,`z`,`o`) VALUES\n";

                foreach (DataGridViewRow row in dgv_grid.SelectedRows)
                {
                    output += "("
                        + txt_dbscriptID.Text + "," // id
                        + txt_dbscriptDelay.Text + "," // delay
                        + "10," // command
                        + row.Cells[1].Value + "," // datalong
                        + txt_dbscriptDespawnTime.Text + "," // datalong2
                        + pathId + "," // datalong3
                        + (box_dbscriptRunOn.Checked ? "1," : "0,") // dataint1
                        + "0," // dataint2
                        + "0," // dataint3
                        + "0," // dataint4
                        + "0," // buddy_entry
                        + "0," // search_radius
                        + (box_dbscriptActiveObject.Checked ? "8," : "0,") // data_flags
                        + txt_dbscriptComment.Text + "," // comments
                        + row.Cells[4].Value + "," // x
                        + row.Cells[5].Value + "," // y
                        + row.Cells[6].Value + "," // z
                        + row.Cells[7].Value + "),\n"; // o

                    pathId++;
                }

                rtxt_SQLResult.Text = output;
            }
            else
            {
                int pathId;

                if (!Int32.TryParse(txt_dbscriptPathId.Text, out pathId))
                {
                    rtxt_SQLResult.Text = "PathId invalid!";
                    return;
                }

                string output;
                output = "INSERT INTO `creature_movement_template` (`entry`,`point`,`pathId`,`position_x`,`position_y`,`position_z`,`waittime`,`script_id`,`orientation`) VALUES\n";

                foreach (DataGridViewRow row in dgv_grid.SelectedRows)
                {
                    output += "("
                        + row.Cells[1].Value + "," // entry
                        + "1," // point
                        + pathId + "," // pathId
                        + row.Cells[4].Value + "," // position_x
                        + row.Cells[5].Value + "," // position_y
                        + row.Cells[6].Value + "," // position_z
                        + txt_waypointWaittime.Text + "," // waittime
                        + txt_waypointScriptId.Text + "," // script_id
                        + row.Cells[7].Value + "),\n"; // orientation

                    pathId++;
                }

                rtxt_SQLResult.Text = output;
            }
        }

        /// <summary>
        /// Remove creatures with identical entry,x,y,z,o
        /// </summary>
        private void RemoveDuplicateSpawns()
        {
            // This might be an inefficient way to do this, but it works

            List<string> unfilteredEntry = spawns.AsEnumerable().Select(x => x[1].ToString()).ToList();
            List<string> unfilteredX = spawns.AsEnumerable().Select(x => x[4].ToString()).ToList();
            List<string> unfilteredY = spawns.AsEnumerable().Select(x => x[5].ToString()).ToList();
            List<string> unfilteredZ = spawns.AsEnumerable().Select(x => x[6].ToString()).ToList();
            List<string> unfilteredMap = spawns.AsEnumerable().Select(x => x[8].ToString()).ToList();

            List<int> duplicates = new List<int>();

            for (int i = 0; i < unfilteredX.Count; i++) // Check duplicate X
            {
                for (int j = i + 1; j < unfilteredX.Count; j++)
                {
                    if (unfilteredX[i] == unfilteredX[j]) // Duplicate X found
                    {
                        if (unfilteredEntry[i] == unfilteredEntry[j]) // Entry is also the same
                        {
                            if (unfilteredY[i] == unfilteredY[j]) // Y too
                            {
                                if (unfilteredZ[i] == unfilteredZ[j]) // Z too
                                {
                                    if (unfilteredMap[i] == unfilteredMap[j]) // Map too
                                    {
                                        // Duplicate found, add index to list
                                        duplicates.Add(j);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // Delete duplicates
            for (int i = spawns.Rows.Count - 1; i >= 0; i--)
            {
                if (duplicates.Contains(i))
                {
                    DataRow dr = spawns.Rows[i];
                    dr.Delete();
                }
            }
            spawns.AcceptChanges();

            dgv_grid.DataSource = null;
            dgv_grid.DataSource = spawns;
        }

        private void btn_deleteDuplicate_Click(object sender, EventArgs e)
        {
            RemoveDuplicateSpawns();
        }

        private void dgv_grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lbl_rows.Text = "Rows: " + dgv_grid.Rows.Count;
        }

        private void dgv_grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lbl_rows.Text = "Rows: " + dgv_grid.Rows.Count;
        }
    }
}
