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
    public partial class BarOrnek2 : Form
    {
        public BarOrnek2()
        {
            InitializeComponent();
        }
        int dakika = 0, saniye = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            dakika = 0; saniye = 0;
            timer1.Start();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye==60)
            {
                dakika++;
                saniye = 0;
            }
            label2.Text = Convert.ToString(dakika);
            label3.Text = Convert.ToString(saniye);
            progressBar1.Value = dakika;
            progressBar2.Value = saniye;
        }

        private void BarOrnek2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            label2.Text = "0";
            label3.Text = "0";
            progressBar1.Maximum = 59;
            progressBar2.Maximum = 59;
            button2.Enabled = false;

        }
    }
}
