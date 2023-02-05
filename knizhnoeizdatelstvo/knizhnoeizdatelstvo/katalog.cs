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
    public partial class katalog : Form
    {
        public katalog()
        {
            InitializeComponent();
        }

        private void katalog_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet1.Каталог". При необходимости она может быть перемещена или удалена.
            this.каталогTableAdapter.Fill(this.издательствоDataSet1.Каталог);

        }

        private void каталогDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new klient();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Text = "   ";
            if (textBox1.Text == String.Empty)
            {
                sqlCommand1.Parameters["@price1"].Value = 0;
                sqlCommand2.Parameters["@price1"].Value = 0;
                sqlCommand3.Parameters["@price1"].Value = 0;
                sqlCommand4.Parameters["@price1"].Value = 0;
                sqlCommand5.Parameters["@price1"].Value = 0;
            }
            else
            {
                sqlCommand1.Parameters["@price1"].Value = Convert.ToInt32(textBox1.Text);
                sqlCommand2.Parameters["@price1"].Value = Convert.ToInt32(textBox1.Text);
                sqlCommand3.Parameters["@price1"].Value = Convert.ToInt32(textBox1.Text);
                sqlCommand4.Parameters["@price1"].Value = Convert.ToInt32(textBox1.Text);
                sqlCommand5.Parameters["@price1"].Value = Convert.ToInt32(textBox1.Text);
            }
            if (textBox3.Text == String.Empty)
            {
                sqlCommand1.Parameters["@price2"].Value = 99999;
                sqlCommand3.Parameters["@price2"].Value = 99999;
                sqlCommand4.Parameters["@price2"].Value = 99999;
                sqlCommand5.Parameters["@price2"].Value = 99999;
                sqlCommand2.Parameters["@price2"].Value = 99999;

            }
            else
            {
                sqlCommand1.Parameters["@price2"].Value = Convert.ToInt32(textBox3.Text);
                sqlCommand2.Parameters["@price2"].Value = Convert.ToInt32(textBox3.Text);
                sqlCommand3.Parameters["@price2"].Value = Convert.ToInt32(textBox3.Text);
                sqlCommand4.Parameters["@price2"].Value = Convert.ToInt32(textBox3.Text);
                sqlCommand5.Parameters["@price2"].Value = Convert.ToInt32(textBox3.Text);
            }




            if (textBox4.Text == String.Empty)
            {
                sqlCommand1.Parameters["@page1"].Value = 0;
                sqlCommand2.Parameters["@page1"].Value = 0;
                sqlCommand3.Parameters["@page1"].Value = 0;
                sqlCommand4.Parameters["@page1"].Value = 0;
                sqlCommand5.Parameters["@page1"].Value = 0;
            }
            else
            {
                sqlCommand1.Parameters["@page1"].Value = Convert.ToInt32(textBox4.Text);
                sqlCommand2.Parameters["@page1"].Value = Convert.ToInt32(textBox4.Text);
                sqlCommand3.Parameters["@page1"].Value = Convert.ToInt32(textBox4.Text);
                sqlCommand4.Parameters["@page1"].Value = Convert.ToInt32(textBox4.Text);
                sqlCommand5.Parameters["@page1"].Value = Convert.ToInt32(textBox4.Text);
            }
            if (textBox5.Text == String.Empty)
            {
                sqlCommand1.Parameters["@page2"].Value = 99999;
                sqlCommand2.Parameters["@page2"].Value = 99999;
                sqlCommand3.Parameters["@page2"].Value = 99999;
                sqlCommand4.Parameters["@page2"].Value = 99999;
                sqlCommand5.Parameters["@page2"].Value = 99999;

            }
            else
            {
                sqlCommand1.Parameters["@page2"].Value = Convert.ToInt32(textBox5.Text);
                sqlCommand2.Parameters["@page2"].Value = Convert.ToInt32(textBox5.Text);
                sqlCommand3.Parameters["@page2"].Value = Convert.ToInt32(textBox5.Text);
                sqlCommand4.Parameters["@page2"].Value = Convert.ToInt32(textBox5.Text);
                sqlCommand5.Parameters["@page2"].Value = Convert.ToInt32(textBox5.Text);
            }



            if (ComboBox.Text == String.Empty)
            {
                sqlCommand1.Parameters["@obl"].Value = 'а';
                sqlCommand2.Parameters["@obl"].Value = 'а';
                sqlCommand3.Parameters["@obl"].Value = 'а';
                sqlCommand4.Parameters["@obl"].Value = 'а';
                sqlCommand5.Parameters["@obl"].Value = 'а';

            }
            else
            {
                sqlCommand1.Parameters["@obl"].Value = ComboBox.Text;
                sqlCommand2.Parameters["@obl"].Value = ComboBox.Text;
                sqlCommand3.Parameters["@obl"].Value = ComboBox.Text;
                sqlCommand4.Parameters["@obl"].Value = ComboBox.Text;
                sqlCommand5.Parameters["@obl"].Value = ComboBox.Text;
            }



            if (radioButton1.Checked)
            {

                sqlConnection1.Open();
                sqlCommand2.ExecuteNonQuery();
                var table = new DataTable();
                table.Load(sqlCommand2.ExecuteReader());
                sqlConnection1.Close();
                GridView.DataSource = table;

            }
            if (radioButton2.Checked)
            {

                sqlConnection1.Open();
                sqlCommand3.ExecuteNonQuery();
                var table = new DataTable();
                table.Load(sqlCommand3.ExecuteReader());
                sqlConnection1.Close();
                GridView.DataSource = table;

            }
            if (radioButton3.Checked)
            {

                sqlConnection1.Open();
                sqlCommand4.ExecuteNonQuery();
                var table = new DataTable();
                table.Load(sqlCommand4.ExecuteReader());
                sqlConnection1.Close();
                GridView.DataSource = table;

            }
            if (radioButton4.Checked)
            {

                sqlConnection1.Open();
                sqlCommand5.ExecuteNonQuery();
                var table = new DataTable();
                table.Load(sqlCommand5.ExecuteReader());
                sqlConnection1.Close();
                GridView.DataSource = table;

            }


            if (radioButton1.Checked != true & radioButton2.Checked != true & radioButton3.Checked != true & radioButton4.Checked != true)
            {


                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                var table = new DataTable();
                table.Load(sqlCommand1.ExecuteReader());
                sqlConnection1.Close();
                GridView.DataSource = table;


            }
            if (GridView[0, 0].Value == null)
                textBox6.Text = "Результат не найден";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlCommand6.Parameters["@par"].Value = textBox9.Text;
            sqlConnection1.Open();
            sqlCommand6.ExecuteNonQuery();
            var table = new DataTable();
            table.Load(sqlCommand6.ExecuteReader());
            sqlConnection1.Close();
            GridView.DataSource = table;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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
