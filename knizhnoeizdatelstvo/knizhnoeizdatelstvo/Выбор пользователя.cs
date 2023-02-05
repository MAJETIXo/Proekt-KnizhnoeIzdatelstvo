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
    public partial class vibpolz : Form
    {
        public vibpolz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Sotrudnik_Click(object sender, EventArgs e)
        {
            Form frm = new Авторизация();
            frm.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Klient_Click(object sender, EventArgs e)
        {
                Form frm = new klient();
                frm.Show();
                this.Hide();
        }
    }
}
