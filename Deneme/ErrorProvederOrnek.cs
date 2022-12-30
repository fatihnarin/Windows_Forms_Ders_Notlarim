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
    public partial class ErrorProvederOrnek : Form
    {
        public ErrorProvederOrnek()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength<11)
            {
                errorProvider1.SetError(textBox1,"TC kimlik no 11 karakter olmalıdır!");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void ErrorProvederOrnek_Load(object sender, EventArgs e)
        {
            errorProvider1.BlinkRate = 400;// yanıp sönme hızı
            errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;// yanıp sönme sitili
            textBox1.MaxLength = 11;
        }
    }
}
