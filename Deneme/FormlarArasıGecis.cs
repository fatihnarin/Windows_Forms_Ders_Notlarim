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
    public partial class FormlarArasıGecis : Form
    {
        public FormlarArasıGecis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormlarArasıGecis1cs f2 = new FormlarArasıGecis1cs();
            f2.label4.Text = textBox1.Text;
            double y1 = Convert.ToDouble(textBox2.Text);
            double y2 = Convert.ToDouble(textBox3.Text);
            double y3 = Convert.ToDouble(textBox4.Text);
            double ort = (y1 + y2 + y3) / 3;
            f2.label5.Text = Convert.ToString(ort);
            if (ort<50)
            {
                f2.label6.Text = "Başarısız";
            }
            else
            {
                f2.label6.Text = "Başarılı";
            }
            f2.ShowDialog();
        }
    }
}
