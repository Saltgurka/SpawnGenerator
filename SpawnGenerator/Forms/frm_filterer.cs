﻿using System;
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
    public partial class frm_filterer : Form
    {
        //static DataTable packets = new DataTable();

        public frm_filterer()
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

        PacketFiltering packetFiltering = new PacketFiltering();

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
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            System.IO.StreamReader file = new System.IO.StreamReader(fileName);
            var line = file.ReadLine();
            file.Close();

            if (line == "# TrinityCore - WowPacketParser")
            {
                string filenameNoPath = Path.GetFileNameWithoutExtension(fileName);
                TextWriter tw = new StreamWriter(filenameNoPath + "_filtered.txt");

                foreach (String s in packetFiltering.FilterSniffFile(fileName,rdb_blacklist.Checked,GetCheckedFilterList()))
                    tw.WriteLine(s);

                tw.Close();
            }
            else
            {
                MessageBox.Show(saveFileDialog.FileName + " is is not a valid TrinityCore parsed sniff file.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            Cursor = Cursors.Default;
        }

        private List<string> GetCheckedFilterList()
        {
            List<string> checkedFilterList = new List<string>();

            if (rdb_blacklist.Checked)
            {
                foreach (string s in clb_packetBlackList.CheckedItems)
                {
                    checkedFilterList.Add(s);
                }
            }
            else
            {
                foreach (string s in clb_packetWhitelist.CheckedItems)
                {
                    checkedFilterList.Add(s);
                }
            }
            return checkedFilterList;
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

        private void btn_openDestination_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath);
        }
    }
}
