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
    public partial class frm_questEmotes : Form
    {
        private List<Quest> quests = new List<Quest>();
        PacketFiltering filter = new PacketFiltering();
        public frm_questEmotes()
        {
            InitializeComponent();
        }

        struct QuestPacket
        {
            public string Entry;
            public string Method;
            public string ZoneOrSort;
            public string MinLevel;
            public string QuestLevel;
            public string Type;

            public string RequiredClasses;
            public string RequiredRaces;
            public string RequiredSkill;
            public string RequiredSkillValue;
            public string RequiredCondition;
            public string RepObjectiveFaction;
            public string RepObjectiveValue;
            public string RequiredMinRepFaction;
            public string RequiredMinRepValue;
            public string RequiredMaxRepFaction;
            public string RequiredMaxRepValue;

            public string SuggestedPlayers;
            public string LimitTime;
            public string QuestFlags;
            public string SpecialFlags;
            public string CharTitleId;

            public string PrevQuestId;
            public string NextQuestId;
            public string ExclusiveGroup;
            public string NextQuestInChain;

            public string SrcItemId;
            public string SrcItemCount;
            public string SrcSpell;

            public string Title;
            public string Details;
            public string Objectives;
            public string OfferRewardText;
            public string RequestItemsText;
            public string EndText;
            public string ObjectiveText1;
            public string ObjectiveText2;
            public string ObjectiveText3;
            public string ObjectiveText4;

            public string ReqItemId1;
            public string ReqItemId2;
            public string ReqItemId3;
            public string ReqItemId4;
            public string ReqItemCount1;
            public string ReqItemCount2;
            public string ReqItemCount3;
            public string ReqItemCount4;

            public string ReqSourceId1;
            public string ReqSourceId2;
            public string ReqSourceId3;
            public string ReqSourceId4;
            public string ReqSourceCount1;
            public string ReqSourceCount2;
            public string ReqSourceCount3;
            public string ReqSourceCount4;

            public string ReqCreatureOrGOId1;
            public string ReqCreatureOrGOId2;
            public string ReqCreatureOrGOId3;
            public string ReqCreatureOrGOId4;
            public string ReqCreatureOrGOCount1;
            public string ReqCreatureOrGOCount2;
            public string ReqCreatureOrGOCount3;
            public string ReqCreatureOrGOCount4;

            public string ReqSpellCast1;
            public string ReqSpellCast2;
            public string ReqSpellCast3;
            public string ReqSpellCast4;

            public string RewChoiceItemId1;
            public string RewChoiceItemId2;
            public string RewChoiceItemId3;
            public string RewChoiceItemId4;
            public string RewChoiceItemId5;
            public string RewChoiceItemId6;
            public string RewChoiceItemCount1;
            public string RewChoiceItemCount2;
            public string RewChoiceItemCount3;
            public string RewChoiceItemCount4;
            public string RewChoiceItemCount5;
            public string RewChoiceItemCount6;

            public string RewItemId1;
            public string RewItemId2;
            public string RewItemId3;
            public string RewItemId4;
            public string RewItemCount1;
            public string RewItemCount2;
            public string RewItemCount3;
            public string RewItemCount4;

            public string RewRepFaction1;
            public string RewRepFaction2;
            public string RewRepFaction3;
            public string RewRepFaction4;
            public string RewRepFaction5;
            public string RewRepValue1;
            public string RewRepValue2;
            public string RewRepValue3;
            public string RewRepValue4;
            public string RewRepValue5;
            public string RewMaxRepValue1;
            public string RewMaxRepValue2;
            public string RewMaxRepValue3;
            public string RewMaxRepValue4;
            public string RewMaxRepValue5;

            public string RewHonorableKills;
            public string RewOrReqMoney;
            public string RewMoneyMaxLevel;
            public string RewSpell;
            public string RewSpellCast;
            public string RewMailTemplateId;
            public string RewMailDelaySecs;

            public string PointMapId;
            public string PointX;
            public string PointY;
            public string PointOpt;

            public string DetailsEmote1;
            public string DetailsEmote2;
            public string DetailsEmote3;
            public string DetailsEmote4;
            public string DetailsEmoteDelay1;
            public string DetailsEmoteDelay2;
            public string DetailsEmoteDelay3;
            public string DetailsEmoteDelay4;

            public string IncompleteEmote;
            public string IncompleteEmoteDelay;

            public string CompleteEmote;
            public string CompleteEmoteDelay;

            public string OfferRewardEmote1;
            public string OfferRewardEmote2;
            public string OfferRewardEmote3;
            public string OfferRewardEmote4;
            public string OfferRewardEmoteDelay1;
            public string OfferRewardEmoteDelay2;
            public string OfferRewardEmoteDelay3;
            public string OfferRewardEmoteDelay4;

            public string StartScript;
            public string CompleteScript;
        }

        private void LoadQuests()
        {
            string host = Properties.Settings.Default.Host;
            string database = Properties.Settings.Default.Database;
            string user = Properties.Settings.Default.User;
            string password = Properties.Settings.Default.Password;
            string port = Properties.Settings.Default.Port;
            DBConnect connect = new DBConnect(host, database, user, password, port);
            quests = connect.GetQuests();
        }

        private void btn_loadFile_Click(object sender, EventArgs e)
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
                btn_loadFile.Enabled = false;
                btn_loadFile.Text = "Loading...";
                List<QuestPacket> questPacketsToCompare = new List<QuestPacket>();

                foreach (String file in openFileDialog.FileNames)
                {
                    List<string> filterList = new List<string>(new string[] { "SMSG_QUESTGIVER_QUEST_DETAILS", "SMSG_QUESTGIVER_REQUEST_ITEMS", "SMSG_QUESTGIVER_OFFER_REWARD" });
                    questPacketsToCompare.AddRange(GetMassUpdate(filter.FilterSniffFile(file, false, filterList)));
                }
                CompareMassUppdate(questPacketsToCompare);

                btn_loadFile.Enabled = true;
                btn_loadFile.Text = "Load File(s)";
            }
            else
            {
                // This code runs if the dialog was cancelled
                return;
            }

            //addedEntries.Clear();
            //addedModels.Clear();
        }

        private List<QuestPacket> GetMassUpdate(List<string> filteredPackets)
        {
            var lines = filteredPackets;
            bool udbSniff = false;

            QuestPacket sniff = new QuestPacket();
            List<QuestPacket> questPackets = new List<QuestPacket>();

            // SMSG_QUESTGIVER_QUEST_DETAILS
            sniff.Entry = "-1";
            sniff.Title = "-1";
            sniff.Details = "-1";
            sniff.Objectives = "-1";

            sniff.DetailsEmote1 = "-1";
            sniff.DetailsEmote2 = "-1";
            sniff.DetailsEmote3 = "-1";
            sniff.DetailsEmote4 = "-1";
            sniff.DetailsEmoteDelay1 = "-1";
            sniff.DetailsEmoteDelay2 = "-1";
            sniff.DetailsEmoteDelay3 = "-1";
            sniff.DetailsEmoteDelay4 = "-1";

            // SMSG_QUESTGIVER_REQUEST_ITEMS
            sniff.IncompleteEmote = "-1";
            sniff.IncompleteEmoteDelay = "-1";

            sniff.CompleteEmote = "-1";
            sniff.CompleteEmoteDelay = "-1";

            // SMSG_QUESTGIVER_OFFER_REWARD
            // Can also add quest flags, spells and titles here
            sniff.OfferRewardText = "-1";

            sniff.OfferRewardEmote1 = "-1";
            sniff.OfferRewardEmote2 = "-1";
            sniff.OfferRewardEmote3 = "-1";
            sniff.OfferRewardEmote4 = "-1";
            sniff.OfferRewardEmoteDelay1 = "-1";
            sniff.OfferRewardEmoteDelay2 = "-1";
            sniff.OfferRewardEmoteDelay3 = "-1";
            sniff.OfferRewardEmoteDelay4 = "-1";

            // SMSG_QUEST_QUERY_RESPONSE
            // EndText here (and maybe move other texts while at it)

            if (lines[0] == "# UDBParser") // Packets are differently structured in Trinity sniffs so separate them
                udbSniff = true;

            for (int i = 0; i < lines.Count; i++)
            {
                if (udbSniff)
                {
                    if (lines[i].Contains("SMSG_QUESTGIVER_QUEST_DETAILS"))
                    {
                        do
                        {
                            i++;

                            // Entry
                            if (lines[i].Contains("Quest ID:") && sniff.Entry == "-1")
                            {
                                string[] line = lines[i].Split(' ');
                                sniff.Entry = line[2];
                            }

                            // Title
                            if (lines[i].Contains("Title:") && sniff.Title == "-1")
                            {
                                string line = lines[i];
                                line = line.TrimStart('T');
                                line = line.TrimStart('i');
                                line = line.TrimStart('t');
                                line = line.TrimStart('l');
                                line = line.TrimStart('e');
                                line = line.TrimStart(':');
                                line = line.TrimStart(' ');
                                sniff.Title = line;
                            }

                            // Details
                            if (lines[i].Contains("Details:") && sniff.Details == "-1")
                            {
                                string line = lines[i];
                                line = line.TrimStart('D');
                                line = line.TrimStart('e');
                                line = line.TrimStart('t');
                                line = line.TrimStart('a');
                                line = line.TrimStart('i');
                                line = line.TrimStart('l');
                                line = line.TrimStart('s');
                                line = line.TrimStart(':');
                                line = line.TrimStart(' ');
                                sniff.Details = line;
                            }

                            // Objectives
                            if (lines[i].Contains("Objectives:") && sniff.Objectives == "-1")
                            {
                                string line = lines[i];
                                line = line.TrimStart('O');
                                line = line.TrimStart('b');
                                line = line.TrimStart('j');
                                line = line.TrimStart('e');
                                line = line.TrimStart('c');
                                line = line.TrimStart('t');
                                line = line.TrimStart('i');
                                line = line.TrimStart('v');
                                line = line.TrimStart('e');
                                line = line.TrimStart('s');
                                line = line.TrimStart(':');
                                line = line.TrimStart(' ');
                                sniff.Objectives = line;
                            }

                            // DetailsEmote1
                            if (lines[i].Contains("[0] Emote Id:") && sniff.DetailsEmote1 == "-1")
                            {
                                string[] line = lines[i].Split(' ');
                                sniff.DetailsEmote1 = line[3];
                            }
                            // DetailsEmoteDelay1
                            if (lines[i].Contains("[0] Emote Delay (ms):") && sniff.DetailsEmoteDelay1 == "-1")
                            {
                                string[] line = lines[i].Split(' ');
                                sniff.DetailsEmoteDelay1 = line[4];
                            }

                            // DetailsEmote2
                            if (lines[i].Contains("[1] Emote Id:") && sniff.DetailsEmote2 == "-1")
                            {
                                string[] line = lines[i].Split(' ');
                                sniff.DetailsEmote2 = line[3];
                            }
                            // DetailsEmoteDelay2
                            if (lines[i].Contains("[1] Emote Delay (ms):") && sniff.DetailsEmoteDelay2 == "-1")
                            {
                                string[] line = lines[i].Split(' ');
                                sniff.DetailsEmoteDelay2 = line[4];
                            }

                            // DetailsEmote3
                            if (lines[i].Contains("[2] Emote Id:") && sniff.DetailsEmote3 == "-1")
                            {
                                string[] line = lines[i].Split(' ');
                                sniff.DetailsEmote3 = line[3];
                            }
                            // DetailsEmoteDelay3
                            if (lines[i].Contains("[2] Emote Delay (ms):") && sniff.DetailsEmoteDelay3 == "-1")
                            {
                                string[] line = lines[i].Split(' ');
                                sniff.DetailsEmoteDelay3 = line[4];
                            }
                            // DetailsEmote4
                            if (lines[i].Contains("[3] Emote Id:") && sniff.DetailsEmote4 == "-1")
                            {
                                string[] line = lines[i].Split(' ');
                                sniff.DetailsEmote4 = line[3];
                            }
                            // DetailsEmoteDelay4
                            if (lines[i].Contains("[3] Emote Delay (ms):") && sniff.DetailsEmoteDelay4 == "-1")
                            {
                                string[] line = lines[i].Split(' ');
                                sniff.DetailsEmoteDelay4 = line[4];
                            }
                        } while (lines[i + 1] != "");

                        // Does quest exist in DB
                        Quest result = quests.Find(a => a.Entry == sniff.Entry);
                        if (result == null)
                            sniff.Entry = "-1";

                        if (sniff.Entry != "-1")
                        {
                            QuestPacket updatePacket = questPackets.Find(item => item.Entry == sniff.Entry);
                            // Was update already added
                            //if (!questPackets.Contains(sniff)) // New entry, so just add it as a whole
                            if (updatePacket.Entry != sniff.Entry)
                            {
                                questPackets.Add(sniff);
                            }
                            else // Entry already exists in list, so need to update each value individually
                            {
                                updatePacket.Title = sniff.Title;
                                updatePacket.Details = sniff.Details;
                                updatePacket.Objectives = sniff.Objectives;

                                updatePacket.DetailsEmote1 = sniff.DetailsEmote1;
                                updatePacket.DetailsEmote2 = sniff.DetailsEmote2;
                                updatePacket.DetailsEmote3 = sniff.DetailsEmote3;
                                updatePacket.DetailsEmote4 = sniff.DetailsEmote4;

                                updatePacket.DetailsEmoteDelay1 = sniff.DetailsEmoteDelay1;
                                updatePacket.DetailsEmoteDelay2 = sniff.DetailsEmoteDelay2;
                                updatePacket.DetailsEmoteDelay3 = sniff.DetailsEmoteDelay3;
                                updatePacket.DetailsEmoteDelay4 = sniff.DetailsEmoteDelay4;

                                questPackets.RemoveAt(questPackets.FindIndex(a => a.Entry == sniff.Entry));
                                questPackets.Add(updatePacket);
                            }
                        }
                        #region reset
                        sniff.Entry = "-1";
                        sniff.Title = "-1";
                        sniff.Details = "-1";
                        sniff.Objectives = "-1";

                        sniff.DetailsEmote1 = "-1";
                        sniff.DetailsEmote2 = "-1";
                        sniff.DetailsEmote3 = "-1";
                        sniff.DetailsEmote4 = "-1";

                        sniff.DetailsEmoteDelay1 = "-1";
                        sniff.DetailsEmoteDelay2 = "-1";
                        sniff.DetailsEmoteDelay3 = "-1";
                        sniff.DetailsEmoteDelay4 = "-1";
                        #endregion
                    }
                }
                else
                {

                }

            }
            return questPackets;
        }

        private void CompareMassUppdate(List<QuestPacket> questPackets)
        {
            foreach (QuestPacket sniff in questPackets)
            {
                bool questValueToUpdate = false;

                Quest result = quests.Find(a => a.Entry == sniff.Entry);

                if (result == null)
                    continue;

                string titleString = (sniff.Title != "-1" ? (sniff.Title != result.Title ? " Title=" + sniff.Title : "") : "");
                string detailsString = (sniff.Details != "-1" ? (sniff.Details != result.Details ? " Details=" + sniff.Details : "") : "");
                string objectivesString = (sniff.Objectives != "-1" ? (sniff.Objectives != result.Objectives ? " Objectives=" + sniff.Objectives : "") : "");

                string detailsEmote1String = (sniff.DetailsEmote1 != "-1" ? (sniff.DetailsEmote1 != result.DetailsEmote1 ? " DetailsEmote1=" + sniff.DetailsEmote1 : "") : "");
                string detailsEmote2String = (sniff.DetailsEmote2 != "-1" ? (sniff.DetailsEmote2 != result.DetailsEmote2 ? " DetailsEmote2=" + sniff.DetailsEmote2 : "") : "");
                string detailsEmote3String = (sniff.DetailsEmote3 != "-1" ? (sniff.DetailsEmote3 != result.DetailsEmote3 ? " DetailsEmote3=" + sniff.DetailsEmote3 : "") : "");
                string detailsEmote4String = (sniff.DetailsEmote4 != "-1" ? (sniff.DetailsEmote4 != result.DetailsEmote4 ? " DetailsEmote4=" + sniff.DetailsEmote4 : "") : "");

                string detailsEmoteDelay1String = (sniff.DetailsEmoteDelay1 != "-1" ? (sniff.DetailsEmoteDelay1 != result.DetailsEmoteDelay1 ? " DetailsEmoteDelay1=" + sniff.DetailsEmoteDelay1 : "") : "");
                string detailsEmoteDelay2String = (sniff.DetailsEmoteDelay2 != "-1" ? (sniff.DetailsEmoteDelay2 != result.DetailsEmoteDelay2 ? " DetailsEmoteDelay2=" + sniff.DetailsEmoteDelay2 : "") : "");
                string detailsEmoteDelay3String = (sniff.DetailsEmoteDelay3 != "-1" ? (sniff.DetailsEmoteDelay3 != result.DetailsEmoteDelay3 ? " DetailsEmoteDelay3=" + sniff.DetailsEmoteDelay3 : "") : "");
                string detailsEmoteDelay4String = (sniff.DetailsEmoteDelay4 != "-1" ? (sniff.DetailsEmoteDelay4 != result.DetailsEmoteDelay4 ? " DetailsEmoteDelay4=" + sniff.DetailsEmoteDelay4 : "") : "");



                if (titleString + detailsString + objectivesString +
                    detailsEmote1String + detailsEmote2String + detailsEmote3String + detailsEmote4String +
                    detailsEmoteDelay1String + detailsEmoteDelay2String + detailsEmoteDelay3String + detailsEmoteDelay4String != "")
                    questValueToUpdate = true;

                if (questValueToUpdate)
                {
                    string newOutput = "\n-- " + result.Title + " q." + result.Entry + "\nUPDATE quest_template SET";
                    string compareString = "\n-- " + result.Title + " q." + result.Entry + "\nUPDATE quest_template SET"; // To get commas placed right

                    if (titleString != "")
                        newOutput += titleString;
                    if (detailsString != "")
                        newOutput += newOutput == compareString ? detailsString : "," + detailsString;
                    if (objectivesString != "")
                        newOutput += newOutput == compareString ? objectivesString : "," + objectivesString;

                    if (detailsEmote1String != "")
                        newOutput += newOutput == compareString ? detailsEmote1String : "," + detailsEmote1String;
                    if (detailsEmote2String != "")
                        newOutput += newOutput == compareString ? detailsEmote2String : "," + detailsEmote2String;
                    if (detailsEmote3String != "")
                        newOutput += newOutput == compareString ? detailsEmote3String : "," + detailsEmote3String;
                    if (detailsEmote4String != "")
                        newOutput += newOutput == compareString ? detailsEmote4String : "," + detailsEmote4String;

                    if (detailsEmoteDelay1String != "")
                        newOutput += newOutput == compareString ? detailsEmoteDelay1String : "," + detailsEmoteDelay1String;
                    if (detailsEmoteDelay2String != "")
                        newOutput += newOutput == compareString ? detailsEmoteDelay2String : "," + detailsEmoteDelay2String;
                    if (detailsEmoteDelay3String != "")
                        newOutput += newOutput == compareString ? detailsEmoteDelay3String : "," + detailsEmoteDelay3String;
                    if (detailsEmoteDelay4String != "")
                        newOutput += newOutput == compareString ? detailsEmoteDelay4String : "," + detailsEmoteDelay4String;

                    newOutput += " WHERE entry=" + sniff.Entry + ";\n";

                    rtb_output.Text += newOutput;
                }
            }
        }

        private void frm_questEmotes_Load(object sender, EventArgs e)
        {
            try
            {
                LoadQuests();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
