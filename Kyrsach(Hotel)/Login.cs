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
    public partial class Login : Form
    {

        const string connectionString = @"Data Source=TERMSERV\SQLEXPRESS;Initial Catalog = MAX13; Integrated Security = True";
        public Login()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //users
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                //string sql2 = "Select *from Администрация where Логин='" + textBox1.Text + "'and Пароль='" + textBox2.Text + "';";
                string sql = "Select *from Пользователи where Логин='" + textBox1.Text + "'and Пароль='" + textBox2.Text + "';";
                try
                {
                    //MessageBox.Show("Неверный логин или пароль!");
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        //содание обекта DataAdapter
                        SqlCommand comm = new SqlCommand(sql, connection);
                        comm.ExecuteNonQuery();

                        SqlDataReader reader = comm.ExecuteReader();

                        if (reader.HasRows) //если есть данные
                        {
                            this.Hide();
                            MainMenu m = new MainMenu(false);
                            m.ShowDialog();
                            Dispose();
                            this.Close();
                        }
                        else
                        {   
                            //admin
                            if(textBox1.Text != "" && textBox2.Text != "")
                            {
                                string sql2 = "Select *from Администрация where Логин='" + textBox1.Text + "'and Пароль='" + textBox2.Text + "';";
                                //string sql = "Select *from Пользователи where Логин='" + textBox1.Text + "'and Пароль='" + textBox2.Text + "';";
                                try
                                {
                                    //MessageBox.Show("Неверный логин или пароль!");
                                    using (SqlConnection connection2 = new SqlConnection(connectionString))
                                    {
                                        connection2.Open();

                                        //содание обекта DataAdapter
                                        SqlCommand comm2 = new SqlCommand(sql2, connection2);
                                        comm2.ExecuteNonQuery();

                                        SqlDataReader reader2 = comm2.ExecuteReader();

                                        if (reader2.HasRows) //если есть данные
                                        {
                                            this.Hide();
                                            MainMenu m2 = new MainMenu(true);
                                            m2.ShowDialog();
                                            Dispose();
                                            this.Close();

                                            Login l = new Login();
                                            l.Close();
                                        }
                                        else
                                        {

                                            MessageBox.Show("Неверный логин или пароль!");
                                        }
                                    }
                                }
                                catch (Exception i)
                                {
                                    MessageBox.Show("Something is very bad!\n" + i.Message);
                                    //Console.WriteLine("Dude this is Error! :)");
                                }
                            }
                        }
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show("Something is very bad!\n" + a.Message);
                    //Console.WriteLine("Dude this is Error! :)");
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
