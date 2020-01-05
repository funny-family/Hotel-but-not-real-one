using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kyrsach_Hotel_
{
    public partial class Request : Form
    {
        const string connectionString = @"Data Source=TERMSERV\SQLEXPRESS;Initial Catalog = MAX13; Integrated Security = True";
        public Request()
        {
            InitializeComponent();
        }

        private void заявкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заявкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mAX13DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mAX13DataSet.Заявка". При необходимости она может быть перемещена или удалена.
            this.заявкаTableAdapter.Fill(this.mAX13DataSet.Заявка);

        }

        private void заявкаDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text == null && стоимостьTextBox.Text == null && id_КомтаныTextBox == null)
            {
                MessageBox.Show("Что-то не заполнеино!");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                    try
                    {
                        {
                            connection.Open();
                            //string sql = @"INSERT INTO Клиент (ФИО, телефон) values('" + id_заявкиTextBox + "', '" + фИОTextBox + "', '" + фИОTextBox + "телефонTextBox);";
                            //SqlCommand comm = new SqlCommand(sql, connection);
                            //comm.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {

                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //очистить

            idTextBox.Text = null;
            датаDateTimePicker.Text = null;
            стоимостьTextBox.Text = null;
            id_КомтаныTextBox.Text = null;
        }
    }
}
