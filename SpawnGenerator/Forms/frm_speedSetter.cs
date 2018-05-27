using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpawnGenerator.Forms
{
    public partial class frm_speedSetter : Form
    {
        private List<Creature> creatures = new List<Creature>();
        private List<Model> models = new List<Model>();
        private List<string> ignoreList = new List<string>();
        PacketFiltering filter = new PacketFiltering();

        #region enums
        enum MechanicImmunities
        {
            Charm = 1,
            Confused = 2,
            Disarm = 4,
            Distract = 8,
            Fear = 16,
            Fumble = 32,
            Root = 64,
            Pacify = 128,
            Silence = 256,
            Sleep = 512,
            Snare = 1024,
            Stun = 2048,
            Freeze = 4096,
            Knockout = 8192,
            Bleed = 16384,
            Bandage = 32768,
            Polymorph = 65536,
            Banish = 131072,
            Shield = 262144,
            Shackle = 524288,
            Mount = 1048576,
            Persuade = 2097152,
            Turn = 4194304,
            Horror = 8388608,
            Invulnerability = 16777216,
            Interrupt = 33554432,
            Daze = 67108864,
            Discovery = 134217728,
            ImmuneShield = 268435456,
            Sapped = 536870912,
        }

        enum SchoolImmunities
        {
            Normal = 1,
            Holy = 2,
            Fire = 4,
            Nature = 8,
            Frost = 16,
            Shadow = 32,
            Arcane = 64,
        }

        enum UnitClass
        {
            Warrior = 1,
            Paladin = 2,
            Rogue = 4,
            Mage = 8,
        }

        enum DamageSchool
        {
            Physical = 0,
            Holy = 1,
            Fire = 2,
            Nature = 3,
            Frost = 4,
            Shadow = 5,
            Arcane = 6,
        }

        enum Rank
        {
            Normal = 0,
            Elite = 1,
            RareElite = 2,
            WorldBoss = 3,
            Rare = 4,
            Unknown = 5,
        }

        enum CreatureType
        {
            None = 0,
            Beast = 1,
            Dragonkin = 2,
            Demon = 3,
            Elemental = 4,
            Giant = 5,
            Undead = 6,
            Humanoid = 7,
            Critter = 8,
            Mechanical = 9,
            NotSpecified = 10,
            Totem = 11,
            NonCombatPet = 12,
            GasCloud = 13,
        }

        enum Family
        {
            Wolf = 1,
            Cat = 2,
            Spider = 3,
            Bear = 4,
            Boar = 5,
            Crocolisk = 6,
            CarrionBird = 7,
            Crab = 8,
            Gorilla = 9,
            HorseCustom = 10,                    // not exist in DBC but used for horse like beasts in DB
            Raptor = 11,
            Tallstrider = 12,
            Felhunter = 15,
            Voidwalker = 16,
            Succubus = 17,
            Doomguard = 19,
            Scorpid = 20,
            Turtle = 21,
            Imp = 23,
            Bat = 24,
            Hyena = 25,
            Owl = 26,
            WindSerpent = 27,
            RemoteControl = 28,
            Felguard = 29,
            Dragonhawk = 30,
            Ravager = 31,
            WarpStalker = 32,
            Sporebat = 33,
            NetherRay = 34,
            Serpent = 35,
            SeaLion = 36
        }

        enum Expansion
        {
            Vanilla = 0,
            Outland = 1,
            Northrend = 2,
        }

        enum CreatureExtraFlags
        {
            InstanceBind = 0x00000001,       // creature kill bind instance with killer and killer's group
            Civilian = 0x00000002,       // not aggro (ignore faction/reputation hostility)
            NoParry = 0x00000004,       // creature can't parry
            NoParryHasten = 0x00000008,       // creature can't counter-attack at parry
            NoBlock = 0x00000010,       // creature can't block
            NoCrush = 0x00000020,       // creature can't do crush attacks
            NoXPAtKill = 0x00000040,       // creature kill not provide XP
            Invisible = 0x00000080,       // creature is always invisible for player (mostly trigger creatures)
            NotTauntable = 0x00000100,       // creature is immune to taunt auras and effect attack me
            AggroZone = 0x00000200,       // creature sets itself in combat with zone on aggro
            Guard = 0x00000400,       // creature is a guard
            NoCallAssist = 0x00000800,       // creature shouldn't call for assistance on aggro
            Active = 0x00001000,       // creature is active object. Grid of this creature will be loaded and creature set as active
            MMapForceEnable = 0x00002000,       // creature is forced to use MMaps
            MMapForceDisable = 0x00004000,       // creature is forced to NOT use MMaps
            WalkInWater = 0x00008000,       // creature is forced to walk in water even it can swim
            HaveNoSwimAnimation = 0x00010000,       // we have to not set "swim" animation or creature will have "no animation"
            NoMelee = 0x00020000,       // creature can't melee
            FarView = 0x00040000,       // creature with far view
            DontDismountOnAggro = 0x00080000,       // creature is mounted and should fight mounted
            IgnoreUsedPosition = 0x00100000,       // ignore creature when checking used positions around target
            CountSpawns = 0x00200000,       // count creature spawns in Map*
        }

        enum CreatureTypeFlags
        {
            Tameable = 0x00000001,       // Tameable by any hunter
            GhostVisible = 0x00000002,       // Creatures which can _also_ be seen when player is a ghost, used in CanInteract function by client, can't be attacked
            Unk3 = 0x00000004,       // "BOSS" flag for tooltips
            Unk4 = 0x00000008,
            Unk5 = 0x00000010,       // controls something in client tooltip related to creature faction
            Unk6 = 0x00000020,       // may be sound related
            Unk7 = 0x00000040,       // may be related to attackable / not attackable creatures with spells, used together with lua_IsHelpfulSpell/lua_IsHarmfulSpell
            Unk8 = 0x00000080,       // has something to do with unit interaction / quest status requests
            HerbLoot = 0x00000100,       // Can be looted by herbalist
            MiningLoot = 0x00000200,       // Can be looted by miner
            Unk11 = 0x00000400,       // no idea, but it used by client
            Unk12 = 0x00000800,       // related to possibility to cast spells while mounted
            CanAssist = 0x00001000,       // Can aid any player (and group) in combat. Typically seen for escorting NPC's
            Unk14 = 0x00002000,       // checked from calls in Lua_PetHasActionBar
            Unk15 = 0x00004000,       // Lua_UnitGUID, client does guid_low &= 0xFF000000 if this flag is set
            EngineerLoot = 0x00008000,       // Can be looted by engineer
        }

        enum UnitDynFlags
        {
            None = 0x0000,
            Lootable = 0x0001,
            TrackUnit = 0x0002,
            Tapped = 0x0004,       // Lua_UnitIsTapped
            Rooted = 0x0008,
            SpecialInfo = 0x0010,
            Dead = 0x0020,
            ReferAFriend = 0x0040,
        }

        enum NPCFlags
        {
            None = 0x00000000,
            Gossip = 0x00000001,       // 100%
            QuestGiver = 0x00000002,       // guessed, probably ok
            Unk1 = 0x00000004,
            Unk2 = 0x00000008,
            Trainer = 0x00000010,       // 100%
            TrainerClass = 0x00000020,       // 100%
            TrainerProfession = 0x00000040,       // 100%
            Vender = 0x00000080,       // 100%
            VenderAmmo = 0x00000100,       // 100%, general goods vendor
            VendorFood = 0x00000200,       // 100%
            VendorPoison = 0x00000400,       // guessed
            VendorReagent = 0x00000800,       // 100%
            Repair = 0x00001000,       // 100%
            FlightMaster = 0x00002000,       // 100%
            SpiritHealer = 0x00004000,       // guessed
            SpiritGuide = 0x00008000,       // guessed
            Innkeeper = 0x00010000,       // 100%
            Banker = 0x00020000,       // 100%
            Petitioner = 0x00040000,       // 100% 0xC0000 = guild petitions, 0x40000 = arena team petitions
            TabardDesigner = 0x00080000,       // 100%
            BattleMaster = 0x00100000,       // 100%
            Auctioneer = 0x00200000,       // 100%
            StableMaster = 0x00400000,       // 100%
            GuildBanker = 0x00800000,       // cause client to send 997 opcode
            SpellClick = 0x01000000,       // cause client to send 1015 opcode (spell click), dynamic, set at loading and don't must be set in DB
        }

        [Flags]
        public enum UnitFlags
        {
            Unk0 = 0x00000001,
            NonAttackable = 0x00000002,           // not attackable
            NonMovingDeprecated = 0x00000004,           // TODO: Needs research
            PlayerControlled = 0x00000008,           // players, pets, totems, guardians, companions, charms, any units associated with players
            Rename = 0x00000010,
            Preparation = 0x00000020,           // don't take reagents for spells with SPELL_ATTR_EX5_NO_REAGENT_WHILE_PREP
            Unk6 = 0x00000040,
            NotAttackable1 = 0x00000080,           // ?? (UNIT_FLAG_PVP_ATTACKABLE | UNIT_FLAG_NOT_ATTACKABLE_1) is NON_PVP_ATTACKABLE - blue color target
            ImmuneToPlayer = 0x00000100,           // 2.0.8 - (OOC Out Of Combat) Can not be attacked when not in combat. Removed if unit for some reason enter combat (flag probably removed for the attacked and it's party/group only)
            ImmuneToNpc = 0x00000200,           // makes you unable to attack everything. Almost identical to our "civilian"-term. Will ignore it's surroundings and not engage in combat unless "called upon" or engaged by another unit.
            Looting = 0x00000400,           // loot animation
            PetInCombat = 0x00000800,           // in combat?, 2.0.8 Possibly Unkillable
            PvP = 0x00001000,
            Silenced = 0x00002000,           // silenced, 2.1.1
            Unk14 = 0x00004000,           // 2.0.8
            Swimming = 0x00008000,           // controls water swimming animation - TODO: confirm whether dynamic or static
            Unk16 = 0x00010000,           // removes attackable icon, if on yourself, cannot assist self but can cast TARGET_SELF spells
            Pacified = 0x00020000,
            Stunned = 0x00040000,           // stunned, 2.1.1
            InCombat = 0x00080000,
            TaxiFlight = 0x00100000,           // disable casting at client side spell not allowed by taxi flight (mounted?), probably used with 0x4 flag
            Disarmed = 0x00200000,           // disable melee spells casting..., "Required melee weapon" added to melee spells tooltip.
            Confused = 0x00400000,
            Fleeing = 0x00800000,
            Possessed = 0x01000000,           // remote control e.g. Eyes of the Beast: let master use melee attack, make unit unselectable via mouse for master in world (as if it was own character)
            NotSelectable = 0x02000000,
            Skinnable = 0x04000000,
            Mount = 0x08000000,
            Unk28 = 0x10000000,
            Unk29 = 0x20000000,           // used in Feign Death spell
            Sheathe = 0x40000000,
        }

        enum MovementType
        {
            Waypoint = 2,
            Random = 1,
            Idle = 0,
        }

        enum InhabitType
        {
            GroundOnly = 1,
            WaterOnly = 2,
            GroundAndWater = 3,
            AlwaysFlying = 4,
            OverGroundAlwaysFly = 5,
            OverWaterAlwaysFly = 6,
            AlwaysFlyOverAnything = 7,
        }

        enum RegenerateStats
        {
            NoRegen = 0,
            Health = 1,
            Power = 2,
            HealthAndPower = 3,
        }

        #endregion
        public class SniffedSpeed
        {
            public string Entry { get; set; }
            public string Name { get; set; }
            public string UnitGUID { get; set; }
            public string SpeedWalk { get; set; }
            public string SpeedRun { get; set; }
            public string FileName { get; set; }
            public string ModelId { get; set; }
        }

        public frm_speedSetter()
        {
            InitializeComponent();
        }

        private void SpeedSetter_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCreatures();
                LoadModels();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadCreatures()
        {
            string host = Properties.Settings.Default.Host;
            string database = Properties.Settings.Default.Database;
            string user = Properties.Settings.Default.User;
            string password = Properties.Settings.Default.Password;
            string port = Properties.Settings.Default.Port;
            DBConnect connect = new DBConnect(host, database, user, password, port);
            creatures = connect.GetCreatures();
        }

        private void LoadModels()
        {
            string host = Properties.Settings.Default.Host;
            string database = Properties.Settings.Default.Database;
            string user = Properties.Settings.Default.User;
            string password = Properties.Settings.Default.Password;
            string port = Properties.Settings.Default.Port;
            DBConnect connect = new DBConnect(host, database, user, password, port);
            models = connect.GetModels();
        }

        private void CheckInvalidSpeeds(string fileName)
        {
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            List<string> filterList = new List<string>(new string[] { "SMSG_UPDATE_OBJECT", "SMSG_COMPRESSED_UPDATE_OBJECT" });
            List<string> createObjectList = filter.FilterSniffFile(fileName, false, filterList);
            List<SniffedSpeed> speeds = filter.GetSniffedSpeedList(createObjectList);

            foreach (var item in speeds)
            {
                string oldSpeedWalk = "";
                string oldSpeedRun = "";

                double w = Convert.ToDouble(item.SpeedWalk, new CultureInfo("en-US"));
                double speedWalk = w / 2.5f;

                double r = Convert.ToDouble(item.SpeedRun, new CultureInfo("en-US"));
                double speedRun = r / 7f;

                double roundedSpeedWalk;
                double roundedSpeedRun;
                if (speedWalk > 1)
                    roundedSpeedWalk = Math.Round(speedWalk, 5);
                else
                    roundedSpeedWalk = Math.Round(speedWalk, 6);

                if (speedRun > 1)
                    roundedSpeedRun = Math.Round(speedRun, 5);
                else
                    roundedSpeedRun = Math.Round(speedRun, 6);

                string name = "";
                bool addItem = false;

                for (int i = 0; i < models.Count; i++)
                {
                    if (models[i].ModelId == item.ModelId)
                    {
                        //name = creatures[i].Name;

                        if (roundedSpeedWalk != double.Parse(models[i].SpeedWalk) || roundedSpeedRun != double.Parse(models[i].SpeedRun))
                        {
                            bool exists = false;
                            addItem = false;

                            if (int.Parse(models[i].ModelId) > 25958)
                                addItem = false;

                            for (int k = 0; k < dgv_grid.Rows.Count; k++)
                            {
                                if (dgv_grid.Rows[k].Cells[1].Value != null && item.ModelId == dgv_grid.Rows[k].Cells[1].Value.ToString())
                                {
                                    if (roundedSpeedWalk.ToString() != dgv_grid.Rows[k].Cells[4].Value.ToString() || roundedSpeedRun.ToString() != dgv_grid.Rows[k].Cells[5].Value.ToString())
                                    {
                                        //MessageBox.Show("The value already existed in DataGridView. ModelId: (" + item.ModelId + ")\n First Sniffed SpeedWalk: " + roundedSpeedWalk + " Second Sniffed SpeedWalk: " + dgv_grid.Rows[k].Cells[4].Value.ToString()
                                            //+ "\n First Sniffed SpeedRun: " + roundedSpeedRun + " Second Sniffed SpeedRun: " + dgv_grid.Rows[k].Cells[5].Value.ToString() + "\n Sniffs are showing different speeds for the same model!!\n" + fileName);
                                        rtxt_duplicateResults.Text += item.UnitGUID + ", " + fileName + " vs " + dgv_grid.Rows[k].Cells[7].Value.ToString() + ", " + dgv_grid.Rows[k].Cells[6].Value.ToString() + ",\n";
                                        // Add to ignore list
                                        ignoreList.Add(item.ModelId);
                                    }
                                    exists = true;
                                }

                            }
                            if (exists == false)
                            {
                                oldSpeedWalk = models[i].SpeedWalk;
                                oldSpeedRun = models[i].SpeedRun;

                                addItem = true;
                            }

                        }
                    }
                }

                if (addItem)
                    dgv_grid.Rows.Add(name, int.Parse(item.ModelId), oldSpeedWalk, oldSpeedRun, roundedSpeedWalk, roundedSpeedRun, fileName, item.UnitGUID);
            }

            Cursor = Cursors.Default;
            lbl_rows.Text = "Rows: " + dgv_grid.RowCount;
        }

        //                    for (int i = 0; i<creatures.Count; i++)
        //            {
        //                if (creatures[i].Entry == item.Entry)
        //                {
        //                    name = creatures[i].Name;

        //                    if (roundedSpeedWalk != double.Parse(creatures[i].SpeedWalk) || roundedSpeedRun != double.Parse(creatures[i].SpeedRun))
        //                    {
        //                        bool exists = false;
        //    addItem = false;

        //                        for (int k = 0; k<dgv_grid.Rows.Count; k++)
        //                        {
        //                            if (dgv_grid.Rows[k].Cells[1].Value != null && item.Entry == dgv_grid.Rows[k].Cells[1].Value.ToString())
        //                            {
        //                                if (roundedSpeedWalk.ToString() != dgv_grid.Rows[k].Cells[4].Value.ToString() || roundedSpeedRun.ToString() != dgv_grid.Rows[k].Cells[5].Value.ToString())
        //                                {
        //                                    MessageBox.Show("The value already existed in DataGridView. Entry: (" + item.Entry + ")\n First Sniffed SpeedWalk: " + roundedSpeedWalk + " Second Sniffed SpeedWalk: " + dgv_grid.Rows[k].Cells[4].Value.ToString()
        //                                        + "\n First Sniffed SpeedRun: " + roundedSpeedRun + " Second Sniffed SpeedRun: " + dgv_grid.Rows[k].Cells[5].Value.ToString() + "\n Sniffs are showing different speeds for the same creature!!\n" + fileName);
        //                                    rtxt_duplicateResults.Text += item.Entry + ",\n";
        //                                }
        //exists = true;
        //                            }

        //                        }
        //                        if (exists == false)
        //                        {
        //                            oldSpeedWalk = creatures[i].SpeedWalk;
        //                            oldSpeedRun = creatures[i].SpeedRun;

        //                            addItem = true;
        //                        }

        //                    }
        //                }
        //            }

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
                int numOfFiles = openFileDialog.FileNames.Length;
                int currentFile = 0;
                progress.Step = 100 / numOfFiles;

                foreach (String file in openFileDialog.FileNames)
                {
                    currentFile++;
                    lbl_currentFile.Text = file;
                    lbl_currentNum.Text = currentFile + "/" + numOfFiles;
                    progress.PerformStep();
                    CheckInvalidSpeeds(file);
                }

                lbl_currentFile.Text = "";
                lbl_currentNum.Text = "Done!";
                progress.Value = 0;
            }
            else
            {
                // This code runs if the dialog was cancelled
                return;
            }
        }

        private void btn_generateSQL_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US"); // Dot instead of comma in decimal numbers
            string output = "";
            foreach (DataGridViewRow row in dgv_grid.Rows)
            {
                if (!ignoreList.Contains(row.Cells[1].Value))
                {
                    output += "UPDATE creature_model_info SET SpeedWalk="
                        + row.Cells[4].Value
                        + ", SpeedRun="
                        + row.Cells[5].Value
                        + " WHERE modelid="
                        + row.Cells[1].Value
                        + ";\n";
                        //+ row.Cells[0].Value
                        //+ " (OldSpeedWalk: "
                        //+ row.Cells[2].Value
                        //+ ", OldSpeedRun: "
                        //+ row.Cells[3].Value
                        //+ ")\n";
                }
                else
                    rtxt_duplicateResults.Text += "Ignored ModelId: " + row.Cells[1].Value + "\n";

                //            output += "UPDATE creature_template SET SpeedWalk="
                //+ row.Cells[4].Value
                //+ ", SpeedRun="
                //+ row.Cells[5].Value
                //+ " WHERE entry="
                //+ row.Cells[1].Value
                //+ "; -- "
                //+ row.Cells[0].Value
                //+ " (OldSpeedWalk: "
                //+ row.Cells[2].Value
                //+ ", OldSpeedRun: "
                //+ row.Cells[3].Value
                //+ ")\n";
            }

            rtxt_output.Text = output;
        }

        private void frm_speedSetter_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
