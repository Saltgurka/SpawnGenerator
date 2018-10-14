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
    public partial class frm_templateFixer : Form
    {
        private List<Creature> creatures = new List<Creature>();
        private List<Model> models = new List<Model>();
        PacketFiltering filter = new PacketFiltering();
        List<int> addedEntries = new List<int>();
        List<int> addedModels = new List<int>();

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

        struct CreaturePacket
        {
            public int objectType;
            public int entry;
            public float speedWalk;
            public float speedRun;
            public float scale;
            public int faction;
            public int unitFlags;
            public int meleeBaseAttackTime;
            public int rangedBaseAttackTime;
            public float boundingRadius;
            public float combatReach;
            public int npcFlags;
            public int racialLeader;
            // Add Type Flags
            public int creatureType;
            public int creatureFamily;
            public int rank;
            public int modelId1;
            public int modelId2;
            public int modelId3;
            public int modelId4;

            public int currentModel;
        }

        public frm_templateFixer()
        {
            InitializeComponent();
        }

        private void frm_templateFixer_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
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

        private void btn_generate_Click(object sender, EventArgs e)
        {
            string[] lines = null;
            lines = rtb_input.Text.Split(new char[] { '\n' });

            int objectType = -1;
            int entry = -1;
            float speedWalk = -1f;
            float speedRun = -1f;
            float scale = -1f;
            int faction = -1;
            int unitFlags = -1;
            int meleeBaseAttackTime = -1;
            int rangedBaseAttackTime = -1;
            float boundingRadius = -1f;
            float combatReach = -1f;
            int npcFlags = -1;
            int racialLeader = -1;
            // Add Type Flags
            int creatureType = -1;
            int creatureFamily = -1;
            int rank = -1;
            int modelId1 = -1;
            int modelId2 = -1;
            int modelId3 = -1;
            int modelId4 = -1;

            int currentModel = -1;

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("Object Type:"))
                {
                    string[] line = lines[i].Split(' ');
                    if (!int.TryParse(line[3], out objectType))
                    {
                        rtb_output.Text = "Parsing failed on Type";
                        return;
                    }
                }
            }
            for (int i = 0; i < lines.Length; i++)
            {
                switch (objectType)
                {
                    case 0:
                        break;
                    case 3: // Unit
                    case 5:
                        {
                            // Entry
                            if (lines[i].Contains("OBJECT_FIELD_ENTRY:"))
                            {
                                string[] line = lines[i].Split(' ');
                                string[] line2 = line[2].Split('/');
                                if (!int.TryParse(line2[0], out int tempEntry))
                                {
                                    rtb_output.Text = "Parsing failed on Entry";
                                    return;
                                }
                                if (tempEntry != entry && entry != -1)
                                {
                                    rtb_output.Text = "Can't parse two objects at the same time";
                                    return;
                                }
                                entry = tempEntry;
                            }

                            // SpeedWalk
                            if (lines[i].Contains("WalkSpeed:") && speedWalk == -1)
                            {
                                string[] line = lines[i].Split(' ');
                                if (!float.TryParse(line[2], out speedWalk))
                                {
                                    rtb_output.Text = "Parsing failed on WalkSpeed";
                                    return;
                                }
                                //speedWalk /= 2.5f;
                            }

                            // SpeedRun
                            if (lines[i].Contains("RunSpeed:") && speedRun == -1)
                            {
                                string[] line = lines[i].Split(' ');
                                if (!float.TryParse(line[2], out speedRun))
                                {
                                    rtb_output.Text = "Parsing failed on RunSpeed";
                                    return;
                                }
                                //speedWalk /= 7f;
                            }

                            // Scale
                            if (lines[i].Contains("OBJECT_FIELD_SCALE_X:") && scale == -1)
                            {
                                string[] line = lines[i].Split(' ');
                                string[] line2 = line[2].Split('/');
                                if (!float.TryParse(line2[1], out scale))
                                {
                                    rtb_output.Text = "Parsing failed on OBJECT_FIELD_SCALE_X";
                                    return;
                                }
                            }

                            // Faction
                            if (lines[i].Contains("UNIT_FIELD_FACTIONTEMPLATE:") && faction == -1)
                            {
                                string[] line = lines[i].Split(' ');
                                string[] line2 = line[2].Split('/');
                                if (!int.TryParse(line2[0], out faction))
                                {
                                    rtb_output.Text = "Parsing failed on UNIT_FIELD_FACTIONTEMPLATE";
                                    return;
                                }
                            }

                            // UnitFlags
                            if (lines[i].Contains("UNIT_FIELD_FLAGS:") && unitFlags == -1)
                            {
                                string[] line = lines[i].Split(' ');
                                string[] line2 = line[2].Split('/');
                                if (!int.TryParse(line2[0], out unitFlags))
                                {
                                    rtb_output.Text = "Parsing failed on UNIT_FIELD_FLAGS";
                                    return;
                                }
                            }

                            // MeleeBaseAttackTime
                            if (lines[i].Contains("UNIT_FIELD_BASEATTACKTIME:") && meleeBaseAttackTime == -1)
                            {
                                string[] line = lines[i].Split(' ');
                                string[] line2 = line[2].Split('/');
                                if (!int.TryParse(line2[0], out meleeBaseAttackTime))
                                {
                                    rtb_output.Text = "Parsing failed on UNIT_FIELD_BASEATTACKTIME";
                                    return;
                                }
                            }

                            // RangedBaseAttackTime
                            if (lines[i].Contains("UNIT_FIELD_BASEATTACKTIME + 1:") && rangedBaseAttackTime == -1)
                            {
                                string[] line = lines[i].Split(' ');
                                string[] line2 = line[4].Split('/');
                                if (!int.TryParse(line2[0], out rangedBaseAttackTime))
                                {
                                    rtb_output.Text = "Parsing failed on UNIT_FIELD_BASEATTACKTIME + 1";
                                    return;
                                }
                            }

                            // bounding_radius
                            if (lines[i].Contains("UNIT_FIELD_BOUNDINGRADIUS:") && boundingRadius == -1)
                            {
                                string[] line = lines[i].Split(' ');
                                string[] line2 = line[2].Split('/');
                                if (!float.TryParse(line2[1], out boundingRadius))
                                {
                                    rtb_output.Text = "Parsing failed on UNIT_FIELD_BOUNDINGRADIUS";
                                    return;
                                }
                            }

                            // combat_reach
                            if (lines[i].Contains("UNIT_FIELD_COMBATREACH:") && combatReach == -1)
                            {
                                string[] line = lines[i].Split(' ');
                                string[] line2 = line[2].Split('/');
                                if (!float.TryParse(line2[1], out combatReach))
                                {
                                    rtb_output.Text = "Parsing failed on UNIT_FIELD_COMBATREACH";
                                    return;
                                }
                            }

                            // NPCFlags
                            if (lines[i].Contains("UNIT_NPC_FLAGS:") && npcFlags == -1)
                            {
                                string[] line = lines[i].Split(' ');
                                string[] line2 = line[2].Split('/');
                                if (!int.TryParse(line2[0], out npcFlags))
                                {
                                    rtb_output.Text = "Parsing failed on UNIT_NPC_FLAGS";
                                    return;
                                }
                            }

                            // RacialLeader
                            if (lines[i].Contains("Leader:") && racialLeader == -1)
                            {
                                string[] line = lines[i].Split(' ');
                                if (lines[1] == "True")
                                    racialLeader = 1;
                                else
                                    racialLeader = 0;
                            }

                            // TypeFlags

                            // CreatureType
                            if (lines[i].Contains("CreatureType:") && creatureType == -1)
                            {
                                string[] line = lines[i].Split(' ');
                                if (!int.TryParse(line[1], out creatureType))
                                {
                                    rtb_output.Text = "Parsing failed on CreatureType";
                                    return;
                                }
                            }

                            // CreatureFamily
                            if (lines[i].Contains("CreatureFamily:") && creatureFamily == -1)
                            {
                                string[] line = lines[i].Split(' ');
                                if (!int.TryParse(line[1], out creatureFamily))
                                {
                                    rtb_output.Text = "Parsing failed on CreatureFamily";
                                    return;
                                }
                            }

                            // Rank
                            if (lines[i].Contains("Classification:") && rank == -1)
                            {
                                string[] line = lines[i].Split(' ');
                                if (!int.TryParse(line[1], out rank))
                                {
                                    rtb_output.Text = "Parsing failed on Classification";
                                    return;
                                }
                            }

                            // ModelId1
                            if (lines[i].Contains("[0] CreatureDisplayID:") && modelId1 == -1)
                            {
                                string[] line = lines[i].Split(' ');
                                if (!int.TryParse(line[2], out modelId1))
                                {
                                    rtb_output.Text = "Parsing failed on [0] CreatureDisplayID:";
                                    return;
                                }
                            }

                            // ModelId2
                            if (lines[i].Contains("[1] CreatureDisplayID:") && modelId2 == -1)
                            {
                                string[] line = lines[i].Split(' ');
                                if (!int.TryParse(line[2], out modelId2))
                                {
                                    rtb_output.Text = "Parsing failed on [1] CreatureDisplayID:";
                                    return;
                                }
                            }

                            // ModelId3
                            if (lines[i].Contains("[2] CreatureDisplayID:") && modelId3 == -1)
                            {
                                string[] line = lines[i].Split(' ');
                                if (!int.TryParse(line[2], out modelId3))
                                {
                                    rtb_output.Text = "Parsing failed on [2] CreatureDisplayID:";
                                    return;
                                }
                            }

                            // ModelId4
                            if (lines[i].Contains("[3] CreatureDisplayID:") && modelId4 == -1)
                            {
                                string[] line = lines[i].Split(' ');
                                if (!int.TryParse(line[2], out modelId4))
                                {
                                    rtb_output.Text = "Parsing failed on [3] CreatureDisplayID:";
                                    return;
                                }
                            }

                            // currentModel
                            if (lines[i].Contains("UNIT_FIELD_DISPLAYID:") && currentModel == -1)
                            {
                                string[] line = lines[i].Split(' ');
                                string[] line2 = line[2].Split('/');
                                if (!int.TryParse(line2[0], out currentModel))
                                {
                                    rtb_output.Text = "Parsing failed on UNIT_FIELD_DISPLAYID";
                                    return;
                                }
                            }
                            break;
                        }
                    default:
                        {
                            rtb_output.Text = "Unsupported Object Type";
                            return;
                        }
                }
            }
            if (entry == -1 || currentModel == -1)
            {
                rtb_output.Text += "\nNo entry or ModelId found";
                return;
            }

            // If these lines were not found it means they are 0
            if (unitFlags == -1)
                unitFlags = 0;
            if (npcFlags == -1)
                npcFlags = 0;
            if (modelId1 == -1)
                modelId1 = 0;
            if (modelId2 == -1)
                modelId2 = 0;
            if (modelId3 == -1)
                modelId3 = 0;
            if (modelId4 == -1)
                modelId4 = 0;

            string entryString = entry.ToString();
            string currentModelString = currentModel.ToString();
            Creature result = creatures.Find(a => a.Entry == entryString);
            Model modelResult = models.Find(a => a.ModelId == currentModelString);
            double roundedSpeedWalk;
            double roundedSpeedRun;
            if (speedWalk > 1)
                roundedSpeedWalk = Math.Round(speedWalk / 2.5, 5);
            else
                roundedSpeedWalk = Math.Round(speedWalk / 2.5, 6);

            if (speedRun > 1)
                roundedSpeedRun = Math.Round(speedRun / 7, 5);
            else
                roundedSpeedRun = Math.Round(speedRun / 7, 6);

            rtb_output.Text = "UPDATE creature_template SET" +
                (speedWalk != -1f ? (roundedSpeedWalk.ToString() != result.SpeedWalk ? " SpeedWalk=" + speedWalk.ToString() + "/2.5," : "") : "") +
                (speedRun != -1f ? (roundedSpeedRun.ToString() != result.SpeedRun ? " SpeedRun=" + speedRun.ToString() + "/7," : "") : "") +
                (scale != -1f ? (scale.ToString() != result.Scale ? " Scale=" + scale.ToString() + "," : "") : "") +
                (faction != -1f ? (faction.ToString() != result.Faction ? " FactionAlliance=" + faction.ToString() + ", FactionHorde=" + faction.ToString() + "," : "") : "") +
                (unitFlags != -1 ? (unitFlags.ToString() != result.UnitFlags ? " UnitFlags=" + unitFlags.ToString() + "," : "") : "") +
                (meleeBaseAttackTime != -1 ? (meleeBaseAttackTime.ToString() != result.MeleeBaseAttackTime ? " MeleeBaseAttackTime=" + meleeBaseAttackTime.ToString() + "," : "") : "") +
                (rangedBaseAttackTime != -1 ? (rangedBaseAttackTime.ToString() != result.RangedBaseAttackTime ? " RangedBaseAttackTime=" + rangedBaseAttackTime.ToString() + "," : "") : "") +
                (npcFlags != -1 ? (npcFlags.ToString() != result.NpcFlags ? " NpcFlags=" + npcFlags.ToString() + "," : "") : "") +
                (racialLeader != -1 ? (racialLeader.ToString() != result.RacialLeader ? " RacialLeader=" + racialLeader.ToString() + "," : "") : "") +
                (creatureType != -1 ? (creatureType.ToString() != result.CreatureType ? " CreatureType=" + creatureType.ToString() + "," : "") : "") +
                (creatureFamily != -1 ? (creatureFamily.ToString() != result.Family ? " Family=" + creatureFamily.ToString() + "," : "") : "") +
                (rank != -1 ? (rank.ToString() != result.Rank ? " Rank=" + rank.ToString() + "," : "") : "") +
                (modelId1 != -1 ? (modelId1.ToString() != result.ModelId1 ? " ModelId1=" + modelId1.ToString() + "," : "") : "") +
                (modelId2 != -1 ? (modelId2.ToString() != result.ModelId2 ? " ModelId2=" + modelId2.ToString() + "," : "") : "") +
                (modelId3 != -1 ? (modelId3.ToString() != result.ModelId3 ? " ModelId3=" + modelId3.ToString() + "," : "") : "") +
                (modelId4 != -1 ? (modelId4.ToString() != result.ModelId4 ? " ModelId4=" + modelId4.ToString() + "," : "") : "") +
                " WHERE entry=" + entry.ToString() + ";\n";

            if (modelResult != null)
            {
                rtb_output.Text += "UPDATE creature_model_info SET" +
                    (boundingRadius != -1f ? (boundingRadius.ToString() != modelResult.Bounding_radius ? " bounding_radius=" + boundingRadius.ToString() + "," : "") : "") +
                    (combatReach != -1f ? (combatReach.ToString() != modelResult.Combat_reach ? " combat_reach=" + combatReach.ToString() + "," : "") : "") +
                    " WHERE modelid=" + currentModel.ToString() + ";";
            }
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
                List<CreaturePacket> creaturePacketsToCompare = new List<CreaturePacket>();

                foreach (String file in openFileDialog.FileNames)
                {
                    List<string> filterList = new List<string>(new string[] { "SMSG_UPDATE_OBJECT", "SMSG_QUERY_CREATURE_RESPONSE" });
                    creaturePacketsToCompare = GetMassUpdate(filter.FilterSniffFile(file, false, filterList));
                }
                CompareMassUppdate(creaturePacketsToCompare);

                btn_loadFile.Enabled = true;
                btn_loadFile.Text = "Load File(s)";
            }
            else
            {
                // This code runs if the dialog was cancelled
                return;
            }

            addedEntries.Clear();
            addedModels.Clear();
        }

        private List<CreaturePacket> GetMassUpdate(List<string> filteredPackets)
        {
            var lines = filteredPackets;

            CreaturePacket sniff = new CreaturePacket();
            List<CreaturePacket> creaturePackets = new List<CreaturePacket>();

            sniff.objectType = -1;
            sniff.entry = -1;
            sniff.speedWalk = -1f;
            sniff.speedRun = -1f;
            sniff.scale = -1f;
            sniff.faction = -1;
            sniff.unitFlags = -1;
            sniff.meleeBaseAttackTime = -1;
            sniff.rangedBaseAttackTime = -1;
            sniff.boundingRadius = -1f;
            sniff.combatReach = -1f;
            sniff.npcFlags = -1;
            sniff.racialLeader = -1;
            // Add Type Flags
            sniff.creatureType = -1;
            sniff.creatureFamily = -1;
            sniff.rank = -1;
            sniff.modelId1 = -1;
            sniff.modelId2 = -1;
            sniff.modelId3 = -1;
            sniff.modelId4 = -1;

            sniff.currentModel = -1;

            

            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Contains("CreateObject2") || lines[i].Contains("SMSG_QUERY_CREATURE_RESPONSE"))
                {
                    bool createObjectPacket = false;
                    if (lines[i].Contains("CreateObject2"))
                        createObjectPacket = true;
                    do
                    {
                        i++;

                        if (lines[i].Contains("Object Type:") && sniff.objectType == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            if (!int.TryParse(line[3], out sniff.objectType))
                            {
                                //rtb_output.Text = "Parsing failed on Type";
                                //return;
                            }
                        }
                        // Entry
                        if (lines[i].Contains("OBJECT_FIELD_ENTRY:") && sniff.entry == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            string[] line2 = line[2].Split('/');
                            if (!int.TryParse(line2[0], out sniff.entry))
                            {
                                //rtb_output.Text = "Parsing failed on Entry";
                                //return;
                            }
                            //if (tempEntry != sniff.entry && sniff.entry != -1)
                            //{
                            //    //rtb_output.Text = "Can't parse two objects at the same time";
                            //    //return;
                            //}
                            //sniff.entry = tempEntry;
                        }
                        // Entry in Query Response
                        if (lines[i].Contains("Entry:") && sniff.entry == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            if (!int.TryParse(line[1], out sniff.entry))
                            {
                                //rtb_output.Text = "Parsing failed on WalkSpeed";
                                //return;
                            }

                            // This means that we can also set the object type
                            sniff.objectType = 3;
                        }

                        // SpeedWalk
                        if (lines[i].Contains("WalkSpeed:") && sniff.speedWalk == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            if (!float.TryParse(line[2], out sniff.speedWalk))
                            {
                                //rtb_output.Text = "Parsing failed on WalkSpeed";
                                //return;
                            }
                            //speedWalk /= 2.5f;
                        }

                        // SpeedRun
                        if (lines[i].Contains("RunSpeed:") && sniff.speedRun == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            if (!float.TryParse(line[2], out sniff.speedRun))
                            {
                                //rtb_output.Text = "Parsing failed on RunSpeed";
                                //return;
                            }
                            //speedWalk /= 7f;
                        }

                        // Scale
                        if (lines[i].Contains("OBJECT_FIELD_SCALE_X:") && sniff.scale == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            string[] line2 = line[2].Split('/');
                            if (!float.TryParse(line2[1], out sniff.scale))
                            {
                                //rtb_output.Text = "Parsing failed on OBJECT_FIELD_SCALE_X";
                                //return;
                            }
                        }

                        // Faction
                        if (lines[i].Contains("UNIT_FIELD_FACTIONTEMPLATE:") && sniff.faction == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            string[] line2 = line[2].Split('/');
                            if (!int.TryParse(line2[0], out sniff.faction))
                            {
                                //rtb_output.Text = "Parsing failed on UNIT_FIELD_FACTIONTEMPLATE";
                                //return;
                            }
                        }

                        // UnitFlags
                        if (lines[i].Contains("UNIT_FIELD_FLAGS:") && sniff.unitFlags == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            string[] line2 = line[2].Split('/');
                            if (!int.TryParse(line2[0], out sniff.unitFlags))
                            {
                                //rtb_output.Text = "Parsing failed on UNIT_FIELD_FLAGS";
                                //return;
                            }
                        }

                        // MeleeBaseAttackTime
                        if (lines[i].Contains("UNIT_FIELD_BASEATTACKTIME:") && sniff.meleeBaseAttackTime == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            string[] line2 = line[2].Split('/');
                            if (!int.TryParse(line2[0], out sniff.meleeBaseAttackTime))
                            {
                                //rtb_output.Text = "Parsing failed on UNIT_FIELD_BASEATTACKTIME";
                                //return;
                            }
                        }

                        // RangedBaseAttackTime
                        if (lines[i].Contains("UNIT_FIELD_BASEATTACKTIME + 1:") && sniff.rangedBaseAttackTime == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            string[] line2 = line[4].Split('/');
                            if (!int.TryParse(line2[0], out sniff.rangedBaseAttackTime))
                            {
                                //rtb_output.Text = "Parsing failed on UNIT_FIELD_BASEATTACKTIME + 1";
                                //return;
                            }
                        }

                        // bounding_radius
                        if (lines[i].Contains("UNIT_FIELD_BOUNDINGRADIUS:") && sniff.boundingRadius == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            string[] line2 = line[2].Split('/');
                            if (!float.TryParse(line2[1], out sniff.boundingRadius))
                            {
                                //rtb_output.Text = "Parsing failed on UNIT_FIELD_BOUNDINGRADIUS";
                                //return;
                            }
                        }

                        // combat_reach
                        if (lines[i].Contains("UNIT_FIELD_COMBATREACH:") && sniff.combatReach == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            string[] line2 = line[2].Split('/');
                            if (!float.TryParse(line2[1], out sniff.combatReach))
                            {
                                //rtb_output.Text = "Parsing failed on UNIT_FIELD_COMBATREACH";
                                //return;
                            }
                        }

                        // NPCFlags
                        if (lines[i].Contains("UNIT_NPC_FLAGS:") && sniff.npcFlags == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            string[] line2 = line[2].Split('/');
                            if (!int.TryParse(line2[0], out sniff.npcFlags))
                            {
                                //rtb_output.Text = "Parsing failed on UNIT_NPC_FLAGS";
                                //return;
                            }
                        }

                        // RacialLeader
                        if (lines[i].Contains("Leader:") && sniff.racialLeader == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            if (lines[1] == "True")
                                sniff.racialLeader = 1;
                            else
                                sniff.racialLeader = 0;
                        }

                        // TypeFlags

                        // CreatureType
                        if (lines[i].Contains("CreatureType:") && sniff.creatureType == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            if (!int.TryParse(line[1], out sniff.creatureType))
                            {
                                //rtb_output.Text = "Parsing failed on CreatureType";
                                //return;
                            }
                        }

                        // CreatureFamily
                        if (lines[i].Contains("CreatureFamily:") && sniff.creatureFamily == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            if (!int.TryParse(line[1], out sniff.creatureFamily))
                            {
                                //rtb_output.Text = "Parsing failed on CreatureFamily";
                                //return;
                            }
                        }

                        // Rank
                        if (lines[i].Contains("Classification:") && sniff.rank == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            if (!int.TryParse(line[1], out sniff.rank))
                            {
                                //rtb_output.Text = "Parsing failed on Classification";
                                //return;
                            }
                        }

                        // ModelId1
                        if (lines[i].Contains("[0] CreatureDisplayID:") && sniff.modelId1 == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            if (!int.TryParse(line[2], out sniff.modelId1))
                            {
                                //rtb_output.Text = "Parsing failed on [0] CreatureDisplayID:";
                                //return;
                            }
                        }

                        // ModelId2
                        if (lines[i].Contains("[1] CreatureDisplayID:") && sniff.modelId2 == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            if (!int.TryParse(line[2], out sniff.modelId2))
                            {
                                //rtb_output.Text = "Parsing failed on [1] CreatureDisplayID:";
                                //return;
                            }
                        }

                        // ModelId3
                        if (lines[i].Contains("[2] CreatureDisplayID:") && sniff.modelId3 == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            if (!int.TryParse(line[2], out sniff.modelId3))
                            {
                                //rtb_output.Text = "Parsing failed on [2] CreatureDisplayID:";
                                //return;
                            }
                        }

                        // ModelId4
                        if (lines[i].Contains("[3] CreatureDisplayID:") && sniff.modelId4 == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            if (!int.TryParse(line[2], out sniff.modelId4))
                            {
                                //rtb_output.Text = "Parsing failed on [3] CreatureDisplayID:";
                                //return;
                            }
                        }

                        // currentModel
                        if (lines[i].Contains("UNIT_FIELD_DISPLAYID:") && sniff.currentModel == -1)
                        {
                            string[] line = lines[i].Split(' ');
                            string[] line2 = line[2].Split('/');
                            if (!int.TryParse(line2[0], out sniff.currentModel))
                            {
                                //rtb_output.Text = "Parsing failed on UNIT_FIELD_DISPLAYID";
                                //return;
                            }
                        }
                    } while (lines[i + 1] != "" && !lines[i + 1].Contains("CreateObject2"));

                    // If these lines were not found it means they are 0
                    if (createObjectPacket)
                    {
                        if (sniff.unitFlags == -1)
                            sniff.unitFlags = 0;
                        if (sniff.npcFlags == -1)
                            sniff.npcFlags = 0;
                    }
                    else
                    {
                        if (sniff.modelId1 == -1)
                            sniff.modelId1 = 0;
                        if (sniff.modelId2 == -1)
                            sniff.modelId2 = 0;
                        if (sniff.modelId3 == -1)
                            sniff.modelId3 = 0;
                        if (sniff.modelId4 == -1)
                            sniff.modelId4 = 0;
                    }

                    //string entryString = sniff.entry.ToString();
                    //string currentModelString = sniff.currentModel.ToString();
                    //Creature result = creatures.FirstOrDefault(a => a.Entry == entryString);
                    //Model modelResult = models.FirstOrDefault(a => a.ModelId == currentModelString);
                    //double roundedSpeedWalk;
                    //double roundedSpeedRun;
                    //if (sniff.speedWalk > 1)
                    //    roundedSpeedWalk = Math.Round(sniff.speedWalk / 2.5, 5);
                    //else
                    //    roundedSpeedWalk = Math.Round(sniff.speedWalk / 2.5, 6);

                    //if (sniff.speedRun > 1)
                    //    roundedSpeedRun = Math.Round(sniff.speedRun / 7, 5);
                    //else
                    //    roundedSpeedRun = Math.Round(sniff.speedRun / 7, 6);

                    //sniff.speedWalk = (float)roundedSpeedWalk;
                    //sniff.speedRun = (float)roundedSpeedRun;
                    if (sniff.objectType != 3 && sniff.objectType != 5)
                        sniff.entry = -1;

                    // Is creature a TBC npc
                    Creature result = creatures.Find(a => a.Entry == sniff.entry.ToString());
                    if (result == null)
                        sniff.entry = -1;

                    if (sniff.entry != -1)
                    {
                        CreaturePacket updatePacket = creaturePackets.Find(a => a.entry == sniff.entry);
                        if (updatePacket.entry != sniff.entry)
                        {
                            creaturePackets.Add(sniff);
                            addedEntries.Add(sniff.entry);
                        }
                        else if (!createObjectPacket)
                        {
                            updatePacket.racialLeader = sniff.racialLeader;
                            updatePacket.creatureType = sniff.creatureType;
                            updatePacket.creatureFamily = sniff.creatureFamily;
                            updatePacket.rank = sniff.rank;
                            updatePacket.modelId1 = sniff.modelId1;
                            updatePacket.modelId2 = sniff.modelId2;
                            updatePacket.modelId3 = sniff.modelId3;
                            updatePacket.modelId4 = sniff.modelId4;

                            creaturePackets.RemoveAt(creaturePackets.FindIndex(a => a.entry == sniff.entry));
                            creaturePackets.Add(updatePacket);
                            //creaturePackets[creaturePackets.FindIndex(a => a.entry == sniff.entry)].racialLeader = sniff.racialLeader;
                            //creaturePackets[creaturePackets.FindIndex(a => a.entry == sniff.entry)].creatureType = sniff.creatureType;
                            //creaturePackets[creaturePackets.FindIndex(a => a.entry == sniff.entry)].creatureFamily = sniff.creatureFamily;
                            //creaturePackets[creaturePackets.FindIndex(a => a.entry == sniff.entry)].rank = sniff.rank;
                            //creaturePackets[creaturePackets.FindIndex(a => a.entry == sniff.entry)].modelId1 = sniff.modelId1;
                            //creaturePackets[creaturePackets.FindIndex(a => a.entry == sniff.entry)].modelId2 = sniff.modelId2;
                            //creaturePackets[creaturePackets.FindIndex(a => a.entry == sniff.entry)].modelId3 = sniff.modelId3;
                            //creaturePackets[creaturePackets.FindIndex(a => a.entry == sniff.entry)].modelId4 = sniff.modelId4;
                            //racialLeader = sniff.racialLeader;
                        }
                        else
                        {
                            updatePacket.speedWalk = sniff.speedWalk;
                            updatePacket.speedRun = sniff.speedRun;
                            updatePacket.scale = sniff.scale;
                            updatePacket.faction = sniff.faction;
                            updatePacket.unitFlags = sniff.unitFlags;
                            updatePacket.meleeBaseAttackTime = sniff.meleeBaseAttackTime;
                            updatePacket.rangedBaseAttackTime = sniff.rangedBaseAttackTime;
                            updatePacket.boundingRadius = sniff.boundingRadius;
                            updatePacket.combatReach = sniff.combatReach;
                            updatePacket.npcFlags = sniff.npcFlags;

                            creaturePackets.RemoveAt(creaturePackets.FindIndex(a => a.entry == sniff.entry));
                            creaturePackets.Add(updatePacket);
                        }
                    }
                    #region reset
                    sniff.objectType = -1;
                    sniff.entry = -1;
                    sniff.speedWalk = -1f;
                    sniff.speedRun = -1f;
                    sniff.scale = -1f;
                    sniff.faction = -1;
                    sniff.unitFlags = -1;
                    sniff.meleeBaseAttackTime = -1;
                    sniff.rangedBaseAttackTime = -1;
                    sniff.boundingRadius = -1f;
                    sniff.combatReach = -1f;
                    sniff.npcFlags = -1;
                    sniff.racialLeader = -1;
                    // Add Type Flags
                    sniff.creatureType = -1;
                    sniff.creatureFamily = -1;
                    sniff.rank = -1;
                    sniff.modelId1 = -1;
                    sniff.modelId2 = -1;
                    sniff.modelId3 = -1;
                    sniff.modelId4 = -1;

                    sniff.currentModel = -1;
                    #endregion
                }
            }
            return creaturePackets;
        }

        private void CompareMassUppdate(List<CreaturePacket> creaturePackets)
        {
            foreach (CreaturePacket sniff in creaturePackets)
            {
                bool creatureValueToUpdate = false;
                bool modelValueToUpdate = false;
                //string creatureName = "";
                string entryString = sniff.entry.ToString();
                string currentModelString = sniff.currentModel.ToString();
                Creature result = creatures.Find(a => a.Entry == entryString);
                Model modelResult = models.Find(a => a.ModelId == currentModelString);
                double roundedSpeedWalk;
                double roundedSpeedRun;
                if (sniff.speedWalk > 1)
                    roundedSpeedWalk = Math.Round(sniff.speedWalk / 2.5, 5);
                else
                    roundedSpeedWalk = Math.Round(sniff.speedWalk / 2.5, 6);

                if (sniff.speedRun > 1)
                    roundedSpeedRun = Math.Round(sniff.speedRun / 7, 5);
                else
                    roundedSpeedRun = Math.Round(sniff.speedRun / 7, 6);

                if (result == null)
                    continue;

                string creatureName = result.Name;

                string speedWalkString = (sniff.speedWalk != -1f ? (roundedSpeedWalk.ToString() != result.SpeedWalk ? " SpeedWalk=" + sniff.speedWalk.ToString() + "/2.5," : "") : "");
                string speedRunString = (sniff.speedRun != -1f ? (roundedSpeedRun.ToString() != result.SpeedRun ? " SpeedRun=" + sniff.speedRun.ToString() + "/7," : "") : "");
                string scaleString = (sniff.scale != -1f ? (sniff.scale.ToString() != result.Scale ? " Scale=" + sniff.scale.ToString() + "," : "") : "");
                string factionString = (sniff.faction != -1f ? (sniff.faction.ToString() != result.Faction ? " FactionAlliance=" + sniff.faction.ToString() + ", FactionHorde=" + sniff.faction.ToString() + "," : "") : "");
                string unitFlagsString = (sniff.unitFlags != -1 ? (sniff.unitFlags.ToString() != result.UnitFlags ? " UnitFlags=" + sniff.unitFlags.ToString() + "," : "") : "");
                string meleeBaseAttackTimeString = (sniff.meleeBaseAttackTime != -1 ? (sniff.meleeBaseAttackTime.ToString() != result.MeleeBaseAttackTime ? " MeleeBaseAttackTime=" + sniff.meleeBaseAttackTime.ToString() + "," : "") : "");
                string rangedBaseAttackTimeString = (sniff.rangedBaseAttackTime != -1 ? (sniff.rangedBaseAttackTime.ToString() != result.RangedBaseAttackTime ? " RangedBaseAttackTime=" + sniff.rangedBaseAttackTime.ToString() + "," : "") : "");
                string npcFlagsString = (sniff.npcFlags != -1 ? (sniff.npcFlags.ToString() != result.NpcFlags ? " NpcFlags=" + sniff.npcFlags.ToString() + "," : "") : "");
                string racialLeaderString = (sniff.racialLeader != -1 ? (sniff.racialLeader.ToString() != result.RacialLeader ? " RacialLeader=" + sniff.racialLeader.ToString() + "," : "") : "");
                string creatureTypeString = (sniff.creatureType != -1 ? (sniff.creatureType.ToString() != result.CreatureType ? " CreatureType=" + sniff.creatureType.ToString() + "," : "") : "");
                string creatureFamilyString = (sniff.creatureFamily != -1 ? (sniff.creatureFamily.ToString() != result.Family ? " Family=" + sniff.creatureFamily.ToString() + "," : "") : "");
                string rankString = (sniff.rank != -1 ? (sniff.rank.ToString() != result.Rank ? " Rank=" + sniff.rank.ToString() + "," : "") : "");
                string modelId1String = (sniff.modelId1 != -1 ? (sniff.modelId1.ToString() != result.ModelId1 ? " ModelId1=" + sniff.modelId1.ToString() + "," : "") : "");
                string modelId2String = (sniff.modelId2 != -1 ? (sniff.modelId2.ToString() != result.ModelId2 ? " ModelId2=" + sniff.modelId2.ToString() + "," : "") : "");
                string modelId3String = (sniff.modelId3 != -1 ? (sniff.modelId3.ToString() != result.ModelId3 ? " ModelId3=" + sniff.modelId3.ToString() + "," : "") : "");
                string modelId4String = (sniff.modelId4 != -1 ? (sniff.modelId4.ToString() != result.ModelId4 ? " ModelId4=" + sniff.modelId4.ToString() + "," : "") : "");

                if (speedWalkString + speedRunString + scaleString + factionString + unitFlagsString + meleeBaseAttackTimeString + rangedBaseAttackTimeString + npcFlagsString + racialLeaderString +
                    creatureTypeString + creatureFamilyString + rankString + modelId1String + modelId2String + modelId3String + modelId4String != "")
                    creatureValueToUpdate = true;

                if (creatureValueToUpdate)
                {
                    rtb_output.Text += "\n-- " + creatureName + " c." + entryString + "\nUPDATE creature_template SET" +
                        speedWalkString +
                        speedRunString +
                        scaleString +
                        factionString +
                        unitFlagsString +
                        meleeBaseAttackTimeString +
                        rangedBaseAttackTimeString +
                        npcFlagsString +
                        racialLeaderString +
                        creatureTypeString +
                        creatureFamilyString +
                        rankString +
                        modelId1String +
                        modelId2String +
                        modelId3String +
                        modelId4String +
                        " WHERE entry=" + sniff.entry.ToString() + ";\n";
                }

                //rtb_output.Text = "UPDATE creature_template SET" +
                //(sniff.speedWalk != -1f ? (roundedSpeedWalk.ToString() != result.SpeedWalk ? " SpeedWalk=" + sniff.speedWalk.ToString() + "/2.5," : "") : "") +
                //(sniff.speedRun != -1f ? (roundedSpeedRun.ToString() != result.SpeedRun ? " SpeedRun=" + sniff.speedRun.ToString() + "/7," : "") : "") +
                //(sniff.scale != -1f ? (sniff.scale.ToString() != result.Scale ? " Scale=" + sniff.scale.ToString() + "," : "") : "") +
                //(sniff.faction != -1f ? (sniff.faction.ToString() != result.Faction ? " FactionAlliance=" + sniff.faction.ToString() + ", FactionHorde=" + sniff.faction.ToString() + "," : "") : "") +
                //(sniff.unitFlags != -1 ? (sniff.unitFlags.ToString() != result.UnitFlags ? " UnitFlags=" + sniff.unitFlags.ToString() + "," : "") : "") +
                //(sniff.meleeBaseAttackTime != -1 ? (sniff.meleeBaseAttackTime.ToString() != result.MeleeBaseAttackTime ? " MeleeBaseAttackTime=" + sniff.meleeBaseAttackTime.ToString() + "," : "") : "") +
                //(sniff.rangedBaseAttackTime != -1 ? (sniff.rangedBaseAttackTime.ToString() != result.RangedBaseAttackTime ? " RangedBaseAttackTime=" + sniff.rangedBaseAttackTime.ToString() + "," : "") : "") +
                //(sniff.npcFlags != -1 ? (sniff.npcFlags.ToString() != result.NpcFlags ? " NpcFlags=" + sniff.npcFlags.ToString() + "," : "") : "") +
                //(sniff.racialLeader != -1 ? (sniff.racialLeader.ToString() != result.RacialLeader ? " RacialLeader=" + sniff.racialLeader.ToString() + "," : "") : "") +
                //(sniff.creatureType != -1 ? (sniff.creatureType.ToString() != result.CreatureType ? " CreatureType=" + sniff.creatureType.ToString() + "," : "") : "") +
                //(sniff.creatureFamily != -1 ? (sniff.creatureFamily.ToString() != result.Family ? " Family=" + sniff.creatureFamily.ToString() + "," : "") : "") +
                //(sniff.rank != -1 ? (sniff.rank.ToString() != result.Rank ? " Rank=" + sniff.rank.ToString() + "," : "") : "") +
                //(sniff.modelId1 != -1 ? (sniff.modelId1.ToString() != result.ModelId1 ? " ModelId1=" + sniff.modelId1.ToString() + "," : "") : "") +
                //(sniff.modelId2 != -1 ? (sniff.modelId2.ToString() != result.ModelId2 ? " ModelId2=" + sniff.modelId2.ToString() + "," : "") : "") +
                //(sniff.modelId3 != -1 ? (sniff.modelId3.ToString() != result.ModelId3 ? " ModelId3=" + sniff.modelId3.ToString() + "," : "") : "") +
                //(sniff.modelId4 != -1 ? (sniff.modelId4.ToString() != result.ModelId4 ? " ModelId4=" + sniff.modelId4.ToString() + "," : "") : "") +
                //" WHERE entry=" + sniff.entry.ToString() + ";\n";

                //entryString = sniff.entry.ToString();
                //sniff.currentModel.ToString();
                //result = creatures.FirstOrDefault(a => a.Entry == entryString);
                //modelResult = models.FirstOrDefault(a => a.ModelId == currentModelString);
                //creatureName = result.Name;
                if (modelResult != null)
                {
                    string boundingRadiusString = (sniff.boundingRadius != -1f ? (sniff.boundingRadius.ToString() != modelResult.Bounding_radius ? " bounding_radius=" + sniff.boundingRadius.ToString() + "," : "") : "");
                    string combatReachString = (sniff.combatReach != -1f ? (sniff.combatReach.ToString() != modelResult.Combat_reach ? " combat_reach=" + sniff.combatReach.ToString() + "," : "") : "");

                    if (boundingRadiusString + combatReachString != "")
                        modelValueToUpdate = true;

                    if (modelValueToUpdate)
                    {
                        rtb_output.Text += "\n-- Used by: " + creatureName + " c." + entryString + "\nUPDATE creature_model_info SET" +
                            boundingRadiusString +
                            combatReachString +
                            " WHERE modelid=" + sniff.currentModel.ToString() + ";\n";
                    }
                    //rtb_output.Text += "UPDATE creature_model_info SET" +
                    //(sniff.boundingRadius != -1f ? (sniff.boundingRadius.ToString() != modelResult.Bounding_radius ? " bounding_radius=" + sniff.boundingRadius.ToString() + "," : "") : "") +
                    //(sniff.combatReach != -1f ? (sniff.combatReach.ToString() != modelResult.Combat_reach ? " combat_reach=" + sniff.combatReach.ToString() + "," : "") : "") +
                    //" WHERE modelid=" + sniff.currentModel.ToString() + ";";
                }
            }
        }
    }
}
