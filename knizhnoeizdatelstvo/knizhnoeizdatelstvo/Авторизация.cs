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
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "student" & textBox2.Text == "12345")
                {
                    Form frm = new vibsotr();
                    frm.Show();
                    this.Hide();
                }
                if (textBox1.Text != "student" | textBox2.Text != "12345")
                {
                    textBox3.Text = "Неверные данные";
                }
            }
            catch { textBox3.Text = "Неверные данные";  }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new vibpolz();
            frm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
