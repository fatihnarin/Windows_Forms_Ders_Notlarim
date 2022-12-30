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
    public partial class ToolTipIpucu1 : Form
    {
        public ToolTipIpucu1()
        {
            InitializeComponent();
        }

        private void ToolTipIpucu1_Load(object sender, EventArgs e)
        {
            //tooltip1 özellikleri
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.ToolTipTitle = "Uyarı!";
            toolTip1.AutoPopDelay = 3000;
            toolTip1.AutomaticDelay = 200;

            //tooltip2 özellikleri
            toolTip2.ToolTipIcon = ToolTipIcon.Info;
            toolTip2.ToolTipTitle = "Bilgilendirme";
            toolTip2.AutoPopDelay = 2000;
            toolTip2.AutomaticDelay = 200;

            //Kontrollerin İpucu MEtinleri
            toolTip1.SetToolTip(this.textBox2, "Kulanıcı adı 5 karakter olmalı");
            toolTip1.SetToolTip(this.textBox3, "Şifre harf, sayı ve özel karakter içermelidir.");
            toolTip2.SetToolTip(this.textBox5, "Cep telefonu bilgisi zorunlu değil");
        }
    }
}
