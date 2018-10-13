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
                        Faction = dataReader["FactionAlliance"].ToString(),
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
    }
}
