using SpawnGenerator.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpawnGenerator
{
    public partial class Saltgurka_SQL_Generator : Form
    {
        public Saltgurka_SQL_Generator()
        {
            InitializeComponent();
        }

        Form singleSpawn;
        Form multiSpawn;
        Form poolGen;
        Form filterer;
        Form timestampSubtractor;
        Form spellPacketTimer;
        Form chanceCalc;
        Form speedSetter;
        Form waypointGen;
        Form dBImporter;
        Form textParser;
        Form petSpells;
        Form templateFixer;

        private void btn_spawnGenerator_Click(object sender, EventArgs e)
        {
            Form SpawnGenerator = new frm_spawnGeneratorManual();
            SpawnGenerator.Show();
        }

        private void btn_poolGenerator_Click(object sender, EventArgs e)
        {
            Form Pool = new frm_poolGenerator();
            Pool.Show();
        }

        private void btn_openTimestampSubtractor_Click(object sender, EventArgs e)
        {
            Form TimestampSubtractor = new frm_timestampSubtractor();
            TimestampSubtractor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Filterer = new frm_filterer();
            Filterer.Show();
        }

        private void singleSpawnGenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (singleSpawn == null)
            {
                singleSpawn = new frm_spawnGeneratorManual();
                singleSpawn.MdiParent = this;
                singleSpawn.FormClosed += SingleSpawn_FormClosed;
                singleSpawn.Show();
            }
            else
            {
                singleSpawn.Activate();
            }
        }

        private void SingleSpawn_FormClosed(object sender, FormClosedEventArgs e)
        {
            singleSpawn = null;
        }

        private void multiSpawnGenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (multiSpawn == null)
            {
                multiSpawn = new frm_multiSpawnGen();
                multiSpawn.MdiParent = this;
                multiSpawn.FormClosed += MultiSpawn_FormClosed;
                multiSpawn.Show();
            }
            else
            {
                multiSpawn.Activate();
            }
        }

        private void MultiSpawn_FormClosed(object sender, FormClosedEventArgs e)
        {
            multiSpawn = null;
        }

        private void timestampSubtractorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timestampSubtractor == null)
            {
                timestampSubtractor = new frm_timestampSubtractor();
                timestampSubtractor.MdiParent = this;
                timestampSubtractor.FormClosed += TimestampSubtractor_FormClosed;
                timestampSubtractor.Show();
            }
        }

        private void TimestampSubtractor_FormClosed(object sender, FormClosedEventArgs e)
        {
            timestampSubtractor = null;
        }

        private void sniffPacketFiltererToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(filterer == null)
            {
                filterer = new frm_filterer();
                filterer.MdiParent = this;
                filterer.FormClosed += Filterer_FormClosed;
                filterer.Show();
            }
        }

        private void Filterer_FormClosed(object sender, FormClosedEventArgs e)
        {
            filterer = null;
        }

        private void poolGeneratorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (poolGen == null)
            {
                poolGen = new frm_poolGenerator();
                poolGen.MdiParent = this;
                poolGen.FormClosed += PoolGen_FormClosed;
                poolGen.Show();
            }
        }

        private void spellPacketTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (spellPacketTimer == null)
            {
                spellPacketTimer = new frm_spellPacketTimer();
                spellPacketTimer.MdiParent = this;
                spellPacketTimer.FormClosed += SpellPacketTimer_FormClosed;
                spellPacketTimer.Show();
            }
        }

        private void SpellPacketTimer_FormClosed(object sender, FormClosedEventArgs e)
        {
            spellPacketTimer = null;
        }

        private void PoolGen_FormClosed(object sender, FormClosedEventArgs e)
        {
            poolGen = null;
        }


        private void chanceCalcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chanceCalc == null)
            {
                chanceCalc = new frm_chanceCalc();
                chanceCalc.MdiParent = this;
                chanceCalc.FormClosed += ChanceCalc_FormClosed;
                chanceCalc.Show();
            }
        }

        private void ChanceCalc_FormClosed(object sender, FormClosedEventArgs e)
        {
            chanceCalc = null;
        }

        private void speedSetterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (speedSetter == null)
            {
                speedSetter = new frm_speedSetter();
                speedSetter.MdiParent = this;
                speedSetter.FormClosed += SpeedSetter_FormClosed;
                speedSetter.Show();
            }
        }

        private void SpeedSetter_FormClosed(object sender, FormClosedEventArgs e)
        {
            speedSetter = null;
        }


        private void waypointGenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (waypointGen == null)
            {
                waypointGen = new frm_waypointGen();
                waypointGen.MdiParent = this;
                waypointGen.FormClosed += WaypointGen_FormClosed;
                waypointGen.Show();
            }
        }

        private void WaypointGen_FormClosed(object sender, FormClosedEventArgs e)
        {
            waypointGen = null;
        }

        private void dBImporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dBImporter == null)
            {
                dBImporter = new frm_DBImport();
                dBImporter.MdiParent = this;
                dBImporter.FormClosed += DBImporter_FormClosed;
                dBImporter.Show();
            }
        }

        private void DBImporter_FormClosed(object sender, FormClosedEventArgs e)
        {
            dBImporter = null;
        }

        private void textParserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textParser == null)
            {
                textParser = new frm_textParser();
                textParser.MdiParent = this;
                textParser.FormClosed += TextParser_FormClosed;
                textParser.Show();
            }
        }

        private void TextParser_FormClosed(object sender, FormClosedEventArgs e)
        {
            textParser = null;
        }

        private void petSpellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (petSpells == null)
            {
                petSpells = new frm_petSpells();
                petSpells.MdiParent = this;
                petSpells.FormClosed += PetSpells_FormClosed;
                petSpells.Show();
            }
        }

        private void PetSpells_FormClosed(object sender, FormClosedEventArgs e)
        {
            petSpells = null;
        }

        private void templateFixerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (templateFixer == null)
            {
                templateFixer = new frm_templateFixer();
                templateFixer.MdiParent = this;
                templateFixer.FormClosed += TemplateFixer_FormClosed;
                templateFixer.Show();
            }
        }

        private void TemplateFixer_FormClosed(object sender, FormClosedEventArgs e)
        {
            templateFixer = null;
        }

        private void singleSpawnGenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form SpawnGenerator = new frm_spawnGeneratorManual();
            SpawnGenerator.Show();
        }

        private void multiSpawnGenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form MultiSpawn = new frm_multiSpawnGen();
            MultiSpawn.Show();
        }

        private void timestampSubtractorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form TimestampSubtractor = new frm_timestampSubtractor();
            TimestampSubtractor.Show();
        }

        private void sniffPacketFiltererToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Filterer = new frm_filterer();
            Filterer.Show();
        }

        private void poolGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Pool = new frm_poolGenerator();
            Pool.Show();
        }

        private void btn_loginSaveAndTest_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.User = txt_loginUser.Text;
            Properties.Settings.Default.Password = txt_loginPassword.Text;
            Properties.Settings.Default.Host = txt_loginHost.Text;
            Properties.Settings.Default.Port = txt_loginPort.Text;
            Properties.Settings.Default.Database = txt_loginDatabases.Text;
            Properties.Settings.Default.Save();
        }

        private void Saltgurka_SQL_Generator_Load(object sender, EventArgs e)
        {
            txt_loginUser.Text = Properties.Settings.Default.User;
            txt_loginPassword.Text = Properties.Settings.Default.Password;
            txt_loginHost.Text = Properties.Settings.Default.Host;
            txt_loginPort.Text = Properties.Settings.Default.Port;
            txt_loginDatabases.Text = Properties.Settings.Default.Database;
        }

        private void dBLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_DBLogin.Visible = !panel_DBLogin.Visible;
        }

        private void petSpellsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form petSpells = new frm_petSpells();
            petSpells.Show();
        }


    }
}
