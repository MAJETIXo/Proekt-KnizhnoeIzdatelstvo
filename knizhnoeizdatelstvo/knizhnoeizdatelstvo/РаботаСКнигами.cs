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
    public partial class РаботаСКнигами : Form
    {
        public РаботаСКнигами()
        {
            InitializeComponent();
            sqlConnection1.Open();
            sqlCommand1.ExecuteNonQuery();
            var table = new DataTable();
            table.Load(sqlCommand1.ExecuteReader());
            sqlConnection1.Close();
            GridView.DataSource = table;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void button2_Click(object sender, EventArgs e)
        //{

        //    if (textBox1.Text == String.Empty)
        //        textBox3.Text = "введите ID";
        //    else
        //    {
        //        try
        //        {
        //            sqlCommand3.Parameters["@ID"].Value = Convert.ToInt32(textBox1.Text); sqlConnection1.Open();
        //            sqlCommand3.ExecuteNonQuery();
        //            sqlConnection1.Close();
        //            int result = (int)sqlCommand3.Parameters["@x"].Value;

        //            if (result == 0)
        //            {
                       
        //                sqlConnection1.Open();
        //                sqlCommand1.ExecuteNonQuery();
        //                var table = new DataTable();
        //                table.Load(sqlCommand1.ExecuteReader());
        //                sqlConnection1.Close();
        //                GridView.DataSource = table;
        //                textBox3.Text = "запись удалена";
        //            }
        //            if (result == 1)
        //                textBox3.Text = "несуществующий ID";
                   
        //        }
        //        catch
        //        {
        //            textBox3.Text = "книга не может быть удалена";
        //            sqlConnection1.Close();
        //        }
        //    }
        //}

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void книгаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.книгаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.издательствоDataSet);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((textBox2.Text == String.Empty) | (textBox4.Text == String.Empty) | (textBox5.Text == String.Empty) | (textBox6.Text == String.Empty))
                textBox3.Text = "введите обязательные значения";
            else
            {
                sqlCommand2.Parameters["@nazv"].Value = textBox2.Text;
                sqlCommand2.Parameters["@nomer"].Value = Convert.ToInt32(textBox6.Text);
                sqlCommand2.Parameters["@stoim"].Value = Convert.ToInt32(textBox4.Text);
                sqlCommand2.Parameters["@str"].Value = Convert.ToInt32(textBox5.Text);
                sqlCommand2.Parameters["@perep"].Value = ComboBox.Text;
                sqlCommand2.Parameters["@obl"].Value = СomboBox1.Text;
                sqlConnection1.Open();
                sqlCommand2.ExecuteNonQuery();
                sqlConnection1.Close();
                int result = (int)sqlCommand2.Parameters["@x"].Value;

                if (result == 0)
                {
                    textBox3.Text = "запись добавлена";
                    sqlConnection1.Open();
                    sqlCommand1.ExecuteNonQuery();
                    var table = new DataTable();
                    table.Load(sqlCommand1.ExecuteReader());
                    sqlConnection1.Close();
                    GridView.DataSource = table;
                }
                if (result == 3)
                    textBox3.Text = "непринятая рукопись";
                if (result == 4)
                    textBox3.Text = "несуществующее id рукописи";
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new Менеджер();
            frm.Show();
            this.Hide();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            { e.Handled = true; }
        }
    }
    
}
