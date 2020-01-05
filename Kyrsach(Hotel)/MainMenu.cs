using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsach_Hotel_
{
    public partial class MainMenu : Form
    {
        public MainMenu(bool key)
        {
            InitializeComponent();
            this.key = key;
            if (!key)
            {
                admin.Visible = false;
                users.Visible = false;
            }
            else
            {
                admin.Visible = true;
                users.Visible = true;
            }

        }
        bool key;

        private void заявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Request f2 = new Request();
            f2.Show();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers f3 = new Customers();
            f3.Show();
        }

        private void номераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rooms f4 = new Rooms();
            f4.Show();
        }

        private void оПриложенииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Максимов Вадим Вадимович. Группа 807сб1", "О приложении");
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
        }

        

        private void page_load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Users u = new Users();
            u.Show();
        }
    }
}
