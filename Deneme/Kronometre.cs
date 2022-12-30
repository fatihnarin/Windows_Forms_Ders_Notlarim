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
    public partial class Kronometre : Form
    {
        public Kronometre()
        {
            InitializeComponent();
        }

        int dakika = 0, saniye = 1,salise=1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            dakika++;
            label4.Text = Convert.ToString(dakika);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (saniye==60)
            {
                saniye = 0;
            }
            label5.Text = Convert.ToString(saniye);
            saniye++;
        }

   

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (salise == 100)
            {
                salise = 0;

            }
            label6.Text = Convert.ToString(salise);
            salise++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();timer2.Stop();timer3.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();timer2.Start();timer3.Start();
        }

        private void Kronometre_Load(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
            timer2.Interval = 1000;
            timer3.Interval = 10;
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
        }
    }
}
