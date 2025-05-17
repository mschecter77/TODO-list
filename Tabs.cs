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
            popListBox();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.DBaddtask(txtBxTName.Text, txtBxTDescription.Text, dateTimePicker1.Value);
            fillGrid();
            popListBox();
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
        private void popListBox()
        {
            comBoxTaskName.Items.Clear();
            DB db = new DB();
            string[] names = db.getTaskName();
            foreach (string name in names)
            {
                comBoxTaskName.Items.Add(name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.DBdeletetask(comBoxTaskName.SelectedItem.ToString());
            
            fillGrid();
            popListBox();
        }
    }

}
