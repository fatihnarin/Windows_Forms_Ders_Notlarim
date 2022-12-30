using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    public partial class BarOrnegi : Form
    {
        public BarOrnegi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 25;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 50;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 75;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void BarOrnegi_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 1000;
            progressBar1.Step = 50;
        }
    }
}
