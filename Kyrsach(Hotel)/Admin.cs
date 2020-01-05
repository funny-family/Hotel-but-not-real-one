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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void администрацияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.администрацияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mAX13DataSet1);

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mAX13DataSet1.Администрация". При необходимости она может быть перемещена или удалена.
            this.администрацияTableAdapter.Fill(this.mAX13DataSet1.Администрация);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            логинTextBox.Text = null;
            парольTextBox.Text = null;
        }
    }
}
