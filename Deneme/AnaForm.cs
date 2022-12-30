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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void normalFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NormalForm normalForm = new NormalForm();
            normalForm.Show();

        }

        private void yavruFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YavruForm yavruForm = new YavruForm();
            yavruForm.MdiParent = this;
            yavruForm.Show();
        }

        private void listboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List1 list = new List1();
            list.MdiParent = this;
            list.Show();
        }

        private void dörtİşlemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dortİslem dortİslem = new Dortİslem();
            dortİslem.MdiParent = this;
            dortİslem.Show();
        }

        private void topluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopluIslemler topluIslemler = new TopluIslemler();
            topluIslemler.MdiParent = this;
            topluIslemler.Show();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapMakinesi hesapMakinesi = new HesapMakinesi();
            hesapMakinesi.Show();

        }

        private void işBaşvurusuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            İsBasvurusu isBasvurusu = new İsBasvurusu();
            isBasvurusu.Show();
        }

        private void örnekUygulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrnekUygulama ornekUygulama = new OrnekUygulama();
            ornekUygulama.Show();
        }

        private void constantÖrneğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Const constant = new Const();
            constant.Show();
        }

        private void comboBoxÖrneğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComboBoxOrnek comboBoxOrnek = new ComboBoxOrnek();
            comboBoxOrnek.Show();
        }

        private void fORMRENKDEĞİŞTİRMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenkDegis renkDegis = new RenkDegis();
            renkDegis.Show();
        }

        private void sAYITAHMİNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SayiTahmin sayiTahmin = new SayiTahmin();
            sayiTahmin.Show();
        }

        private void kronometreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kronometre kronometre = new Kronometre();
            kronometre.Show();
        }

        private void uygulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uygulama uygulama = new Uygulama();
            uygulama.Show();
        }

        private void listViewOrnek1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewOrnek1 listViewOrnek1 = new ListViewOrnek1();
            listViewOrnek1.Show();
        }

        private void listViewORnekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewORnek2 listViewORnek2 = new ListViewORnek2();
            listViewORnek2.Show();
        }

        private void barKullanımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarOrnegi barOrnegi = new BarOrnegi();
            barOrnegi.Show();
        }

        private void barOrnekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarOrnek barOrnek = new BarOrnek();
            barOrnek.Show();
        }

        private void barOrnek2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarOrnek1 barOrnek = new BarOrnek1();
            barOrnek.Show();
        }

        private void barOrnek2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BarOrnek2 barOrnek2 = new BarOrnek2();
            barOrnek2.Show();
        }

        private void toolTipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolTipIpucu toolTipIpucu = new ToolTipIpucu();
            toolTipIpucu.Show();
        }

        private void toolTipİpucu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolTipIpucu1 toolTipIpucu1 = new ToolTipIpucu1();
            toolTipIpucu1.Show();
        }

        private void errorProviderOrnekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ErrorProvederOrnek errorProvederOrnek = new ErrorProvederOrnek();
            errorProvederOrnek.Show();
        }

        private void numaricUpDownUygulamasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumaricUpDownUygulaması numaricUpDownUygulaması = new NumaricUpDownUygulaması();
            numaricUpDownUygulaması.Show();
        }

        private void formlarArasıGeçişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlarArasıGecis formlarArasıGecis = new FormlarArasıGecis();
            formlarArasıGecis.Show();
        }
    }
}
