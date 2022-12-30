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
    public partial class Uygulama : Form
    {
        public Uygulama()
        {
            InitializeComponent();
        }

        private void Uygulama_Load(object sender, EventArgs e)
        {
            textBox2.Text = "0";textBox3.Text = "1"; radioButton1.Checked = true;
            textBox4.Enabled = false; textBox5.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double birimfiyatı = Convert.ToDouble(textBox2.Text);
                double adeti = Convert.ToDouble(textBox3.Text);
                double tutar = birimfiyatı * adeti;
                double kdv = 0;
                if (radioButton1.Checked == true)
                {
                    kdv = tutar * 0.25;
                }
                else if (radioButton2.Checked == true)
                    kdv = tutar * 0.18;
                else if (radioButton3.Checked = true)
                    kdv = tutar * 0.08;


                tutar = tutar + kdv;
                if (checkBox1.Checked==true)                
                    tutar = tutar - tutar * 0.1;

                textBox4.Text = Convert.ToString(kdv);
                textBox5.Text = Convert.ToString(tutar);
                
            }
            catch (Exception)
            {                
            }
            

        }
    }
}
