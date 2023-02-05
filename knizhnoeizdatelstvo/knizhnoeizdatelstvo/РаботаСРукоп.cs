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
    public partial class РаботаСРукоп : Form
    {
        public РаботаСРукоп()
        {
            InitializeComponent();
        }

        private void рукописьBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.рукописьBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.издательствоDataSet);

        }

        private void РабСРукоп_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet2.РабсРукоп". При необходимости она может быть перемещена или удалена.
            this.рабсРукопTableAdapter.Fill(this.издательствоDataSet2.РабсРукоп);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet.Рукопись". При необходимости она может быть перемещена или удалена.
            this.рукописьTableAdapter.Fill(this.издательствоDataSet.Рукопись);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void статусLabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new Издатель();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == String.Empty) | (textBox2.Text == String.Empty) | (textBox3.Text == String.Empty) | (ComboBox1.Text == String.Empty) | (ComboBox2.Text == String.Empty))
                textBox5.Text = "введите значения";
            else
            {
                sqlCommand2.Parameters["@nazv"].Value = textBox1.Text;
                sqlCommand2.Parameters["@idavt"].Value = textBox2.Text;
                sqlCommand2.Parameters["@v"].Value = textBox3.Text;
                sqlCommand2.Parameters["@zhanr"].Value = ComboBox1.Text;
                sqlCommand2.Parameters["@status"].Value = ComboBox2.Text;
                sqlConnection1.Open();
                sqlCommand2.ExecuteNonQuery();
                sqlConnection1.Close();
                int result = (int)sqlCommand2.Parameters["@x"].Value;

                if (result == 0)
                    textBox5.Text = "запись добавлена";
                if (result == 1)
                    textBox5.Text = "нет такого автора";

                sqlConnection1.Open();
                sqlCommand5.ExecuteNonQuery();
                var table = new DataTable();
                table.Load(sqlCommand5.ExecuteReader());
                sqlConnection1.Close();
                GridView.DataSource = table;
            }
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (textBox4.Text == String.Empty)
        //        textBox5.Text = "введите ID";
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
        //                textBox5.Text = "рукопись удалена";
        //            if (result == 1)
        //                textBox5.Text = "несуществующий ID";
        //        }
        //        catch
        //        {
        //            textBox5.Text = "рукопись не может быть удалёна";
        //            sqlConnection1.Close();
        //        }
        //        sqlConnection1.Open();
        //        sqlCommand1.ExecuteNonQuery();
        //        var table = new DataTable();
        //        table.Load(sqlCommand1.ExecuteReader());
        //        sqlConnection1.Close();
        //        GridView.DataSource = table;
        //    }
        //}

        private void button4_Click(object sender, EventArgs e)
        {

            sqlCommand4.Parameters["@par"].Value = textBox6.Text;
            sqlConnection1.Open();
            sqlCommand4.ExecuteNonQuery();
            var table = new DataTable();
            table.Load(sqlCommand4.ExecuteReader());
            sqlConnection1.Close();
            GridView.DataSource = table;
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }
    }
}
