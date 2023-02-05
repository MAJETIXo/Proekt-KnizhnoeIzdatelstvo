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
    public partial class Издатель : Form
    {
        public Издатель()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Работа с авторами")
            {
                Form frm = new РаботаСАвторами();
                frm.Show();
                this.Hide();
            }

            if (comboBox1.Text == "Работа с договорами")
            {
                Form frm = new РаботаСДоговорами();
                frm.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Распределение работ")
            {
                Form frm = new РаспРабот();
                frm.Show();
                this.Hide();
            }

            if (comboBox1.Text == "Работа с рукописями")
            {
                Form frm = new РаботаСРукоп();
                frm.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Администрирование сотрудников")
            {
                Form frm = new АдминСотруд();
                frm.Show();
                this.Hide();
            }
            if ((comboBox1.Text != "Работа с авторами") | (comboBox1.Text != "Работа с договорами") | (comboBox1.Text != "Распределение работ") | (comboBox1.Text != "Работа с рукописями") | (comboBox1.Text != "Администрирование сотрудников"))
            {
                textBox1.Text = "Ошибка выбора";
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form frm = new vibsotr();
            frm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
