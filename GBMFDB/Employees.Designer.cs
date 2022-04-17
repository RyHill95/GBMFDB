namespace GBMFDB
{
    partial class Employees
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnEmployeeExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "John Smith\tID: 1\t",
            "Harry Jones\tID: 2",
            "William Davis\tID: 3",
            "James Anderson\tID: 4",
            "Gina Rogers\tID: 5",
            "Jack Daniels\tID: 6",
            "Mary Hendricks\tID: 7",
            "Melinda Peters\tID: 8",
            "Oscar Hernandez\tID: 9"});
            this.comboBox1.Location = new System.Drawing.Point(121, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(121, 83);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(244, 23);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "Add New Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(121, 112);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(244, 23);
            this.btnEditEmployee.TabIndex = 3;
            this.btnEditEmployee.Text = "Edit Employee";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeExit
            // 
            this.btnEmployeeExit.Location = new System.Drawing.Point(121, 141);
            this.btnEmployeeExit.Name = "btnEmployeeExit";
            this.btnEmployeeExit.Size = new System.Drawing.Size(244, 23);
            this.btnEmployeeExit.TabIndex = 4;
            this.btnEmployeeExit.Text = "Exit";
            this.btnEmployeeExit.UseVisualStyleBackColor = true;
            this.btnEmployeeExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 190);
            this.Controls.Add(this.btnEmployeeExit);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Employees";
            this.Text = "Employees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button btnAddEmployee;
        private Button btnEditEmployee;
        private Button btnEmployeeExit;
    }
}