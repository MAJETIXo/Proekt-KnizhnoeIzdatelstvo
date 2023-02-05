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
    public partial class РаботаСДоговорами : Form
    {
        public РаботаСДоговорами()
        {
            InitializeComponent();
            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.CustomFormat = "dd.MM.yyyy";
            TimePicker.MaxDate = DateTime.Now;
            DateTime now = DateTime.Now;
            TimePicker.Value = now;


            TimePicker1.Format = DateTimePickerFormat.Custom;
            TimePicker1.CustomFormat = "dd.MM.yyyy";
            TimePicker1.Value = now;

        }

        private void договорBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.договорBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.издательствоDataSet);

        }

        private void РабСДоговорами_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet2.РабСДоговорами". При необходимости она может быть перемещена или удалена.
            this.рабСДоговорамиTableAdapter.Fill(this.издательствоDataSet2.РабСДоговорами);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательствоDataSet.Договор". При необходимости она может быть перемещена или удалена.
            this.договорTableAdapter.Fill(this.издательствоDataSet.Договор);

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new Издатель();
            frm.Show();
            this.Hide();
        }

        private void договорDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == String.Empty) | (textBox2.Text == String.Empty) | (ComboBox1.Text == String.Empty) | (textBox5.Text == String.Empty))
                textBox7.Text = "введите значения";
            else
            {

                sqlCommand2.Parameters["@num"].Value = Convert.ToInt32(textBox1.Text);
                sqlCommand2.Parameters["@data"].Value = Convert.ToDateTime(TimePicker.Value);
                sqlCommand2.Parameters["@data2"].Value = Convert.ToDateTime(TimePicker1.Value);
                sqlCommand2.Parameters["@fiosotr"].Value = ComboBox1.Text;
                sqlCommand2.Parameters["@nazv"].Value = textBox2.Text;

                if (Convert.ToInt32(textBox5.Text) < 1)
                    textBox7.Text = "некорректное значение оплаты";
                else
                {
                    sqlCommand2.Parameters["@plata"].Value = Convert.ToInt32(textBox5.Text);

                    



                        sqlConnection1.Open();
                        sqlCommand2.ExecuteNonQuery();
                        sqlConnection1.Close();
                        int result = (int)sqlCommand2.Parameters["@x"].Value;

                        if (result == 0)
                            textBox7.Text = "запись добавлена";
                        if (result == 1)
                            textBox7.Text = "не принята в работу";
                        if (result == 2)
                            textBox7.Text = "такой договор уже существует";
                        if (result == 3)
                            textBox7.Text = "такого сотрудника не существует";
                    if (result == 4)
                        textBox7.Text = "неверная дата";

                    sqlConnection1.Open();
                        sqlCommand5.ExecuteNonQuery();
                        var table = new DataTable();
                        table.Load(sqlCommand5.ExecuteReader());
                        sqlConnection1.Close();
                        GridView.DataSource = table;
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlCommand3.Parameters["@par"].Value = textBox6.Text;
            sqlConnection1.Open();
            sqlCommand3.ExecuteNonQuery();
            var table = new DataTable();
            table.Load(sqlCommand3.ExecuteReader());
            sqlConnection1.Close();
            GridView.DataSource = table;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
