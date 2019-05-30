using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SpawnGenerator
{
    class Creature : ICloneable
    {
        // Creature Template
        public string Entry { get; set; }
        public string Name { get; set; }
        public string Title { get; set; } // SubName
        public string CreatureType  { get; set; }
        public string Expansion { get; set; }
        public string Rank { get; set; }
        public string UnitClass { get; set; }
        public string MinLevel { get; set; }
        public string MaxLevel { get; set; }
        public string Family { get; set; }
        public string SpeedWalk { get; set; }
        public string SpeedRun { get; set; }
        public string MovementType { get; set; }
        public string Faction { get; set; }
        public string Scale { get; set; }
        public string ModelId1 { get; set; }
        public string ModelId2 { get; set; }
        public string ModelId3 { get; set; }
        public string ModelId4 { get; set; }
        public string NpcFlags { get; set; }
        public string UnitFlags { get; set; }
        public string DynamicFlags { get; set; }
        public string ExtraFlags { get; set; }
        public string CreatureTypeFlags { get; set; }
        public string LootId { get; set; }
        public string PickpocketLootId { get; set; }
        public string SkinningLootId { get; set; }
        public string EquipmentTemplateId { get; set; }
        public string GossipMenuId { get; set; }
        public string AIName { get; set; }
        public string ScriptName { get; set; }
        public string MinLootGold { get; set; }
        public string MaxLootGold { get; set; }
        public string InhabitType { get; set; }
        public string RegenerateStats { get; set; }

        public string HealthMultiplier { get; set; }
        public string ManaMultiplier { get; set; } // PowerMultiplier
        public string DamageMultiplier { get; set; }
        public string ExperienceMultiplier { get; set; }
        public string ArmorMultiplier { get; set; }

        public string MeleeBaseAttackTime { get; set; }
        public string RangedBaseAttackTime { get; set; }
        public string RacialLeader { get; set; }
        public string DamageVariance { get; set; }
        public string DamageSchool { get; set; }

        public string Leash { get; set; }
        public string MechanicImmuneMask { get; set; }
        public string SchoolImmuneMask { get; set; }

        public string ResistanceArcane { get; set; }
        public string ResistanceFire { get; set; }
        public string ResistanceNature { get; set; }
        public string ResistanceFrost { get; set; }
        public string ResistanceShadow { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    class Model : ICloneable
    {
        public string ModelId { get; set; }
        public string Bounding_radius { get; set; }
        public string Combat_reach { get; set; }
        public string SpeedWalk { get; set; }
        public string SpeedRun { get; set; }
        public string Gender { get; set; }
        public string Modelid_other_gender { get; set; }
        public string Modelid_alternative { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    class Gossip : ICloneable
    {
        public string Entry { get; set; }
        public string MenuId { get; set; }
        public string TextId { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }


    class Quest : ICloneable
    {
        public string Entry { get; set; }
        public string Method { get; set; }
        public string ZoneOrSort { get; set; }
        public string MinLevel { get; set; }
        public string QuestLevel { get; set; }
        public string Type { get; set; }

        public string RequiredClasses { get; set; }
        public string RequiredRaces { get; set; }
        public string RequiredSkill { get; set; }
        public string RequiredSkillValue { get; set; }
        public string RequiredCondition { get; set; }
        public string RepObjectiveFaction { get; set; }
        public string RepObjectiveValue { get; set; }
        public string RequiredMinRepFaction { get; set; }
        public string RequiredMinRepValue { get; set; }
        public string RequiredMaxRepFaction { get; set; }
        public string RequiredMaxRepValue { get; set; }

        public string SuggestedPlayers { get; set; }
        public string LimitTime { get; set; }
        public string QuestFlags { get; set; }
        public string SpecialFlags { get; set; }
        public string CharTitleId { get; set; }

        public string PrevQuestId { get; set; }
        public string NextQuestId { get; set; }
        public string ExclusiveGroup { get; set; }
        public string NextQuestInChain { get; set; }

        public string SrcItemId { get; set; }
        public string SrcItemCount { get; set; }
        public string SrcSpell { get; set; }

        public string Title { get; set; }
        public string Details { get; set; }
        public string Objectives { get; set; }
        public string OfferRewardText { get; set; }
        public string RequestItemsText { get; set; }
        public string EndText { get; set; }
        public string ObjectiveText1 { get; set; }
        public string ObjectiveText2 { get; set; }
        public string ObjectiveText3 { get; set; }
        public string ObjectiveText4 { get; set; }

        public string ReqItemId1 { get; set; }
        public string ReqItemId2 { get; set; }
        public string ReqItemId3 { get; set; }
        public string ReqItemId4 { get; set; }
        public string ReqItemCount1 { get; set; }
        public string ReqItemCount2 { get; set; }
        public string ReqItemCount3 { get; set; }
        public string ReqItemCount4 { get; set; }

        public string ReqSourceId1 { get; set; }
        public string ReqSourceId2 { get; set; }
        public string ReqSourceId3 { get; set; }
        public string ReqSourceId4 { get; set; }
        public string ReqSourceCount1 { get; set; }
        public string ReqSourceCount2 { get; set; }
        public string ReqSourceCount3 { get; set; }
        public string ReqSourceCount4 { get; set; }

        public string ReqCreatureOrGOId1 { get; set; }
        public string ReqCreatureOrGOId2 { get; set; }
        public string ReqCreatureOrGOId3 { get; set; }
        public string ReqCreatureOrGOId4 { get; set; }
        public string ReqCreatureOrGOCount1 { get; set; }
        public string ReqCreatureOrGOCount2 { get; set; }
        public string ReqCreatureOrGOCount3 { get; set; }
        public string ReqCreatureOrGOCount4 { get; set; }

        public string ReqSpellCast1 { get; set; }
        public string ReqSpellCast2 { get; set; }
        public string ReqSpellCast3 { get; set; }
        public string ReqSpellCast4 { get; set; }

        public string RewChoiceItemId1 { get; set; }
        public string RewChoiceItemId2 { get; set; }
        public string RewChoiceItemId3 { get; set; }
        public string RewChoiceItemId4 { get; set; }
        public string RewChoiceItemId5 { get; set; }
        public string RewChoiceItemId6 { get; set; }
        public string RewChoiceItemCount1 { get; set; }
        public string RewChoiceItemCount2 { get; set; }
        public string RewChoiceItemCount3 { get; set; }
        public string RewChoiceItemCount4 { get; set; }
        public string RewChoiceItemCount5 { get; set; }
        public string RewChoiceItemCount6 { get; set; }

        public string RewItemId1 { get; set; }
        public string RewItemId2 { get; set; }
        public string RewItemId3 { get; set; }
        public string RewItemId4 { get; set; }
        public string RewItemCount1 { get; set; }
        public string RewItemCount2 { get; set; }
        public string RewItemCount3 { get; set; }
        public string RewItemCount4 { get; set; }

        public string RewRepFaction1 { get; set; }
        public string RewRepFaction2 { get; set; }
        public string RewRepFaction3 { get; set; }
        public string RewRepFaction4 { get; set; }
        public string RewRepFaction5 { get; set; }
        public string RewRepValue1 { get; set; }
        public string RewRepValue2 { get; set; }
        public string RewRepValue3 { get; set; }
        public string RewRepValue4 { get; set; }
        public string RewRepValue5 { get; set; }
        public string RewMaxRepValue1 { get; set; }
        public string RewMaxRepValue2 { get; set; }
        public string RewMaxRepValue3 { get; set; }
        public string RewMaxRepValue4 { get; set; }
        public string RewMaxRepValue5 { get; set; }

        public string RewHonorableKills { get; set; }
        public string RewOrReqMoney { get; set; }
        public string RewMoneyMaxLevel { get; set; }
        public string RewSpell { get; set; }
        public string RewSpellCast { get; set; }
        public string RewMailTemplateId { get; set; }
        public string RewMailDelaySecs { get; set; }

        public string PointMapId { get; set; }
        public string PointX { get; set; }
        public string PointY { get; set; }
        public string PointOpt { get; set; }

        public string DetailsEmote1 { get; set; }
        public string DetailsEmote2 { get; set; }
        public string DetailsEmote3 { get; set; }
        public string DetailsEmote4 { get; set; }
        public string DetailsEmoteDelay1 { get; set; }
        public string DetailsEmoteDelay2 { get; set; }
        public string DetailsEmoteDelay3 { get; set; }
        public string DetailsEmoteDelay4 { get; set; }

        public string IncompleteEmote { get; set; }
        public string IncompleteEmoteDelay { get; set; }

        public string CompleteEmote { get; set; }
        public string CompleteEmoteDelay { get; set; }

        public string OfferRewardEmote1 { get; set; }
        public string OfferRewardEmote2 { get; set; }
        public string OfferRewardEmote3 { get; set; }
        public string OfferRewardEmote4 { get; set; }
        public string OfferRewardEmoteDelay1 { get; set; }
        public string OfferRewardEmoteDelay2 { get; set; }
        public string OfferRewardEmoteDelay3 { get; set; }
        public string OfferRewardEmoteDelay4 { get; set; }

        public string StartScript { get; set; }
        public string CompleteScript { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    class GossipMenuOption : ICloneable
    {
        public string Entry { get; set; }
        public string MenuId { get; set; }
        public string Id { get; set; }
        public string OptionIcon { get; set; }
        public string OptionNPCFlag { get; set; }
        public string BoxMoney { get; set; }
        public string OptionText { get; set; }
        public string BoxText { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string port;

        public DBConnect(string serv, string db, string u, string pw, string pt)
        {
            server = serv;
            database = db;
            uid = u;
            password = pw;
            port = pt;

            Initialize();
        }

        private void Initialize()
        {
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "PORT=" + port + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection to Database failed! Please check your login credentials! You may need to reload the form to prevent loading issues.");
                return false;
                throw;
            }
            return true;
        }

        private bool CloseConnection()
        {
            connection.Close();
            return true;
        }

        public int RunQuery(string query)
        {
            int affectedRows = 0;
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            if (OpenConnection())
            {
                affectedRows = command.ExecuteNonQuery();
                CloseConnection();
            }
            return affectedRows;
        }

        public List<Gossip> GetGossip()
        {
            string query = "SELECT * FROM gossip_menu";

            List<Gossip> gossips = new List<Gossip>();

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Gossip m = new Gossip()
                    {
                        MenuId = dataReader["entry"].ToString(),
                        TextId = dataReader["text_id"].ToString(),
                    };
                    gossips.Add(m);
                }

                dataReader.Close();
                CloseConnection();
            }
            return gossips;
        }

        public List<GossipMenuOption> GetGossipMenuOptions()
        {
            string query = "SELECT * FROM gossip_menu_option";

            List<GossipMenuOption> gossips = new List<GossipMenuOption>();

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    GossipMenuOption m = new GossipMenuOption()
                    {
                        MenuId = dataReader["menu_id"].ToString(),
                        OptionText = dataReader["option_text"].ToString(),
                    };
                    gossips.Add(m);
                }

                dataReader.Close();
                CloseConnection();
            }
            return gossips;
        }

        public List<Model> GetModels()
        {
            string query = "SELECT * FROM creature_model_info";

            List<Model> models = new List<Model>();

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Model m = new Model()
                    {
                        ModelId = dataReader["modelid"].ToString(),
                        Bounding_radius = dataReader["bounding_radius"].ToString(),
                        Combat_reach = dataReader["combat_reach"].ToString(),
                        SpeedWalk = dataReader["SpeedWalk"].ToString(),
                        SpeedRun = dataReader["SpeedRun"].ToString(),
                        Gender = dataReader["gender"].ToString(),
                        Modelid_other_gender = dataReader["modelid_other_gender"].ToString(),
                        Modelid_alternative = dataReader["modelid_alternative"].ToString(),
                    };
                    models.Add(m);
                }

                dataReader.Close();
                CloseConnection();
            }
            return models;
        }
        public List<Creature> GetCreatures()
        {
            string query = "SELECT * FROM creature_template";
            
            List<Creature> creatures = new List<Creature>();

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                
                while (dataReader.Read())
                {
                    Creature c = new Creature()
                    {
                        Entry = dataReader["Entry"].ToString(),
                        Name = dataReader["Name"].ToString(),
                        Title = dataReader["SubName"].ToString(),
                        CreatureType = dataReader["CreatureType"].ToString(),
                        Expansion = dataReader["Expansion"].ToString(),
                        Rank = dataReader["Rank"].ToString(),
                        UnitClass = dataReader["UnitClass"].ToString(),
                        MinLevel = dataReader["MinLevel"].ToString(),
                        MaxLevel = dataReader["MaxLevel"].ToString(),
                        HealthMultiplier = dataReader["HealthMultiplier"].ToString(),
                        ManaMultiplier = dataReader["PowerMultiplier"].ToString(),
                        DamageMultiplier = dataReader["DamageMultiplier"].ToString(),
                        ArmorMultiplier = dataReader["ArmorMultiplier"].ToString(),
                        ExperienceMultiplier = dataReader["ExperienceMultiplier"].ToString(),
                        MeleeBaseAttackTime = dataReader["MeleeBaseAttackTime"].ToString(),
                        RangedBaseAttackTime = dataReader["RangedBaseAttackTime"].ToString(),
                        RacialLeader = dataReader["RacialLeader"].ToString(),
                        DamageVariance = dataReader["DamageVariance"].ToString(),
                        DamageSchool = dataReader["DamageSchool"].ToString(),
                        ResistanceArcane = dataReader["ResistanceArcane"].ToString(),
                        ResistanceFire = dataReader["ResistanceFire"].ToString(),
                        ResistanceNature = dataReader["ResistanceNature"].ToString(),
                        ResistanceFrost = dataReader["ResistanceFrost"].ToString(),
                        ResistanceShadow = dataReader["ResistanceShadow"].ToString(),
                        MechanicImmuneMask = dataReader["MechanicImmuneMask"].ToString(),
                        SchoolImmuneMask = dataReader["SchoolImmuneMask"].ToString(),
                        Leash = "",
                        Family = dataReader["Family"].ToString(),
                        SpeedWalk = dataReader["SpeedWalk"].ToString(),
                        SpeedRun = dataReader["SpeedRun"].ToString(),
                        MovementType = dataReader["MovementType"].ToString(),
                        Faction = dataReader["Faction"].ToString(),
                        Scale = dataReader["Scale"].ToString(),
                        ModelId1 = dataReader["ModelId1"].ToString(),
                        ModelId2 = dataReader["ModelId2"].ToString(),
                        ModelId3 = dataReader["ModelId3"].ToString(),
                        ModelId4 = dataReader["ModelId4"].ToString(),
                        AIName = dataReader["AIName"].ToString(),
                        ScriptName = dataReader["ScriptName"].ToString(),
                        CreatureTypeFlags = dataReader["CreatureTypeFlags"].ToString(),
                        DynamicFlags = dataReader["DynamicFlags"].ToString(),
                        EquipmentTemplateId = dataReader["EquipmentTemplateId"].ToString(),
                        ExtraFlags = dataReader["ExtraFlags"].ToString(),
                        GossipMenuId = dataReader["GossipMenuId"].ToString(),
                        LootId = dataReader["LootId"].ToString(),
                        NpcFlags = dataReader["NpcFlags"].ToString(),
                        PickpocketLootId = dataReader["PickpocketLootId"].ToString(),
                        SkinningLootId = dataReader["SkinningLootId"].ToString(),
                        UnitFlags = dataReader["UnitFlags"].ToString(),
                        MaxLootGold = dataReader["MaxLootGold"].ToString(),
                        MinLootGold = dataReader["MinLootGold"].ToString(),
                        InhabitType = dataReader["InhabitType"].ToString(),
                        RegenerateStats = dataReader["RegenerateStats"].ToString(),
                    };
                    creatures.Add(c);
                }
                
                dataReader.Close();
                CloseConnection();
            }

            return creatures;
        }

        public List<Quest> GetQuests()
        {
            string query = "SELECT * FROM quest_template";

            List<Quest> quests = new List<Quest>();

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Quest qc = new Quest()
                    {
                        Entry = dataReader["entry"].ToString(),
                        Method = dataReader["Method"].ToString(),
                        ZoneOrSort = dataReader["ZoneOrSort"].ToString(),
                        MinLevel = dataReader["MinLevel"].ToString(),
                        QuestLevel = dataReader["QuestLevel"].ToString(),
                        Type = dataReader["Type"].ToString(),

                        RequiredClasses = dataReader["RequiredClasses"].ToString(),
                        RequiredRaces = dataReader["RequiredRaces"].ToString(),
                        RequiredSkill = dataReader["RequiredSkill"].ToString(),
                        RequiredSkillValue = dataReader["RequiredSkillValue"].ToString(),
                        RequiredCondition = dataReader["RequiredCondition"].ToString(),
                        RepObjectiveFaction = dataReader["RepObjectiveFaction"].ToString(),
                        RepObjectiveValue = dataReader["RepObjectiveValue"].ToString(),
                        RequiredMinRepFaction = dataReader["RequiredMinRepFaction"].ToString(),
                        RequiredMinRepValue = dataReader["RequiredMinRepValue"].ToString(),
                        RequiredMaxRepFaction = dataReader["RequiredMaxRepFaction"].ToString(),
                        RequiredMaxRepValue = dataReader["RequiredMaxRepValue"].ToString(),

                        SuggestedPlayers = dataReader["SuggestedPlayers"].ToString(),
                        LimitTime = dataReader["LimitTime"].ToString(),
                        QuestFlags = dataReader["QuestFlags"].ToString(),
                        SpecialFlags = dataReader["SpecialFlags"].ToString(),
                        CharTitleId = dataReader["CharTitleId"].ToString(),

                        PrevQuestId = dataReader["PrevQuestId"].ToString(),
                        NextQuestId = dataReader["NextQuestId"].ToString(),
                        ExclusiveGroup = dataReader["ExclusiveGroup"].ToString(),
                        NextQuestInChain = dataReader["NextQuestInChain"].ToString(),

                        SrcItemId = dataReader["SrcItemId"].ToString(),
                        SrcItemCount = dataReader["SrcItemCount"].ToString(),
                        SrcSpell = dataReader["SrcSpell"].ToString(),

                        Title = dataReader["Title"].ToString(),
                        Details = dataReader["Details"].ToString(),
                        Objectives = dataReader["Objectives"].ToString(),
                        OfferRewardText = dataReader["OfferRewardText"].ToString(),
                        RequestItemsText = dataReader["RequestItemsText"].ToString(),
                        EndText = dataReader["EndText"].ToString(),
                        ObjectiveText1 = dataReader["ObjectiveText1"].ToString(),
                        ObjectiveText2 = dataReader["ObjectiveText2"].ToString(),
                        ObjectiveText3 = dataReader["ObjectiveText3"].ToString(),
                        ObjectiveText4 = dataReader["ObjectiveText4"].ToString(),

                        ReqItemId1 = dataReader["ReqItemId1"].ToString(),
                        ReqItemId2 = dataReader["ReqItemId2"].ToString(),
                        ReqItemId3 = dataReader["ReqItemId3"].ToString(),
                        ReqItemId4 = dataReader["ReqItemId4"].ToString(),
                        ReqItemCount1 = dataReader["ReqItemCount1"].ToString(),
                        ReqItemCount2 = dataReader["ReqItemCount2"].ToString(),
                        ReqItemCount3 = dataReader["ReqItemCount3"].ToString(),
                        ReqItemCount4 = dataReader["ReqItemCount4"].ToString(),

                        ReqSourceId1 = dataReader["ReqSourceId1"].ToString(),
                        ReqSourceId2 = dataReader["ReqSourceId2"].ToString(),
                        ReqSourceId3 = dataReader["ReqSourceId3"].ToString(),
                        ReqSourceId4 = dataReader["ReqSourceId4"].ToString(),
                        ReqSourceCount1 = dataReader["ReqSourceCount1"].ToString(),
                        ReqSourceCount2 = dataReader["ReqSourceCount2"].ToString(),
                        ReqSourceCount3 = dataReader["ReqSourceCount3"].ToString(),
                        ReqSourceCount4 = dataReader["ReqSourceCount4"].ToString(),

                        ReqCreatureOrGOId1 = dataReader["ReqCreatureOrGOId1"].ToString(),
                        ReqCreatureOrGOId2 = dataReader["ReqCreatureOrGOId2"].ToString(),
                        ReqCreatureOrGOId3 = dataReader["ReqCreatureOrGOId3"].ToString(),
                        ReqCreatureOrGOId4 = dataReader["ReqCreatureOrGOId4"].ToString(),
                        ReqCreatureOrGOCount1 = dataReader["ReqCreatureOrGOCount1"].ToString(),
                        ReqCreatureOrGOCount2 = dataReader["ReqCreatureOrGOCount2"].ToString(),
                        ReqCreatureOrGOCount3 = dataReader["ReqCreatureOrGOCount3"].ToString(),
                        ReqCreatureOrGOCount4 = dataReader["ReqCreatureOrGOCount4"].ToString(),

                        ReqSpellCast1 = dataReader["ReqSpellCast1"].ToString(),
                        ReqSpellCast2 = dataReader["ReqSpellCast2"].ToString(),
                        ReqSpellCast3 = dataReader["ReqSpellCast3"].ToString(),
                        ReqSpellCast4 = dataReader["ReqSpellCast4"].ToString(),

                        RewChoiceItemId1 = dataReader["RewChoiceItemId1"].ToString(),
                        RewChoiceItemId2 = dataReader["RewChoiceItemId2"].ToString(),
                        RewChoiceItemId3 = dataReader["RewChoiceItemId3"].ToString(),
                        RewChoiceItemId4 = dataReader["RewChoiceItemId4"].ToString(),
                        RewChoiceItemId5 = dataReader["RewChoiceItemId5"].ToString(),
                        RewChoiceItemId6 = dataReader["RewChoiceItemId6"].ToString(),
                        RewChoiceItemCount1 = dataReader["RewChoiceItemCount1"].ToString(),
                        RewChoiceItemCount2 = dataReader["RewChoiceItemCount2"].ToString(),
                        RewChoiceItemCount3 = dataReader["RewChoiceItemCount3"].ToString(),
                        RewChoiceItemCount4 = dataReader["RewChoiceItemCount4"].ToString(),
                        RewChoiceItemCount5 = dataReader["RewChoiceItemCount5"].ToString(),
                        RewChoiceItemCount6 = dataReader["RewChoiceItemCount6"].ToString(),

                        RewItemId1 = dataReader["RewItemId1"].ToString(),
                        RewItemId2 = dataReader["RewItemId2"].ToString(),
                        RewItemId3 = dataReader["RewItemId3"].ToString(),
                        RewItemId4 = dataReader["RewItemId4"].ToString(),
                        RewItemCount1 = dataReader["RewItemCount1"].ToString(),
                        RewItemCount2 = dataReader["RewItemCount2"].ToString(),
                        RewItemCount3 = dataReader["RewItemCount3"].ToString(),
                        RewItemCount4 = dataReader["RewItemCount4"].ToString(),

                        ReqSourceId1 = dataReader["ReqSourceId1"].ToString(),
                        ReqSourceId2 = dataReader["ReqSourceId2"].ToString(),
                        ReqSourceId3 = dataReader["ReqSourceId3"].ToString(),
                        ReqSourceId4 = dataReader["ReqSourceId4"].ToString(),
                        ReqSourceCount1 = dataReader["ReqSourceCount1"].ToString(),
                        ReqSourceCount2 = dataReader["ReqSourceCount2"].ToString(),
                        ReqSourceCount3 = dataReader["ReqSourceCount3"].ToString(),
                        ReqSourceCount4 = dataReader["ReqSourceCount4"].ToString(),

                        ReqCreatureOrGOId1 = dataReader["ReqCreatureOrGOId1"].ToString(),
                        ReqCreatureOrGOId2 = dataReader["ReqCreatureOrGOId2"].ToString(),
                        ReqCreatureOrGOId3 = dataReader["ReqCreatureOrGOId3"].ToString(),
                        ReqCreatureOrGOId4 = dataReader["ReqCreatureOrGOId4"].ToString(),
                        ReqCreatureOrGOCount1 = dataReader["ReqCreatureOrGOCount1"].ToString(),
                        ReqCreatureOrGOCount2 = dataReader["ReqCreatureOrGOCount2"].ToString(),
                        ReqCreatureOrGOCount3 = dataReader["ReqCreatureOrGOCount3"].ToString(),
                        ReqCreatureOrGOCount4 = dataReader["ReqCreatureOrGOCount4"].ToString(),

                        ReqSpellCast1 = dataReader["ReqSpellCast1"].ToString(),
                        ReqSpellCast2 = dataReader["ReqSpellCast2"].ToString(),
                        ReqSpellCast3 = dataReader["ReqSpellCast3"].ToString(),
                        ReqSpellCast4 = dataReader["ReqSpellCast4"].ToString(),

                        RewChoiceItemId1 = dataReader["RewChoiceItemId1"].ToString(),
                        RewChoiceItemId2 = dataReader["RewChoiceItemId2"].ToString(),
                        RewChoiceItemId3 = dataReader["RewChoiceItemId3"].ToString(),
                        RewChoiceItemId4 = dataReader["RewChoiceItemId4"].ToString(),
                        RewChoiceItemId5 = dataReader["RewChoiceItemId5"].ToString(),
                        RewChoiceItemId6 = dataReader["RewChoiceItemId6"].ToString(),
                        RewChoiceItemCount1 = dataReader["RewChoiceItemCount1"].ToString(),
                        RewChoiceItemCount2 = dataReader["RewChoiceItemCount2"].ToString(),
                        RewChoiceItemCount3 = dataReader["RewChoiceItemCount3"].ToString(),
                        RewChoiceItemCount4 = dataReader["RewChoiceItemCount4"].ToString(),
                        RewChoiceItemCount5 = dataReader["RewChoiceItemCount5"].ToString(),
                        RewChoiceItemCount6 = dataReader["RewChoiceItemCount6"].ToString(),

                        RewItemId1 = dataReader["RewItemId1"].ToString(),
                        RewItemId2 = dataReader["RewItemId2"].ToString(),
                        RewItemId3 = dataReader["RewItemId3"].ToString(),
                        RewItemId4 = dataReader["RewItemId4"].ToString(),
                        RewItemCount1 = dataReader["RewItemCount1"].ToString(),
                        RewItemCount2 = dataReader["RewItemCount2"].ToString(),
                        RewItemCount3 = dataReader["RewItemCount3"].ToString(),
                        RewItemCount4 = dataReader["RewItemCount4"].ToString(),

                        RewRepFaction1 = dataReader["RewRepFaction1"].ToString(),
                        RewRepFaction2 = dataReader["RewRepFaction2"].ToString(),
                        RewRepFaction3 = dataReader["RewRepFaction3"].ToString(),
                        RewRepFaction4 = dataReader["RewRepFaction4"].ToString(),
                        RewRepFaction5 = dataReader["RewRepFaction5"].ToString(),
                        RewRepValue1 = dataReader["RewRepValue1"].ToString(),
                        RewRepValue2 = dataReader["RewRepValue2"].ToString(),
                        RewRepValue3 = dataReader["RewRepValue3"].ToString(),
                        RewRepValue4 = dataReader["RewRepValue4"].ToString(),
                        RewRepValue5 = dataReader["RewRepValue5"].ToString(),
                        RewMaxRepValue1 = dataReader["RewMaxRepValue1"].ToString(),
                        RewMaxRepValue2 = dataReader["RewMaxRepValue2"].ToString(),
                        RewMaxRepValue3 = dataReader["RewMaxRepValue3"].ToString(),
                        RewMaxRepValue4 = dataReader["RewMaxRepValue4"].ToString(),
                        RewMaxRepValue5 = dataReader["RewMaxRepValue5"].ToString(),

                        RewHonorableKills = dataReader["RewHonorableKills"].ToString(),
                        RewOrReqMoney = dataReader["RewOrReqMoney"].ToString(),
                        RewMoneyMaxLevel = dataReader["RewMoneyMaxLevel"].ToString(),
                        RewSpell = dataReader["RewSpell"].ToString(),
                        RewSpellCast = dataReader["RewSpellCast"].ToString(),
                        RewMailTemplateId = dataReader["RewMailTemplateId"].ToString(),
                        RewMailDelaySecs = dataReader["RewMailDelaySecs"].ToString(),

                        PointMapId = dataReader["PointMapId"].ToString(),
                        PointX = dataReader["PointX"].ToString(),
                        PointY = dataReader["PointY"].ToString(),
                        PointOpt = dataReader["PointOpt"].ToString(),

                        DetailsEmote1 = dataReader["DetailsEmote1"].ToString(),
                        DetailsEmote2 = dataReader["DetailsEmote2"].ToString(),
                        DetailsEmote3 = dataReader["DetailsEmote3"].ToString(),
                        DetailsEmote4 = dataReader["DetailsEmote4"].ToString(),
                        DetailsEmoteDelay1 = dataReader["DetailsEmoteDelay1"].ToString(),
                        DetailsEmoteDelay2 = dataReader["DetailsEmoteDelay2"].ToString(),
                        DetailsEmoteDelay3 = dataReader["DetailsEmoteDelay3"].ToString(),
                        DetailsEmoteDelay4 = dataReader["DetailsEmoteDelay4"].ToString(),

                        IncompleteEmote = dataReader["IncompleteEmote"].ToString(),
                        IncompleteEmoteDelay = dataReader["IncompleteEmoteDelay"].ToString(),

                        CompleteEmote = dataReader["CompleteEmote"].ToString(),
                        CompleteEmoteDelay = dataReader["CompleteEmoteDelay"].ToString(),

                        OfferRewardEmote1 = dataReader["OfferRewardEmote1"].ToString(),
                        OfferRewardEmote2 = dataReader["OfferRewardEmote2"].ToString(),
                        OfferRewardEmote3 = dataReader["OfferRewardEmote3"].ToString(),
                        OfferRewardEmote4 = dataReader["OfferRewardEmote4"].ToString(),
                        OfferRewardEmoteDelay1 = dataReader["OfferRewardEmoteDelay1"].ToString(),
                        OfferRewardEmoteDelay2 = dataReader["OfferRewardEmoteDelay2"].ToString(),
                        OfferRewardEmoteDelay3 = dataReader["OfferRewardEmoteDelay3"].ToString(),
                        OfferRewardEmoteDelay4 = dataReader["OfferRewardEmoteDelay4"].ToString(),

                        StartScript = dataReader["StartScript"].ToString(),
                        CompleteScript = dataReader["CompleteScript"].ToString(),
                    };
                    quests.Add(q);
                }

                dataReader.Close();
                CloseConnection();
            }

            return quests;
        }
    }
}
