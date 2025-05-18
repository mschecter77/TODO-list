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
            this.dataGridView2.RowEnter += new DataGridViewCellEventHandler(this.dataGridView2_RowEnter);
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
                dataGridView2.DataSource = ds.Tables[0];
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

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;      // ignore header
            PopulateUpdateFields(e.RowIndex);
        }
        public void PopulateUpdateFields(int rowIndex)
        {
            var row = this.dataGridView2.Rows[rowIndex];
            string id = row.Cells["TaskID"].Value?.ToString();
            int taskId = Convert.ToInt32(id);
            txtbxTNameUpdate.Text = row.Cells["TaskName"].Value?.ToString();
            txtbxTaskDescrUpdate.Text = row.Cells["TaskDescr"].Value?.ToString();
            dateTimeUpdate.Value = Convert.ToDateTime(row.Cells["TaskDueDate"].Value);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null) return;

            var row = dataGridView2.CurrentRow;
            int id = Convert.ToInt32(row.Cells["TaskID"].Value);

            DB db = new DB();
            db.dbupdateTask(
                id,
                txtbxTNameUpdate.Text,
                txtbxTaskDescrUpdate.Text,
                dateTimeUpdate.Value
            );

            fillGrid();
            popListBox();
            MessageBox.Show("Task updated.");
        }
    }
    }


