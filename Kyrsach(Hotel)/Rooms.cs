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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void номерBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.номерBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mAX13DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mAX13DataSet.Номер". При необходимости она может быть перемещена или удалена.
            this.номерTableAdapter.Fill(this.mAX13DataSet.Номер);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            idTextBox.Text = null;
            этажTextBox.Text = null;
            стаутсComboBox.Text = null;
            комнатаTextBox.Text = null;
            состояниеCheckBox.Checked = false; // галка)))
        }

        private void состояниеCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
