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
    public partial class İsBasvurusu : Form
    {
        public İsBasvurusu()
        {
            InitializeComponent();
            string[] diller = {"Türkçe","İngiizce","Almanca","Arapça","Fransızca",
                "Azerice","Çince","OSmanlıca","İtalyanca"};
            checkedListBox1.Items.AddRange(diller);// listbox a dilleri ekler
            checkedListBox1.MultiColumn = true;//kolonlu yapar
            checkedListBox1.CheckOnClick = true;//listbox da dilleri tek tıklamada seçer
            YeniDilEk.Enabled = false; // yeni dil ekleme butonunu pasif hale çevilir

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                YeniDilEk.Enabled = false;
            else
                YeniDilEk.Enabled = true;
        }

        private void YeniDilEk_Click(object sender, EventArgs e)
        {
            if (textBox2.Text!="")
            {
                if (checkedListBox1.Items.Contains(textBox2.Text) == false)// yazılan dil kayıtlı değilse
                    checkedListBox1.Items.Add(textBox2.Text);//kayıt edilir.
                else
                    MessageBox.Show("Belirtilen dil zaten eklidir!");
                textBox2.Text = "";
            }
        }

        private void SecDilSi_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
        }

        private void SecKaldır_Click(object sender, EventArgs e)
        {
            while (checkedListBox1.CheckedIndices.Count>0)

            {
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = textBox1.Text;
            string diller = "", mezuniyeti = "";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                diller += ", " + checkedListBox1.CheckedItems[i];
            }
            diller = diller.Substring(2);// ilk iki karetteri çıkarır.
            label5.Text = diller;

            if (radioButton1.Checked)
                mezuniyeti = radioButton1.Text;
            else if (radioButton2.Checked)
                mezuniyeti = radioButton2.Text;
            else if (radioButton3.Checked)
                mezuniyeti = radioButton3.Text;
            else if (radioButton4.Checked)
                mezuniyeti = radioButton4.Text;

            label7.Text = mezuniyeti;
            textBox1.Text = ""; textBox2.Text = "";
        }
    }
}
