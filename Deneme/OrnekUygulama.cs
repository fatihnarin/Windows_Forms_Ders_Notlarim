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
    public partial class OrnekUygulama : Form
    {
        public OrnekUygulama()
        {
            InitializeComponent();
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tcno = "", adsoyad = "", cinsiyet = "", mezuniyet = "", diller = "", uzmanlık = "";
            tcno = textBox1.Text;
            adsoyad = textBox2.Text;
            if (radioButton1.Checked == true)
            {
                cinsiyet = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                cinsiyet = radioButton2.Text;
            }
            if (radioButton3.Checked == true)
                mezuniyet = radioButton3.Text;
            else if (radioButton4.Checked == true)
                mezuniyet = radioButton4.Text;
            else if (radioButton5.Checked == true)
                mezuniyet = radioButton5.Text;
            else if (radioButton6.Checked == true)
                mezuniyet = radioButton6.Text;

            if (checkBox1.Checked == true)
                diller = diller + "," + checkBox1.Text;
            if (checkBox2.Checked == true)
                diller = diller + "," + checkBox2.Text;
            if (checkBox3.Checked == true)
                diller = diller + "," + checkBox3.Text;
            if (checkBox4.Checked == true)
                diller = diller + "," + checkBox4.Text;
            if (checkBox5.Checked == true)
                diller = diller + "," + checkBox5.Text;
            if (checkBox6.Checked == true)
                diller = diller + "," + checkBox6.Text;

            diller = diller.Substring(1);

            if (checkBox7.Checked == true)
                uzmanlık = uzmanlık + "," + checkBox7.Text;
            if (checkBox8.Checked == true)
                uzmanlık = uzmanlık + "," + checkBox8.Text;
            if (checkBox9.Checked == true)
                uzmanlık = uzmanlık + "," + checkBox9.Text;
            if (checkBox10.Checked == true)
                uzmanlık = uzmanlık + "," + checkBox10.Text;
            if (checkBox11.Checked == true)
                uzmanlık = uzmanlık + "," + checkBox11.Text;
            if (checkBox12.Checked == true)
                uzmanlık = uzmanlık + "," + checkBox12.Text;

            uzmanlık = uzmanlık.Substring(1);

            listBox1.Items.Add("TC NO:" + tcno + " | ADı SOYADI:" + adsoyad + " | CİNSİYETİ:" + cinsiyet + " | DİLLER:" + diller + " | UZMANLIK:" + uzmanlık);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked =false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
        }
    }
}
