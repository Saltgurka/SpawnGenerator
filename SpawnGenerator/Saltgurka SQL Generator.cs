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

        private void btn_spawnGenerator_Click(object sender, EventArgs e)
        {
            Form SpawnGenerator = new SpawnGenerator();
            SpawnGenerator.Show();
        }

        private void btn_poolGenerator_Click(object sender, EventArgs e)
        {
            Form Pool = new Pool();
            Pool.Show();
        }

        private void btn_openTimestampSubtractor_Click(object sender, EventArgs e)
        {
            Form TimestampSubtractor = new Timestamp_Subtractor();
            TimestampSubtractor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Filterer = new frm_Filterer();
            Filterer.Show();
        }
    }
}
