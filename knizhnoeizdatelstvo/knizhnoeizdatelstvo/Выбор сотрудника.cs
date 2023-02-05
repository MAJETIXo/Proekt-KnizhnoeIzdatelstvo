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
    public partial class vibsotr : Form
    {
        public vibsotr()
        {
            InitializeComponent();
        }

        private void vibsotr_Load(object sender, EventArgs e)
        {

        }

        private void izadatel_Click(object sender, EventArgs e)
        {
            Form frm = new Издатель();
            frm.Show();
            this.Hide();
        }

        private void Manager_Click(object sender, EventArgs e)
        {
            Form frm = new Менеджер();
            frm.Show();
            this.Hide();
        }

        private void proizvod_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new Авторизация();
            frm.Show();
            this.Hide();
        }
    }
}
