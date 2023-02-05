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
    public partial class АдминСотруд : Form
    {
        public АдминСотруд()
        {
            InitializeComponent();
        }

        private void сотрудникBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.издательствоDataSet);

        }

        private void АдминСотруд_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.издательствоDataSet.Сотрудник);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void полLabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new Издатель();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlCommand4.Parameters["@par"].Value = textBox7.Text;
            sqlConnection1.Open();
            sqlCommand4.ExecuteNonQuery();
            var table = new DataTable();
            table.Load(sqlCommand4.ExecuteReader());
            sqlConnection1.Close();
            GridView.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text == String.Empty) | (textBox2.Text == String.Empty) | (textBox3.Text == String.Empty) | (ComboBox1.Text == String.Empty) | (ComboBox2.Text == String.Empty))
                textBox5.Text = "введите значения";
            else
            {
                sqlCommand2.Parameters["@fio"].Value = textBox1.Text;
                sqlCommand2.Parameters["@age"].Value = Convert.ToInt32(textBox2.Text);
                sqlCommand2.Parameters["@stage"].Value = Convert.ToInt32(textBox3.Text);
                sqlCommand2.Parameters["@pol"].Value = ComboBox1.Text;
                sqlCommand2.Parameters["@dol"].Value = ComboBox2.Text;
                sqlConnection1.Open();
                sqlCommand2.ExecuteNonQuery();
                sqlConnection1.Close();
                int result = (int)sqlCommand2.Parameters["@x"].Value;

                if (result == 0)
                    textBox5.Text = "запись добавлена";
                if (result == 1)
                    textBox5.Text = "такой сотрудник уже существует";
                if (result == 2)
                    textBox5.Text = "несовершеннолетний";

                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                var table = new DataTable();
                table.Load(sqlCommand1.ExecuteReader());
                sqlConnection1.Close();
                GridView.DataSource = table;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == String.Empty)
                textBox5.Text = "введите ID";
            else
            {
                try
               {
                    sqlCommand3.Parameters["@fio"].Value =textBox4.Text;
                    sqlConnection1.Open();
                    sqlCommand3.ExecuteNonQuery();
                    sqlConnection1.Close();
                    int result = (int)sqlCommand3.Parameters["@x"].Value;

                    if (result == 0)
                        textBox5.Text = "сотрудник удален";
                    if (result == 1)
                        textBox5.Text = "несуществующий сотрудник";
                }
                catch
                {
                    textBox5.Text = "сотрудник не может быть удалён";
                    sqlConnection1.Close();
                }
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                var table = new DataTable();
                table.Load(sqlCommand1.ExecuteReader());
                sqlConnection1.Close();
                GridView.DataSource = table;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }
    }
}
