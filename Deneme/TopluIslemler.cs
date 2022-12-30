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
    public partial class TopluIslemler : Form
    {
        public TopluIslemler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            //int eSayisi = checkedListBox1.CheckedItems.Count;
            //for (int i = 0; i <eSayisi; i++)
            //{
            //    listBox1.Items.Add(checkedListBox1.CheckedItems[i]);
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int ToplamElemanSayisi = checkedListBox1.CheckedItems.Count;
            for (int i = 0; i < ToplamElemanSayisi; i++)
            {
                listBox1.Items.Add(checkedListBox1.CheckedItems[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (harfMi(txtAd.Text)==true && harfMi(txtSoyad.Text)==true && SayiMi(txtTelefon.Text)==true)
            {
                Kaydet();
            }
            else if (harfMi(txtAd.Text) == false)
            {
                MessageBox.Show("Ad harflerden oluşur", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAd.Text = "";
                txtAd.Focus();
            }
            else if (harfMi(txtSoyad.Text) == false)
            {
                MessageBox.Show("Soyad harflerden oluşur", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoyad.Text = "";
                txtSoyad.Focus();
            }
            else if (SayiMi(txtTelefon.Text) == false)
            {
                MessageBox.Show("Telefon numarası rakamlardan oluşur", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefon.Text = "";
                txtTelefon.Focus();
            }
            
            
        }

        private bool harfMi(string metin)
        {
            bool a = true;
            char[] karakter = metin.ToCharArray();
            for (int i = 0; i < metin.Length; i++)
            {
                if (!char.IsControl(karakter[i]) && !char.IsLetter(karakter[i]) && (karakter[i] != ' '))
                {
                    a = false;
                    return a;
                }
            }
            return a; 
        }

        private void txtAd_Enter(object sender, EventArgs e)
        {
            txtAd.BackColor = Color.Yellow;
            txtSoyad.BackColor = Color.White;
            txtTelefon.BackColor = Color.White;
          
        }
        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                bool sonuc = Kontrol(txtAd, txtSoyad);
                if (sonuc)
                {
                    MessageBox.Show("Adınızı Girin ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAd.Focus();
                }
                if (harfMi(txtAd.Text) == false)
                {
                    MessageBox.Show("Ad harflerden oluşur", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAd.Text = "";
                    txtAd.Focus();
                }
            }
        }
        private void txtSoyad_Enter(object sender, EventArgs e)
        {
            txtAd.BackColor = Color.White;
            txtSoyad.BackColor = Color.Yellow;
            txtTelefon.BackColor = Color.White;
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                bool sonuc = Kontrol(txtSoyad, txtTelefon);
                if (sonuc)
                {
                    MessageBox.Show("Soyadınızı Girin ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTelefon.Focus();
                }
                if (harfMi(txtSoyad.Text) == false)
                {
                    MessageBox.Show("Soyad harflerden oluşur", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoyad.Text = "";
                    txtSoyad.Focus();
                }
            }
        }

        private void txtTelefon_Enter(object sender, EventArgs e)
        {
            txtAd.BackColor = Color.White;
            txtSoyad.BackColor = Color.White;
            txtTelefon.BackColor = Color.Yellow;
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                bool sonuc = Kontrol(txtTelefon, txtAd);
                if (sonuc)
                {
                    MessageBox.Show("Telefonu Girin ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTelefon.Focus();
                   
                }
                if (SayiMi(txtTelefon.Text)==false)
                {
                    MessageBox.Show("Telefon numarası rakamlardan oluşur", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTelefon.Text = "";
                    txtTelefon.Focus();
                }                
                    Kaydet();                               
            }
        }
        private void Kaydet()
        {
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtTelefon.Text != "")
            {
                string[] girilen = { txtAd.Text, txtSoyad.Text, txtTelefon.Text };
                var satir = new ListViewItem(girilen);
                listView1.Items.Add(satir);
                txtTelefon.Text = "";
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtAd.Focus();
            }
            else if (txtAd.Text == "")
            {
                txtAd.Focus();
            }
            else if (txtSoyad.Text == "")
            {
                txtSoyad.Focus();
            }
            else if (txtTelefon.Text == "")
            {
                txtSoyad.Focus();
            }
            
        }
        private bool Kontrol(TextBox txtGiris, TextBox txtSonraki)
        {
            bool bos = true;
            if (txtGiris.Text != "")
            {
                bos = false;
                txtSonraki.Focus();
            }
            return bos;
        }
       private bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }


    }
}
