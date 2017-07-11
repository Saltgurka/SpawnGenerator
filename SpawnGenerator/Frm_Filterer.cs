using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SpawnGenerator
{
    public partial class frm_Filterer : Form
    {
        //static DataTable packets = new DataTable();

        public frm_Filterer()
        {
            InitializeComponent();

            if (Properties.Settings.Default.Whitelist == null || Properties.Settings.Default.Whitelist.Count == 0)
            {
                Properties.Settings.Default.Whitelist = GetWhitelist(); // Will get the default values
                Properties.Settings.Default.Save();
            }

            if (Properties.Settings.Default.Blacklist == null || Properties.Settings.Default.Blacklist.Count == 0)
            {
                Properties.Settings.Default.Blacklist = GetBlacklist(); // Will get the default values
                Properties.Settings.Default.Save();
            }

            clb_packetBlackList.DataSource = Properties.Settings.Default.Blacklist;
            clb_packetWhitelist.DataSource = Properties.Settings.Default.Whitelist;
        }

        private void btn_loadSource_Click(object sender, EventArgs e)
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
                ConvertSniffFile(openFileDialog.FileName);
            }
            else
            {
                // This code runs if the dialog was cancelled
                return;
            }
        }

        private void ConvertSniffFile(string fileName)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(fileName);
            var line = file.ReadLine();
            file.Close();

            if (line == "# TrinityCore - WowPacketParser")
            {
                string filenameNoPath = Path.GetFileNameWithoutExtension(fileName);
                TextWriter tw = new StreamWriter(filenameNoPath + "_filtered.txt");

                foreach (String s in GetDataSourceFromSniffFile(fileName))
                    tw.WriteLine(s);

                tw.Close();
            }
            else
            {
                MessageBox.Show(saveFileDialog.FileName + " is is not a valid TrinityCore parsed sniff file.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private List<string> GetDataSourceFromSniffFile(string fileName)
        {
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            var lines = File.ReadAllLines(fileName);

            string[] packets = new string[lines.Count()];
            List<string> newFileStrings = new List<string>();

            for (int i = 0; i < 7; i++) // Write the first lines without filtering
            {
                newFileStrings.Add(lines[i]);
            }

            // Add filter information
            newFileStrings.Add("# This sniff file was filtered using Saltgurka's sniff filterer.");
            newFileStrings.Add("# The following packets were " + (rdb_blacklist.Checked ? "BLACKLISTED:" : "WHITELISTED:"));
            newFileStrings.Add("--------------------------------");

            if (rdb_blacklist.Checked)
            {
                foreach (int i in clb_packetBlackList.CheckedIndices)
                {
                    newFileStrings.Add(clb_packetBlackList.Items[i].ToString());
                }
            }
            else
            {
                foreach (int i in clb_packetWhitelist.CheckedIndices)
                {
                    newFileStrings.Add(clb_packetWhitelist.Items[i].ToString());
                }
            }

            newFileStrings.Add("--------------------------------");
            newFileStrings.Add("");

            if (rdb_blacklist.Checked) // Filter by blacklist
            {
                List<string> blackList = GetCheckedBlacklist();

                for (int i = 1; i < lines.Count(); i++)
                {
                    if (lines[i - 1] == (""))
                    {
                        if (!blackList.Any(s => lines[i].Contains(s)))
                        {
                            do
                            {
                                newFileStrings.Add(lines[i]);
                                i++;

                            } while (lines[i] != "");
                            newFileStrings.Add("");
                        }

                    }
                }
            }
            else // Filter by whitelist
            {
                List<string> whiteList = GetCheckedWhitelist();

                for (int i = 1; i < lines.Count(); i++)
                {
                    if (lines[i - 1] == (""))
                    {
                        if (whiteList.Any(s => lines[i].Contains(s)))
                        {
                            do
                            {
                                newFileStrings.Add(lines[i]);
                                i++;

                            } while (lines[i] != "");
                            newFileStrings.Add("");
                        }

                    }
                }
            }

            Cursor = Cursors.Default;
            return newFileStrings;
        }

        private List<string> GetCheckedBlacklist()
        {
            List<string> checkedBlacklist = new List<string>();
            foreach (string s in clb_packetBlackList.CheckedItems)
            {
                checkedBlacklist.Add(s);
            }

            return checkedBlacklist;
        }

        private List<string> GetBlacklist()
        {
            List<string> defaultBlacklist = new List<string>();
            foreach (string s in clb_packetBlackList.Items)
            {
                defaultBlacklist.Add(s);
            }

            return defaultBlacklist;
        }

        private List<string> GetCheckedWhitelist()
        {
            List<string> checkedWhitelist = new List<string>();
            foreach (string s in clb_packetWhitelist.CheckedItems)
            {
                checkedWhitelist.Add(s);
            }

            return checkedWhitelist;
        }

        private List<string> GetWhitelist()
        {
            List<string> defaultWhitelist = new List<string>();
            foreach (string s in clb_packetWhitelist.Items)
            {
                defaultWhitelist.Add(s);
            }

            return defaultWhitelist;
        }

        private void btn_addPacket_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.Blacklist.Contains(txt_addBlacklistEntry.Text))
            {
                Properties.Settings.Default.Blacklist.Add(txt_addBlacklistEntry.Text);
                Properties.Settings.Default.Save();

                clb_packetBlackList.DataSource = null;
                clb_packetBlackList.DataSource = Properties.Settings.Default.Blacklist;
                txt_addBlacklistEntry.Text = "";
            }
        }

        private void btn_removePacket_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove the item in the List.
                Properties.Settings.Default.Blacklist.RemoveAt(clb_packetBlackList.SelectedIndex);
                Properties.Settings.Default.Save();
            }
            catch
            {
            }

            clb_packetBlackList.DataSource = null;
            clb_packetBlackList.DataSource = Properties.Settings.Default.Blacklist;
        }


        private void btn_addWhitelistEntry_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.Whitelist.Contains(txt_addWhitelistEntry.Text))
            {
                Properties.Settings.Default.Whitelist.Add(txt_addWhitelistEntry.Text);
                Properties.Settings.Default.Save();

                clb_packetWhitelist.DataSource = null;
                clb_packetWhitelist.DataSource = Properties.Settings.Default.Whitelist;
                txt_addWhitelistEntry.Text = "";
            }
        }

        private void btn_removeWhitelistEntry_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove the item in the List.
                Properties.Settings.Default.Whitelist.RemoveAt(clb_packetWhitelist.SelectedIndex);
                Properties.Settings.Default.Save();
            }
            catch
            {
            }

            clb_packetWhitelist.DataSource = null;
            clb_packetWhitelist.DataSource = Properties.Settings.Default.Whitelist;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_checkAllBlacklist_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_packetBlackList.Items.Count; i++)
            {
                clb_packetBlackList.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void btn_checkNoneBlacklist_Click(object sender, EventArgs e)
        {
            foreach (int i in clb_packetBlackList.CheckedIndices)
            {
                clb_packetBlackList.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void btn_checkAllWhitelist_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_packetWhitelist.Items.Count; i++)
            {
                clb_packetWhitelist.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void btn_checkNoneWhitelist_Click(object sender, EventArgs e)
        {
            foreach (int i in clb_packetWhitelist.CheckedIndices)
            {
                clb_packetWhitelist.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void btn_removeAllBlacklistEntries_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove the item in the List.
                Properties.Settings.Default.Blacklist.Clear();
                Properties.Settings.Default.Save();
            }
            catch
            {
            }

            clb_packetBlackList.DataSource = null;
            clb_packetBlackList.DataSource = Properties.Settings.Default.Blacklist;
        }

        private void btn_removeAllWhitelistEntries_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove the item in the List.
                Properties.Settings.Default.Whitelist.Clear();
                Properties.Settings.Default.Save();
            }
            catch
            {
            }

            clb_packetWhitelist.DataSource = null;
            clb_packetWhitelist.DataSource = Properties.Settings.Default.Whitelist;
        }
    }
}
