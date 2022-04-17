namespace GBMFDB
{
    partial class Skills
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
            this.boxEmployee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxSkill = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radbtnActive = new System.Windows.Forms.RadioButton();
            this.radbtnTerm = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee:";
            // 
            // boxEmployee
            // 
            this.boxEmployee.FormattingEnabled = true;
            this.boxEmployee.Items.AddRange(new object[] {
            "John Smith",
            "Harry Jones",
            "William Davis",
            "James Anderson",
            "Gina Rogers",
            "Jack Daniels",
            "Mary Hendricks",
            "Melinda Peters",
            "Oscar Hernandez"});
            this.boxEmployee.Location = new System.Drawing.Point(192, 37);
            this.boxEmployee.Name = "boxEmployee";
            this.boxEmployee.Size = new System.Drawing.Size(121, 23);
            this.boxEmployee.TabIndex = 1;
            this.boxEmployee.SelectedIndexChanged += new System.EventHandler(this.boxEmployee_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Change Skill";
            // 
            // boxSkill
            // 
            this.boxSkill.FormattingEnabled = true;
            this.boxSkill.Items.AddRange(new object[] {
            "Apprentice",
            "Forklift Certified",
            "Master",
            "User",
            "Admin"});
            this.boxSkill.Location = new System.Drawing.Point(192, 144);
            this.boxSkill.Name = "boxSkill";
            this.boxSkill.Size = new System.Drawing.Size(121, 23);
            this.boxSkill.TabIndex = 3;
            this.boxSkill.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employment Status";
            // 
            // radbtnActive
            // 
            this.radbtnActive.AutoSize = true;
            this.radbtnActive.Checked = true;
            this.radbtnActive.Location = new System.Drawing.Point(192, 245);
            this.radbtnActive.Name = "radbtnActive";
            this.radbtnActive.Size = new System.Drawing.Size(58, 19);
            this.radbtnActive.TabIndex = 5;
            this.radbtnActive.TabStop = true;
            this.radbtnActive.Text = "Active";
            this.radbtnActive.UseVisualStyleBackColor = true;
            this.radbtnActive.CheckedChanged += new System.EventHandler(this.radbtnActive_CheckedChanged);
            // 
            // radbtnTerm
            // 
            this.radbtnTerm.AutoSize = true;
            this.radbtnTerm.Location = new System.Drawing.Point(192, 270);
            this.radbtnTerm.Name = "radbtnTerm";
            this.radbtnTerm.Size = new System.Drawing.Size(84, 19);
            this.radbtnTerm.TabIndex = 6;
            this.radbtnTerm.Text = "Terminated";
            this.radbtnTerm.UseVisualStyleBackColor = true;
            this.radbtnTerm.CheckedChanged += new System.EventHandler(this.radbtnTerm_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(268, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(448, 362);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Exit";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Skills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radbtnTerm);
            this.Controls.Add(this.radbtnActive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxSkill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxEmployee);
            this.Controls.Add(this.label1);
            this.Name = "Skills";
            this.Text = "Skills";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox boxEmployee;
        private Label label2;
        private ComboBox boxSkill;
        private Label label3;
        private RadioButton radbtnActive;
        private RadioButton radbtnTerm;
        private Button btnSave;
        private Button btnReturn;
    }
}