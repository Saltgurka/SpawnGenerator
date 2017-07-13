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
        struct Packet
        {
            public string objectType;
            public string entry;
            public string guidLow;
            public string guidFull;
            public string x;
            public string y;
            public string z;
            public string o;
            public string map;
        };

        public List<string> FilterSniffFile(string fileName, bool blacklist, List<string> filterList)
        {
            var lines = File.ReadAllLines(fileName);

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

        public DataTable GetDataTableForSpawns(List<string> filteredPackets, bool onlyCreateObject2)
        {
            var lines = filteredPackets;

            DataTable dt = new DataTable("Spawns");

            Packet sniff;

            sniff.objectType = "";
            sniff.entry = "";
            sniff.guidLow = "";
            sniff.guidFull = "";
            sniff.x = "";
            sniff.y = "";
            sniff.z = "";
            sniff.o = "";
            sniff.map = "";

            string[] columns = null;

            string col = "type,entry,guidlow,guidfull,x,y,z,o,map";
            columns = col.Split(new char[] { ',' });
            foreach (var column in columns)
                dt.Columns.Add(column);

            for (int i = 1; i < lines.Count; i++)
            {
                if (lines[i].Contains("CreateObject2"))
                {
                    i++;

                    string[] values = lines[i].Split(new char[] { ' ' });
                    string[] objectType = values[5].Split(new char[] { '/' });

                    sniff.guidFull = values[4];
                    sniff.objectType = values[5]; //.TrimEnd('/');
                    sniff.map = values[8];
                    sniff.entry = values[10];
                    sniff.guidLow = values[12];

                    do
                    {
                        i++;

                        if (lines[i].Contains("Position: X:"))
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
                            if (orientationline.Length == 3) // Creature
                                sniff.o = orientationline[2];
                            else // Gameobject
                                sniff.o = orientationline[3];
                        }

                    } while (lines[i] != "" && !lines[i + 1].Contains("CreateObject"));

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
                        dt.Rows.Add(dr);
                        sniff.entry = "";
                    }
                }

            }
            return dt;
        }
    }
}
