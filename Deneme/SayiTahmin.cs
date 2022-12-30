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
    public partial class SayiTahmin : Form
    {
        public SayiTahmin()
        {
            InitializeComponent();
        }

        int sayi=0, tahmin_sayisi=0, puan=1000;

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            Random r = new Random();
            sayi = r.Next(100);
            label5.Text = "";
            label6.Text = "0";
            label7.Text = "1000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tahmin;
            tahmin_sayisi++;
            if (tahmin_sayisi<=10)
            {
                tahmin = int.Parse(textBox1.Text);
                label6.Text = tahmin_sayisi.ToString();
                if (sayi<tahmin)
                {
                    label5.Text = "TAhminizi azaltınız";
                    puan = puan - 100;
                    label7.Text = puan.ToString();
                }
                else if (tahmin<sayi)
                {
                    label5.Text = "Tahmininizi artırınız";
                    puan = puan - 100;
                    label7.Text = puan.ToString();
                }
                else if (tahmin==sayi)
                {
                    label5.Text = "Teblikler " + label6.Text + " defada bilip, " + label7.Text + "puan aldınız";
                    button2.Enabled = true;
                    button1.Enabled = false;
                }
                textBox1.Text = "";
            }
            else
            {
                textBox1.Enabled = false;
                MessageBox.Show("TAhmin hakkınız kalmadı oyun kapatılacak");
                this.Close();
            }
        }

        private void SayiTahmin_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;// button 1 e başılmaz
        }
    }
}
