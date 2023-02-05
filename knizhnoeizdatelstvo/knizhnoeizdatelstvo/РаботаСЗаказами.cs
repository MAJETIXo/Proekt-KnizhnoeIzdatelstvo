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
    public partial class РаботаСЗаказами : Form
    {
        public РаботаСЗаказами()
        {
            InitializeComponent();
        }

        private void заказBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.издательствоDataSet);

        }

        private void РабСЗаказами_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.издательствоDataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet.Состав_заказа". При необходимости она может быть перемещена или удалена.
            this.состав_заказаTableAdapter.Fill(this.издательствоDataSet.Состав_заказа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.издательствоDataSet.Заказ);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new Менеджер();
            frm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                if ((ComboBox2.Text == String.Empty) | (textBox2.Text == String.Empty))
                    textBox3.Text = "введите значения";
                else
                {
                    myCommand6.Parameters["@fiocl"].Value = ComboBox2.Text;
                    myCommand6.Parameters["@data"].Value = Convert.ToDateTime(TimePicker.Value);
                    myCommand6.Parameters["@fiosotr"].Value = textBox2.Text;


                    mySqlConnection.Open();
                    myCommand6.ExecuteNonQuery();
                    mySqlConnection.Close();
                    int result = (int)myCommand6.Parameters["@x"].Value;

                    if (result == 0)
                        textBox3.Text = "заказ добавлен";
                   if (result == 1)
                         textBox3.Text = "клиента нет в базе данных";



                    mySqlConnection.Open();
                    myCommand1.ExecuteNonQuery();
                    var table1 = new DataTable();
                    table1.Load(myCommand1.ExecuteReader());
                    mySqlConnection.Close();
                    GridView.DataSource = table1;
                }
            }
            catch { mySqlConnection.Close();
                textBox3.Text = "ошибка ввода данных";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox7.Text == String.Empty) | (textBox6.Text == String.Empty))
                textBox3.Text = "введите значения";
            else
            {
                 try
                {
                myCommand9.Parameters["@id"].Value = Convert.ToInt32(GridView.SelectedCells[0].Value.ToString());
                 }
                catch
                { textBox7.Text = "некорректный выбор заказа"; }
                myCommand9.Parameters["@idk"].Value = Convert.ToInt32(textBox7.Text);
                myCommand9.Parameters["@kol"].Value = Convert.ToInt32(textBox6.Text);
                try
                {
                   myCommand2.Parameters["@id"].Value = Convert.ToInt32(GridView.SelectedCells[0].Value.ToString());

                }
                catch
                { textBox3.Text = "некорректный выбор заказа"; }

              

                try
                {
                mySqlConnection.Open();
                myCommand9.ExecuteNonQuery();
                    mySqlConnection.Close();
                    int result = (int)myCommand9.Parameters["@x"].Value;
                   

                    if ((result == 0) | (result == 4))
                    {
                        textBox3.Text = "добавлено";

                    
                        mySqlConnection.Open();
                        myCommand1.ExecuteNonQuery();
                        var table1 = new DataTable();
                        table1.Load(myCommand1.ExecuteReader());
                        mySqlConnection.Close();
                        GridView.DataSource = table1;
                    
                    }
                    if (result == 1)
                        textBox3.Text = "указанный заказ не найден";
                    if (result == 2)
                        textBox3.Text = "книга не найдена";

                }
                catch
                {
                   textBox3.Text = "некорректный выбор заказа";
                    mySqlConnection.Close();
                }

                try
                {
                    mySqlConnection.Open();
                    myCommand2.ExecuteNonQuery();
                    var table = new DataTable();
                    table.Load(myCommand2.ExecuteReader());

                    mySqlConnection.Close();
                    GridView1.DataSource = table;
                }
                catch
                {
                   textBox3.Text = "некорректный выбор заказа";
                    mySqlConnection.Close();
                }



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == String.Empty)
                textBox3.Text = "введите номер";
            else
            {
                myCommand7.Parameters["@id"].Value = Convert.ToInt32(textBox5.Text);
                mySqlConnection.Open();
                myCommand7.ExecuteNonQuery();
                mySqlConnection.Close();
                int result = (int)myCommand7.Parameters["@x"].Value;

                if (result == 0)
                    textBox3.Text = "заказ удалён";
                if (result == 1)
                    textBox3.Text = "заказа не найден";

                mySqlConnection.Open();
                myCommand1.ExecuteNonQuery();
                var table1 = new DataTable();
                table1.Load(myCommand1.ExecuteReader());
                mySqlConnection.Close();
                GridView.DataSource = table1;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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
