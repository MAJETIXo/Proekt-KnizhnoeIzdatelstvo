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
    public partial class РаспРабот : Form
    {
        public РаспРабот()
        {
            InitializeComponent();
        }

        private void работаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.работаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.издательствоDataSet);

        }

        private void РаспРабот_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet.Работа". При необходимости она может быть перемещена или удалена.
            this.работаTableAdapter.Fill(this.издательствоDataSet.Работа);

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlCommand3.Parameters["@par"].Value = textBox4.Text;
            sqlConnection1.Open();
            sqlCommand3.ExecuteNonQuery();
            var table = new DataTable();
            table.Load(sqlCommand3.ExecuteReader());
            sqlConnection1.Close();
            GridView.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new Издатель();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((ComboBox2.Text == String.Empty) | (textBox2.Text == String.Empty) | (textBox3.Text == String.Empty) | (ComboBox1.Text == String.Empty))
                textBox5.Text = "введите значения";
            else
            {
                sqlCommand2.Parameters["@fio"].Value = ComboBox2.Text;
                sqlCommand2.Parameters["@book"].Value = textBox2.Text;
                sqlCommand2.Parameters["@rabota"].Value = textBox3.Text;
                sqlCommand2.Parameters["@tip"].Value = ComboBox1.Text;
                sqlConnection1.Open();
                sqlCommand2.ExecuteNonQuery();
                sqlConnection1.Close();
                int result = (int)sqlCommand2.Parameters["@x"].Value;

                if (result == 0)
                    textBox5.Text = "запись добавлена";
                if (result == 1)
                    textBox5.Text = "нет такого сотрудника";
                if (result == 2)
                    textBox5.Text = "нет такой книги";
                if (result == 3)
                    textBox5.Text = "этот сотрудник уже работает над этой книгой";

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
