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
    public partial class frm_gossipImport : Form
    {
        private List<Gossip> gossips = new List<Gossip>();
        private List<GossipMenuOption> gossipMenuOptions = new List<GossipMenuOption>();
        PacketFiltering filter = new PacketFiltering();
        List<string> addedTextIds = new List<string>();
        List<string> addedMenuTexts = new List<string>();

        public frm_gossipImport()
        {
            InitializeComponent();
        }

        private void frm_gossipImport_Load(object sender, EventArgs e)
        {
            try
            {
                LoadGossip();
                LoadGossipMenuOptions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadGossip()
        {
            string host = Properties.Settings.Default.Host;
            string database = Properties.Settings.Default.Database;
            string user = Properties.Settings.Default.User;
            string password = Properties.Settings.Default.Password;
            string port = Properties.Settings.Default.Port;
            DBConnect connect = new DBConnect(host, database, user, password, port);
            gossips = connect.GetGossip();
        }

        private void LoadGossipMenuOptions()
        {
            string host = Properties.Settings.Default.Host;
            string database = Properties.Settings.Default.Database;
            string user = Properties.Settings.Default.User;
            string password = Properties.Settings.Default.Password;
            string port = Properties.Settings.Default.Port;
            DBConnect connect = new DBConnect(host, database, user, password, port);
            gossipMenuOptions = connect.GetGossipMenuOptions();
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
                Cursor = Cursors.WaitCursor;
                Application.DoEvents();
                int numOfFiles = openFileDialog.FileNames.Length;
                int currentFile = 0;
                progress.Step = 100 / numOfFiles;

                foreach (String file in openFileDialog.FileNames)
                {
                    currentFile++;
                    lbl_currentFileCount.Text = "File " + currentFile + "/" + numOfFiles;
                    progress.PerformStep();

                    List<string> filterList = new List<string>(new string[] { "SMSG_GOSSIP_MESSAGE" });
                    List<string> gossipList = filter.FilterSniffFile(file, false, filterList);
                    CheckMissingGossip(filter.GetSniffGossip(gossipList));
                    CheckMissingGossipMenuOption(filter.GetSniffGossipOptionMenu(gossipList));
                }

                lbl_currentFileCount.Text = "Done!";
                progress.Value = 0;
                Cursor = Cursors.Default;
            }
            else
            {
                // This code runs if the dialog was cancelled
                return;
            }
        }

        private void CheckMissingGossip(List<Gossip> gossipList)
        {
            foreach (Gossip gossip in gossipList)
            {
                if (gossips.Any(item => item.MenuId == gossip.MenuId)) // Menu exists in DB
                {
                    if (gossips.Any(item => item.TextId == gossip.TextId && item.MenuId == gossip.MenuId)) // Menu exists and so does corresponding text_id. We're done
                    {
                        continue;
                    }
                    else // Menu exists but text_id is missing
                    {
                        if (!addedTextIds.Contains(gossip.TextId))
                            AddMissingGossip(gossip.Entry, gossip.MenuId, gossip.TextId);
                        addedTextIds.Add(gossip.TextId);
                    }
                }
                else // Menu is completely missing
                {
                    if (!addedTextIds.Contains(gossip.TextId))
                        AddMissingGossip(gossip.Entry, gossip.MenuId, gossip.TextId);
                    addedTextIds.Add(gossip.TextId);
                }
            }
        }

        private void AddMissingGossip(string entry, string menuId, string textId)
        {
            string output = "-- ----------------------------\n-- XXX (Entry: " + entry + ")\n" +
                "UPDATE creature_template SET GossipMenuId=" + menuId + ", NpcFlags=NpcFlags|1 WHERE entry=" + entry + ";\n\n" +
                //"DELETE FROM `gossip_menu` WHERE `entry`=" + menuId + ";\n" +
                "INSERT INTO `gossip_menu` (`entry`, `text_id`, `script_id`, `condition_id`) VALUES\n" +
                "(" + menuId + ", " + textId + ", 0, 0);\n\n";

            rtb_output.Text += output;
        }

        private void CheckMissingGossipMenuOption(List<GossipMenuOption> gossipList)
        {
            foreach (GossipMenuOption gossip in gossipList)
            {
                if (gossipMenuOptions.Any(item => item.MenuId == gossip.MenuId)) // Menu exists in DB
                {
                    if (gossipMenuOptions.Any(item => item.OptionText == gossip.OptionText && item.MenuId == gossip.MenuId)) // Menu exists and so does corresponding option menu. We're done
                    {
                        continue;
                    }
                    else // Menu exists but option menu is missing
                    {
                        if (!addedMenuTexts.Contains(gossip.OptionText))
                            AddMissingGossipMenuOption(gossip.Entry, gossip.MenuId, gossip.Id, gossip.OptionIcon, gossip.OptionNPCFlag, gossip.BoxMoney, gossip.OptionText, gossip.BoxText);
                        addedMenuTexts.Add(gossip.OptionText);
                    }
                }
                else // Menu is completely missing
                {
                    if (!addedMenuTexts.Contains(gossip.OptionText))
                        AddMissingGossipMenuOption(gossip.Entry, gossip.MenuId, gossip.Id, gossip.OptionIcon, gossip.OptionNPCFlag, gossip.BoxMoney, gossip.OptionText, gossip.BoxText);
                    addedMenuTexts.Add(gossip.OptionText);
                }
            }
        }

        private void AddMissingGossipMenuOption(string entry, string menuId, string id, string optionIcon, string optionNPCFlag, string boxMoney, string optionText, string boxText)
        {
            string output = "-- ----------------------------\n-- XXX (Entry: " + entry + ")\n" +
                "\nINSERT INTO `gossip_menu_option` (`menu_id`, `id`, `option_icon`, `option_text`, `option_id`, `npc_option_npcflag`, `action_menu_id`, `action_poi_id`, `action_script_id`, `box_coded`, `box_money`, `box_text`, `condition_id`) VALUES\n" +
                "(" + menuId + ", " +
                id + ", " +
                optionIcon + ", " +
                "'" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(optionText) + "'" + ", " +
                "XXX, " + // option_id
                optionNPCFlag + ", " +
                "0, " + // action_menu_id
                "0, " + // action_poi_id
                "0, " + // action_script_id
                "0, " + // box_coded
                boxMoney + ", " +
                "'" + MySql.Data.MySqlClient.MySqlHelper.EscapeString(boxText) + "'" + ", " +
                "0" + // condition_id
                ");\n\n";

            rtb_output.Text += output;
        }
    }
}
