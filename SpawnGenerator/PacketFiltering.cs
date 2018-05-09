using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpawnGenerator
{
    class PacketFiltering
    {
        public enum Parser
        {
            Trinity = 0,
            UDB = 1
        }

        struct SpawnPacket
        {
            public string objectType;
            public string entry;
            public string guidLow;
            public string guidFull;
            public string x;
            public string y;
            public string z;
            public string o;
            public string r0;
            public string r1;
            public string r2;
            public string r3;
            public string map;
        };

        struct SpellPacket
        {
            public string spell;
            public string casterType;
            public string casterEntry;
            public string casterGuid;
            public string targetType;
            public string targetEntry;
            public string time;
        }

        struct SpeedPacket
        {
            public string entry;
            public string name;
            public string speedRun;
            public string speedWalk;
            public string unitFlags;
        }

        public List<string> FilterSniffFile(string fileName, bool blacklist, List<string> filterList, string[] fileNames = null)
        {
            string[] lines = null;

            if (fileName != null)
                lines = File.ReadAllLines(fileName);
            else
            {
                foreach (String file in fileNames)
                {
                    lines = File.ReadAllLines(file);
                }
            }

            string[] packets = new string[lines.Count()];
            List<string> newFileStrings = new List<string>();

            for (int i = 0; i < 7; i++) // Write the first lines without filtering
            {
                newFileStrings.Add(lines[i]);
            }

            // Add filter information
            newFileStrings.Add("# This sniff file was filtered using Saltgurka's sniff filterer.");
            newFileStrings.Add("# The following packets were " + (blacklist ? "BLACKLISTED:" : "WHITELISTED:"));
            newFileStrings.Add("--------------------------------");

            foreach (String s in filterList)
            {
                newFileStrings.Add(s);
            }

            newFileStrings.Add("--------------------------------");
            newFileStrings.Add("");

            if (blacklist) // Filter by blacklist
            {
                for (int i = 1; i < lines.Count(); i++)
                {
                    if (lines[i - 1] == (""))
                    {
                        if (!filterList.Any(s => lines[i].Contains(s)))
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
                for (int i = 1; i < lines.Count(); i++)
                {
                    if (lines[i - 1] == (""))
                    {
                        if (filterList.Any(s => lines[i].Contains(s)))
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

            return newFileStrings;
        }

        private List<SpawnPacket> GetSpawnData(string filename, bool onlyCreateObject2)
        {
            List<string> filterList = new List<string>(new string[] { "SMSG_UPDATE_OBJECT", "SMSG_COMPRESSED_UPDATE_OBJECT" });
            List<string> createObjectList = FilterSniffFile(filename, false, filterList);
            List<SpawnPacket> spawnPackets = new List<SpawnPacket>();

            var lines = createObjectList;
            string stringToSearchFor = onlyCreateObject2 ? "CreateObject2" : "CreateObject";

            SpawnPacket sniff;

            Parser parser = Parser.Trinity;

            if (lines[0].Contains("UDB"))
                parser = Parser.UDB;

            for (int i = 1; i < lines.Count; i++)
            {
                if (lines[i].Contains(stringToSearchFor))
                {
                    sniff.objectType = "";
                    sniff.entry = "";
                    sniff.guidLow = "";
                    sniff.guidFull = "";
                    sniff.x = "";
                    sniff.y = "";
                    sniff.z = "";
                    sniff.o = "";
                    sniff.r0 = "";
                    sniff.r1 = "";
                    sniff.r2 = "";
                    sniff.r3 = "";
                    sniff.map = "";

                    i++;

                    if (parser == Parser.Trinity)
                    {
                        string[] values = lines[i].Split(new char[] { ' ' });

                        //string[] objectType = values[5].Split(new char[] { '/' });

                        if (values.Length > 4)
                            sniff.guidFull = values[4];
                        if (values.Length > 5)
                            sniff.objectType = values[5];
                        if (values.Length > 8)
                            sniff.map = values[8];
                        if (values.Length > 10)
                            sniff.entry = values[10];
                        if (values.Length > 12)
                            sniff.guidLow = values[12];

                        do
                        {
                            i++;

                            if (lines[i].Contains("] Position: X:")) // Creature
                            {
                                string[] packetline = lines[i].Split(new char[] { ' ' });

                                sniff.x = packetline[3];
                                sniff.y = packetline[5];
                                sniff.z = packetline[7];

                                string[] orientationline = lines[i + 1].Split(new char[] { ' ' });
                                sniff.o = orientationline[2];
                            }
                            else if (lines[i].Contains("] Stationary Position: X:")) // Gameobject
                            {
                                string[] packetline = lines[i].Split(new char[] { ' ' });
                                sniff.x = packetline[4];
                                sniff.y = packetline[6];
                                sniff.z = packetline[8];

                                string[] orientationline = lines[i + 1].Split(new char[] { ' ' });

                                sniff.o = orientationline[3];

                                string[] rotationline = lines[i + 2].Split(new char[] { ' ' });

                                if (rotationline.Length > 10)
                                {
                                    sniff.r0 = rotationline[4];
                                    sniff.r1 = rotationline[6];
                                    sniff.r2 = rotationline[8];
                                    sniff.r3 = rotationline[10];
                                }
                            }
                            if (sniff.objectType != "Creature/0" && sniff.objectType != "Unit/0" && sniff.objectType != "GameObject/0")
                            {
                                sniff.entry = "";
                            }
                        } while (lines[i] != "" && !lines[i + 1].Contains("CreateObject"));
                    }
                    else if (parser == Parser.UDB)
                    {
                        string[] values = lines[i].Split(new char[] { ' ' });
                        string[] values2 = lines[i + 1].Split(new char[] { ' ' });

                        //string[] objectType = values[5].Split(new char[] { '/' });

                        if (values.Length > 3)
                            sniff.guidFull = values[3];
                        if (values2.Length > 3)
                            sniff.objectType = values2[3];
                        if (values.Length > 5)
                            sniff.guidLow = values[5];

                        do
                        {
                            i++;

                            if (lines[i].Contains("] Position: X:"))
                            {
                                string[] packetline = lines[i].Split(new char[] { ' ' });
                                if (packetline.Length == 8) // Creature
                                {
                                    sniff.x = packetline[3];
                                    sniff.y = packetline[5];
                                    sniff.z = packetline[7];
                                }
                                else // Gameobject
                                {
                                    sniff.x = packetline[4];
                                    sniff.y = packetline[6];
                                    sniff.z = packetline[8];
                                }

                                string[] orientationline = lines[i + 1].Split(new char[] { ' ' });
                                if (sniff.objectType == "Creature" || sniff.objectType == "Unit") // Creature
                                    sniff.o = orientationline[2];
                                else if (sniff.objectType == "GameObject") // Gameobject
                                {
                                    sniff.o = orientationline[3];

                                    string[] rotationline = lines[i + 2].Split(new char[] { ' ' });

                                    if (rotationline.Length > 10)
                                    {
                                        sniff.r0 = rotationline[4];
                                        sniff.r1 = rotationline[6];
                                        sniff.r2 = rotationline[8];
                                        sniff.r3 = rotationline[10];
                                    }
                                }
                            }

                            if (lines[i].Contains("OBJECT_FIELD_ENTRY:") && (sniff.objectType == "Creature" || sniff.objectType == "Unit" || sniff.objectType == "GameObject"))
                            {
                                string[] packetline = lines[i].Split(new char[] { ' ' });
                                if (packetline.Length == 4)
                                    sniff.entry = packetline[3];
                            }
                        } while (lines[i] != "" && !lines[i + 1].Contains("CreateObject"));
                    }

                    if (sniff.entry != "")
                    {
                        spawnPackets.Add(sniff);
                        sniff.entry = "";
                    }
                }
            }

            return spawnPackets;
        }

        public DataTable GetDataTableForSpawns(List<string> filteredPackets, bool onlyCreateObject2, string filename)
        {
            DataTable dt = new DataTable("Spawns");

            List<SpawnPacket> sniffs = new List<SpawnPacket>();
            sniffs = GetSpawnData(filename, onlyCreateObject2);

            string[] columns = null;

            string col = "type,entry,guidlow,guidfull,x,y,z,o,map,r0,r1,r2,r3,sourcefile";
            columns = col.Split(new char[] { ',' });
            foreach (var column in columns)
                dt.Columns.Add(column);

            foreach (SpawnPacket sniff in sniffs)
            {
                if (sniff.entry != "")
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = sniff.objectType;
                    dr[1] = sniff.entry;
                    dr[2] = sniff.guidLow;
                    dr[3] = sniff.guidFull;
                    dr[4] = sniff.x;
                    dr[5] = sniff.y;
                    dr[6] = sniff.z;
                    dr[7] = sniff.o;
                    dr[8] = sniff.map;
                    dr[9] = sniff.r0;
                    dr[10] = sniff.r1;
                    dr[11] = sniff.r2;
                    dr[12] = sniff.r3;
                    dr[13] = filename;
                    dt.Rows.Add(dr);
                }
            }

            return dt;
        }

        public DataTable GetDataTableForSpells(List<string> filteredPackets)
        {
            var lines = filteredPackets;

            DataTable dt = new DataTable("Spawns");

            SpellPacket sniff;

            sniff.spell = "";
            sniff.casterType = "";
            sniff.casterEntry = "";
            sniff.targetType = "";
            sniff.targetEntry = "";
            sniff.time = "";

            string[] columns = null;

            string col = "Spell,CasterType,CasterEntry,CasterGuid,TargetType,TargetEntry,Time,TimeDiff";
            columns = col.Split(new char[] { ',' });
            foreach (var column in columns)
                dt.Columns.Add(column);


            for (int i = 1; i < lines.Count; i++)
            {
                if (lines[i].Contains("SMSG_SPELL_START"))
                {
                    string[] values = lines[i].Split(new char[] { ' ' });
                    if (values.Length > 9)
                    {
                        sniff.time = values[9];

                        i++;

                        string[] values2 = lines[i].Split(new char[] { ' ' });

                        sniff.casterGuid = values2[3];
                        sniff.casterType = values2[4];
                        sniff.casterEntry = values2[9];

                        do
                        {
                            i++;

                            if (lines[i].Contains("(Cast) SpellID:"))
                            {
                                string[] packetline = lines[i].Split(new char[] { ' ' });

                                sniff.spell = packetline[2];
                            }

                            if (lines[i].Contains("(Cast) (Target) Unit:"))
                            {
                                string[] packetline = lines[i].Split(new char[] { ' ' });
                                if (packetline.Length > 5)
                                    sniff.targetType = packetline[5];
                                else
                                    sniff.targetType = " ";

                                if (sniff.targetType == "Creature/0")
                                    sniff.targetEntry = packetline[10];
                                else
                                    sniff.targetEntry = " ";
                            }

                        } while (lines[i] != "" && !lines[i + 1].Contains("SMSG_SPELL_START"));

                        if (sniff.spell != "")
                        {
                            DataRow dr = dt.NewRow();
                            dr[0] = sniff.spell;
                            dr[1] = sniff.casterType;
                            dr[2] = sniff.casterEntry;
                            dr[3] = sniff.casterGuid;
                            dr[4] = sniff.targetType;
                            dr[5] = sniff.targetEntry;
                            dr[6] = sniff.time;
                            dr[7] = "";
                            dt.Rows.Add(dr);
                            sniff.spell = "";
                        }
                    }
                }
            }
            return dt;
        }

        public List<Forms.frm_speedSetter.SniffedSpeed> GetSniffedSpeedList(List<string> filteredPackets)
        {
            var lines = filteredPackets;

            SpeedPacket sniff;
            List<Forms.frm_speedSetter.SniffedSpeed> creatures = new List<Forms.frm_speedSetter.SniffedSpeed>();

            sniff.entry = "";
            sniff.name = "";
            sniff.speedRun = "";
            sniff.speedWalk = "";

            bool isPet = false;

            bool speedWalkSet = false;
            bool speedRunSet = false;
            bool entrySet = false;

            for (int i = 1; i < lines.Count; i++)
            {
                if (lines[i].Contains("CreateObject"))
                {
                    i++;

                    //string[] values = lines[i].Split(new char[] { ' ' });
                    //string[] objectType = values[5].Split(new char[] { '/' });
                    //sniff.entry = values[10];
                    if (lines[i + 1].Contains("Unit"))
                    {
                        do
                        {
                            i++;

                            if ((lines[i].Contains("WalkSpeed") || lines[i].Contains("Walk Speed")) && speedWalkSet == false)
                            {
                                string[] packetline = lines[i].Split(new char[] { ':' });
                                sniff.speedWalk = packetline[1];
                                sniff.speedWalk = sniff.speedWalk.Trim(' ');
                                speedWalkSet = true;
                            }

                            if ((lines[i].Contains("RunSpeed") || lines[i].Contains("Run Speed")) && speedRunSet == false)
                            {
                                string[] packetline = lines[i].Split(new char[] { ':' });
                                sniff.speedRun = packetline[1];
                                sniff.speedRun = sniff.speedRun.Trim(' ');
                                speedRunSet = true;
                            }

                            if (lines[i].Contains("OBJECT_FIELD_ENTRY") && entrySet == false)
                            {
                                string[] packetline = lines[i].Split(new char[] { ':', '/' });
                                sniff.entry = packetline[1];
                                sniff.entry = sniff.entry.Trim(' ');
                                entrySet = true;
                            }

                            if (lines[i].Contains("UNIT_FIELD_FLAGS"))
                            {
                                isPet = false;
                                string s_unitFlags;
                                string[] packetline = lines[i].Split(new char[] { ':', '/' });
                                string[] secondSplit = packetline[1].Split(')');
                                s_unitFlags = secondSplit[0];
                                s_unitFlags = s_unitFlags.TrimStart('(', ' ');
                                s_unitFlags = s_unitFlags.TrimEnd(')', '/');
                                uint i_unitFlags = uint.Parse(s_unitFlags);
                                Forms.frm_speedSetter.UnitFlags unitFlags;
                                unitFlags = (Forms.frm_speedSetter.UnitFlags)i_unitFlags;

                                if (unitFlags.HasFlag(Forms.frm_speedSetter.UnitFlags.PlayerControlled))
                                {
                                    isPet = true;
                                }
                            }
                        } while (lines[i] != "" && !lines[i + 1].Contains("CreateObject"));

                        if (sniff.entry != "" && isPet != true)
                        {
                            Forms.frm_speedSetter.SniffedSpeed c = new Forms.frm_speedSetter.SniffedSpeed()
                            {
                                Entry = sniff.entry,
                                Name = sniff.name,
                                SpeedWalk = sniff.speedWalk,
                                SpeedRun = sniff.speedRun
                            };
                            creatures.Add(c);
                            sniff.entry = "";
                            sniff.unitFlags = "";
                            speedWalkSet = false;
                            speedRunSet = false;
                            entrySet = false;
                        }
                    }
                }
            }
            return creatures;
        }

        public string ImportGameobjectString(string fileName)
        {

            return "";
        }
    }
}




