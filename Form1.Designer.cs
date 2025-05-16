namespace todolist
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBxTName = new TextBox();
            txtBxTDescription = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 44);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Task Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 116);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Task Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 199);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Due Date";
            // 
            // txtBxTName
            // 
            txtBxTName.Location = new Point(31, 74);
            txtBxTName.Name = "txtBxTName";
            txtBxTName.Size = new Size(125, 27);
            txtBxTName.TabIndex = 3;
            // 
            // txtBxTDescription
            // 
            txtBxTDescription.Location = new Point(33, 142);
            txtBxTDescription.Name = "txtBxTDescription";
            txtBxTDescription.Size = new Size(125, 27);
            txtBxTDescription.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(26, 235);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(30, 300);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtBxTDescription);
            Controls.Add(txtBxTName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ToDo List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBxTName;
        private TextBox txtBxTDescription;
        private DateTimePicker dateTimePicker1;
        private Button btnSubmit;
    }
}
