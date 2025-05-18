namespace todolist
{
    partial class Tabs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage4 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage1 = new TabPage();
            btnSubmit = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtBxTDescription = new TextBox();
            txtBxTName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            button1 = new Button();
            label4 = new Label();
            comBoxTaskName = new ComboBox();
            tabPage3 = new TabPage();
            dateTimeUpdate = new DateTimePicker();
            txtbxTaskDescrUpdate = new TextBox();
            txtbxTNameUpdate = new TextBox();
            btnUpdate = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dataGridView2 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 446);
            tabControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(792, 413);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "View Tasks";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(790, 417);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnSubmit);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(txtBxTDescription);
            tabPage1.Controls.Add(txtBxTName);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 413);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Task";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(275, 320);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(271, 255);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // txtBxTDescription
            // 
            txtBxTDescription.Location = new Point(278, 162);
            txtBxTDescription.Name = "txtBxTDescription";
            txtBxTDescription.Size = new Size(125, 27);
            txtBxTDescription.TabIndex = 11;
            // 
            // txtBxTName
            // 
            txtBxTName.Location = new Point(276, 94);
            txtBxTName.Name = "txtBxTName";
            txtBxTName.Size = new Size(125, 27);
            txtBxTName.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 219);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 9;
            label3.Text = "Due Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 136);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 8;
            label2.Text = "Task Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(271, 64);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 7;
            label1.Text = "Task Name";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(comBoxTaskName);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 413);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Delete Task";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(98, 131);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 30);
            label4.Name = "label4";
            label4.Size = new Size(159, 20);
            label4.TabIndex = 1;
            label4.Text = "Pick task to be deleted";
            // 
            // comBoxTaskName
            // 
            comBoxTaskName.AllowDrop = true;
            comBoxTaskName.FormattingEnabled = true;
            comBoxTaskName.Location = new Point(98, 65);
            comBoxTaskName.Name = "comBoxTaskName";
            comBoxTaskName.Size = new Size(151, 28);
            comBoxTaskName.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dateTimeUpdate);
            tabPage3.Controls.Add(txtbxTaskDescrUpdate);
            tabPage3.Controls.Add(txtbxTNameUpdate);
            tabPage3.Controls.Add(btnUpdate);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 413);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Update Task";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateTimeUpdate
            // 
            dateTimeUpdate.Location = new Point(527, 268);
            dateTimeUpdate.Name = "dateTimeUpdate";
            dateTimeUpdate.Size = new Size(259, 27);
            dateTimeUpdate.TabIndex = 7;
            // 
            // txtbxTaskDescrUpdate
            // 
            txtbxTaskDescrUpdate.Location = new Point(176, 268);
            txtbxTaskDescrUpdate.Name = "txtbxTaskDescrUpdate";
            txtbxTaskDescrUpdate.Size = new Size(300, 27);
            txtbxTaskDescrUpdate.TabIndex = 6;
            // 
            // txtbxTNameUpdate
            // 
            txtbxTNameUpdate.Location = new Point(23, 268);
            txtbxTNameUpdate.Name = "txtbxTNameUpdate";
            txtbxTNameUpdate.Size = new Size(129, 27);
            txtbxTNameUpdate.TabIndex = 5;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(673, 349);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 34);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(545, 232);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 3;
            label7.Text = "Due Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(176, 232);
            label6.Name = "label6";
            label6.Size = new Size(116, 20);
            label6.TabIndex = 2;
            label6.Text = "Task Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 232);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 1;
            label5.Text = "Task Name";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(21, 31);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(765, 188);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_RowEnter;
            // 
            // Tabs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Tabs";
            Text = "Form2";
            tabControl1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnSubmit;
        private DateTimePicker dateTimePicker1;
        private TextBox txtBxTDescription;
        private TextBox txtBxTName;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label4;
        private ComboBox comBoxTaskName;
        private DataGridView dataGridView2;
        private TextBox txtbxTaskDescrUpdate;
        private TextBox txtbxTNameUpdate;
        private Button btnUpdate;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimeUpdate;
    }
}