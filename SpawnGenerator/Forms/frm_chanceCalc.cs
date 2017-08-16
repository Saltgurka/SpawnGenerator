using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpawnGenerator.Forms
{
    public partial class frm_chanceCalc : Form
    {
        public frm_chanceCalc()
        {
            InitializeComponent();
        }

        private void btn_true_Click(object sender, EventArgs e)
        {
            int trueCount;

            if (!Int32.TryParse(txt_true.Text, out trueCount))
            {
                trueCount = 0;
            }

            trueCount++;

            txt_true.Text = trueCount.ToString();

            CalculateChance();
        }

        private void btn_false_Click(object sender, EventArgs e)
        {
            int falseCount;

            if (!Int32.TryParse(txt_false.Text, out falseCount))
            {
                falseCount = 0;
            }

            falseCount++;

            txt_false.Text = falseCount.ToString();

            CalculateChance();
        }

        private void CalculateChance()
        {
            int trueCount;
            int falseCount;
            decimal sum;
            decimal trueChance;
            decimal falseChance;

            if (!Int32.TryParse(txt_true.Text, out trueCount))
            {
                trueCount = 0;
            }
            if (!Int32.TryParse(txt_false.Text, out falseCount))
            {
                falseCount = 0;
            }

            sum = trueCount + falseCount;
            trueChance = (trueCount / sum);
            falseChance = (falseCount / sum);
            
            lbl_trueChance.Text = trueChance.ToString("p0");
            lbl_falseChance.Text = falseChance.ToString("p0");
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            CalculateChance();
        }
    }
}
