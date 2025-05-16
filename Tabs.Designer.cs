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
            tabPage1 = new TabPage();
            btnSubmit = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtBxTDescription = new TextBox();
            txtBxTName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 446);
            tabControl1.TabIndex = 0;
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
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 413);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Delete Task";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 413);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Update Task";
            tabPage3.UseVisualStyleBackColor = true;
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
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
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
    }
}