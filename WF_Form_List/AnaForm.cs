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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void normalFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NormalForm normalform = new NormalForm();
            normalform.Show();
        }

        private void yavruFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YavruForm yavruform = new YavruForm();
            yavruform.MdiParent = this;
            yavruform.Show();

        }

        private void listboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List list = new List();
            list.MdiParent = this;
            list.Show();
        }

        private void dortİslemToolStripMenuItem_Click(object sender, EventArgs e)
        {


            dortislem drtis = new dortislem();
            drtis.MdiParent = this;
            drtis.Show();

        }

        private void topluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopluIslemler tpl = new TopluIslemler();
            tpl.MdiParent = this;
            tpl.Show();
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
