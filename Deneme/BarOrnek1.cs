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
    public partial class BarOrnek1 : Form
    {
        public BarOrnek1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i==1)
            {
                timer1.Stop();
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();


            }

        }

        private void BarOrnek1_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 10;
            timer1.Interval = 5000;
            timer1.Start();
        }
    }
}
