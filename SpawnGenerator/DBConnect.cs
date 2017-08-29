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

        public string Rate { get; set; } // MeleeBaseAttackTime/RangedBaseAttackTime
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
            connection.Open();
            return true;
        }

        private bool CloseConnection()
        {
            connection.Close();
            return true;
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
                        Rate = dataReader["MeleeBaseAttackTime"].ToString(),
                        DamageVariance = dataReader["DamageVariance"].ToString(),
                        DamageSchool = dataReader["DamageSchool"].ToString(),
                        ResistanceArcane = dataReader["ResistanceArcane"].ToString(),
                        ResistanceFire = dataReader["ResistanceFire"].ToString(),
                        ResistanceNature = dataReader["ResistanceNature"].ToString(),
                        ResistanceFrost = dataReader["ResistanceFrost"].ToString(),
                        ResistanceShadow = dataReader["ResistanceShadow"].ToString(),
                        MechanicImmuneMask = dataReader["MechanicImmuneMask"].ToString(),
                        SchoolImmuneMask = dataReader["SchoolImmuneMask"].ToString(),
                        Leash = dataReader["LeashRange"].ToString(),
                        Family = dataReader["Family"].ToString(),
                        SpeedWalk = dataReader["SpeedWalk"].ToString(),
                        SpeedRun = dataReader["SpeedRun"].ToString(),
                        MovementType = dataReader["MovementType"].ToString(),
                        Faction = dataReader["FactionAlliance"].ToString(),
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
