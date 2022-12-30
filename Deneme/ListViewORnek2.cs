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
    public partial class ListViewORnek2 : Form
    {
        public ListViewORnek2()
        {
            InitializeComponent();
        }

        private void ListViewORnek2_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("TC KİMLİK NO", 150);
            listView1.Columns.Add("ADI SOYADI", 200);
            listView1.Columns.Add("YAŞI", 50);
            listView1.Columns.Add("MEZUNİYET", 150);
            listView1.Columns.Add("CİNSİYETİ", 125);
            listView1.Columns.Add("DOĞUMYER",125);
            listView1.Columns.Add("TELEFON NO", 130);

            string[] mezuniyet = { "İlköğretim", "Ortaöğretim", "Lisans", "Yüksek Lisans", "Doktora" };
            comboBox1.Items.AddRange(mezuniyet);
            kayitsayisiyaz();
        }

        private void kayitsayisiyaz()
        {
            int kayiysayisi = listView1.Items.Count;
            label8.Text = Convert.ToString(kayiysayisi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tc = "", adsoyad = "", yas = "", mezuniyet = "", cinsiyet = "", dogumyeri = "", telefon = "";
            tc = textBox1.Text;
            adsoyad = textBox2.Text;
            yas = textBox3.Text;
            mezuniyet = comboBox1.Text;
            if (radioButton1.Checked==true)
            {
                cinsiyet = radioButton1.Text;
            }
            else if (radioButton2.Checked==true)
            {
                cinsiyet = radioButton2.Text;
            }
            dogumyeri = textBox4.Text;
            telefon = textBox5.Text;
            string[] bilgiler = { tc, adsoyad, yas, mezuniyet, cinsiyet, dogumyeri, telefon };
            bool aranankayitkontrolu = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text==textBox1.Text)
                {
                    aranankayitkontrolu = true;
                    MessageBox.Show(textBox1.Text + "TC kimlik numarası kayıtlarda zateb mevcuttur");
                    break;
                }
            }
            if (aranankayitkontrolu==false)
            {
                ListViewItem lst = new ListViewItem(bilgiler);
                if (tc != "" && adsoyad != "" && yas != "" && mezuniyet != "" && cinsiyet != "" && dogumyeri != "" && telefon != "")
                {
                    listView1.Items.Add(lst);
                }
                else
                    MessageBox.Show("kayıt bilgilerinde eksiklik var");
            }
            kayitsayisiyaz();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int secilensayisi = listView1.CheckedItems.Count;

            foreach (ListViewItem secilikayitbilgisi in listView1.CheckedItems)
            {
                secilikayitbilgisi.Remove();
            }
            MessageBox.Show(secilensayisi.ToString() + " adet kayit silindi");
            kayitsayisiyaz();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int secilensayisi = listView1.SelectedItems.Count;

            foreach (ListViewItem secilikayitbilgisi in listView1.SelectedItems)
            {
                secilikayitbilgisi.Remove();
            }
            MessageBox.Show(secilensayisi.ToString() + " adet kayit silindi");
            kayitsayisiyaz();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            kayitsayisiyaz();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool aranankayitkontrolu = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text==textBox1.Text)
                {
                    aranankayitkontrolu = true;
                    textBox2.Text = listView1.Items[i].SubItems[1].Text;
                    textBox3.Text = listView1.Items[i].SubItems[2].Text;
                    comboBox1.Text = listView1.Items[i].SubItems[3].Text;
                    if (listView1.Items[i].SubItems[4].Text=="BAY")
                    {
                        radioButton1.Checked = true;
                    }
                    else if (listView1.Items[i].SubItems[4].Text == "BAYAN")
                    {
                        radioButton2.Checked = true;
                    }
                    textBox4.Text = listView1.Items[i].SubItems[5].Text;
                    textBox5.Text = listView1.Items[i].SubItems[6].Text;
                    textBox2.Enabled = false;textBox3.Enabled = false;comboBox1.Enabled = false;
                    groupBox1.Enabled = false;textBox4.Enabled = false; textBox5.Enabled = false;
                   
                }
            }
            if (aranankayitkontrolu==false)
            {
                MessageBox.Show(textBox1.Text + "TC kimlik numaralı kayıt bulunaması");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true; textBox3.Enabled = true; comboBox1.Enabled = true;
            groupBox1.Enabled = true; textBox4.Enabled = true; textBox5.Enabled = true;
        }
    }
}
