using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todolist
{
    public partial class Tabs : Form
    {
        public Tabs()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.DBaddtask(txtBxTName.Text, txtBxTDescription.Text, dateTimePicker1.Value);
            MessageBox.Show("Task submitted.");
        }
    }
}
