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
    public partial class РаботаСКлиентами : Form
    {
        public РаботаСКлиентами()
        {
            InitializeComponent();
        }

        private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.издательствоDataSet);

        }

        private void РабСКлиентами_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.издательствоDataSet.Клиент);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == String.Empty) | (textBox2.Text == String.Empty))
                textBox3.Text = "введите значения";
            else
            {
                sqlCommand1.Parameters["@fio"].Value = textBox1.Text;
                sqlCommand1.Parameters["@nomer"].Value = textBox2.Text;

                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                int result = (int)sqlCommand1.Parameters["@x"].Value;

                if (result == 0)
                    textBox3.Text = "запись добавлена";
                if (result == 1)
                    textBox3.Text = "клиент уже существует";

                sqlConnection1.Open();
                sqlCommand2.ExecuteNonQuery();
                var table = new DataTable();
                table.Load(sqlCommand2.ExecuteReader());
                sqlConnection1.Close();
                GridView.DataSource = table;
            }
        }

        //private void button2_Click(object sender, EventArgs e)
        //{

        //    if (textBox4.Text == String.Empty)
        //        textBox3.Text = "введите ID";
        //    else
        //    {
        //        try
        //        {
        //            sqlCommand3.Parameters["@id"].Value = Convert.ToInt32(textBox4.Text);
        //            sqlConnection1.Open();
        //            sqlCommand3.ExecuteNonQuery();
        //            sqlConnection1.Close();
        //            int result = (int)sqlCommand3.Parameters["@x"].Value;

        //            if (result == 0)
        //                textBox3.Text = "клиент удалён";
        //            if (result == 1)
        //                textBox3.Text = "несуществующий ID";
        //        }
        //        catch
        //        {
        //            textBox3.Text = "клиент не может быть удалён";
        //            sqlConnection1.Close();
        //        }
        //        sqlConnection1.Open();
        //        sqlCommand2.ExecuteNonQuery();
        //        var table = new DataTable();
        //        table.Load(sqlCommand2.ExecuteReader());
        //        sqlConnection1.Close();
        //        GridView.DataSource = table;
        //    }
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox5.Text == String.Empty) | (textBox6.Text == String.Empty))
                textBox3.Text = "введите все данные";
            else
            {


                try
                {
                    sqlCommand4.Parameters["@id"].Value = Convert.ToInt32(textBox5.Text);
                    sqlCommand4.Parameters["@newnomer"].Value = textBox6.Text;
                    sqlConnection1.Open();
                    sqlCommand4.ExecuteNonQuery();
                    sqlConnection1.Close();
                    int result = (int)sqlCommand4.Parameters["@x"].Value;

                    if (result == 0)
                        textBox3.Text = "номер изменен";
                    if (result == 1)
                        textBox3.Text = "несуществующий ID";
                    sqlConnection1.Open();
                    sqlCommand2.ExecuteNonQuery();
                    var table = new DataTable();
                    table.Load(sqlCommand2.ExecuteReader());
                    sqlConnection1.Close();
                    GridView.DataSource = table;
                }
                catch { textBox3.Text = "ошибка ввода данных";
                    sqlConnection1.Close();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlCommand5.Parameters["@par"].Value = textBox7.Text;
            sqlConnection1.Open();
            sqlCommand5.ExecuteNonQuery();
            var table = new DataTable();
            table.Load(sqlCommand5.ExecuteReader());
            sqlConnection1.Close();
            GridView.DataSource = table;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new Менеджер();
            frm.Show();
            this.Hide();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }
    }
}
