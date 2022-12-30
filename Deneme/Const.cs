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
    public partial class Const : Form
    {
        public Const()
        {
            InitializeComponent();
        }

        private void Const_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double Kdv_oranı = 0.18, Otv_oranı = 0.45;
            double fiyat = 0, kdv_turarı = 0, otv_tutarı = 0, toplam = 0;
            fiyat = Convert.ToDouble(textBox1.Text);
            kdv_turarı = fiyat * Kdv_oranı;
            otv_tutarı = fiyat * Otv_oranı;
            toplam = fiyat + kdv_turarı + otv_tutarı;
            textBox2.Text = Convert.ToString(kdv_turarı);
            textBox3.Text = Convert.ToString(otv_tutarı);
            textBox4.Text = Convert.ToString(toplam);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
