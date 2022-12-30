using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Form_List
{
    public partial class TopluIslemler : Form
    {
        public TopluIslemler()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilenler ListBox içine eklenecek
            listBox1.Items.Clear();
            int ToplamElemanSayisi = checkedListBox1.CheckedItems.Count;
            for (int i = 0; i < ToplamElemanSayisi ; i++)
            {
                listBox1.Items.Add(checkedListBox1.CheckedItems[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tüm Seçenekleri Seçer
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

        private void BtnAktar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int ToplamElemanSayisi = checkedListBox1.CheckedItems.Count;
            for (int i = 0; i < ToplamElemanSayisi; i++)
            {
                listBox1.Items.Add(checkedListBox1.CheckedItems[i]);
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
            //string[] Girilen = { TxtAd.Text, TxtSoyad.Text, TxtTelefon.Text };
            //var Satir = new ListViewItem(Girilen);
            //listView1.Items.Add(Satir);
        }

        private void TxtAd_Enter(object sender, EventArgs e)
        {
             
            TxtAd.BackColor = Color.Yellow;
            TxtSoyad.BackColor = Color.White;
            TxtTelefon.BackColor = Color.White;
        }

        private void TxtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
               bool sonuc = Kontrol(TxtAd,TxtSoyad);
                if (sonuc)
                {
                    MessageBox.Show("Adınızı Girin ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtAd.Focus();
                }
                //if (TxtAd.Text !="")
                //{
                //    TxtSoyad.Focus();
                //}
                //else
                //{
                //    MessageBox.Show("Adınızı Girin ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    TxtAd.Focus();
                //}

            }
        }

        private bool Kontrol(TextBox TxtGiris, TextBox TxtSonraki)
        {
            bool bos = true;
            if (TxtGiris.Text !="")
            {
                bos = false;
                TxtSonraki.Focus();
            }
            return bos;
        }

        private void TxtSoyad_Enter(object sender, EventArgs e)
        {
            TxtAd.BackColor = Color.White;
            TxtSoyad.BackColor = Color.Yellow;
            TxtTelefon.BackColor = Color.White;
        }

        private void TxtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {

                bool sonuc = Kontrol(TxtSoyad, TxtTelefon);
                if (sonuc)
                {
                    MessageBox.Show("SoyAdınızı Girin ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtSoyad.Focus();
                }
            }
        }

        private void TxtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                Kontrol(TxtTelefon, TxtAd);
                Kaydet();
            }
        }
        public void Kaydet()
        {
            string[] Girilen = { TxtAd.Text, TxtSoyad.Text, TxtTelefon.Text };
            var Satir = new ListViewItem(Girilen);
            listView1.Items.Add(Satir);
            TxtTelefon.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtAd.Focus();
        }

        private void TxtTelefon_Enter(object sender, EventArgs e)
        {
            TxtAd.BackColor = Color.White;
            TxtSoyad.BackColor = Color.White;
            TxtTelefon.BackColor = Color.Yellow;
        }
    }
}
