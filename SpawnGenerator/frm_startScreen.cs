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

        private void PoolGen_FormClosed(object sender, FormClosedEventArgs e)
        {
            poolGen = null;
        }

        private void singleSpawnGenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form SpawnGenerator = new frm_spawnGeneratorManual();
            SpawnGenerator.Show();
        }

        private void multiSpawnGenToolStripMenuItem1_Click(object sender, EventArgs e)
        {

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
    }
}
