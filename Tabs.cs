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
            fillGrid();
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.DBaddtask(txtBxTName.Text, txtBxTDescription.Text, dateTimePicker1.Value);
            fillGrid();
            MessageBox.Show("Task submitted.");
            
        }
        public void fillGrid()
        {
            DB db = new DB();
            DataSet ds = db.fillGrid();
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
