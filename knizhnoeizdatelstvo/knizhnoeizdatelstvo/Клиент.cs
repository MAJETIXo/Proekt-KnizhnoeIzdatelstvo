using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knizhnoeizdatelstvo
{
    public partial class klient : Form
    {
        public klient()
        {
            InitializeComponent();
        }

        private void zakaz_Click(object sender, EventArgs e)
        {
          
        }

        private void rukopis_Click(object sender, EventArgs e)
        {
           
        }

        private void katalog_Click(object sender, EventArgs e)
        {
            Form frm = new katalog();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new vibpolz();
            frm.Show();
            this.Hide();
        }
    }
}
