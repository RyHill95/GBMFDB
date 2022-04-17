namespace GBMFDB
{
    partial class Menu
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnTools = new System.Windows.Forms.Button();
            this.btnDepot = new System.Windows.Forms.Button();
            this.btnSkills = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenu.Location = new System.Drawing.Point(56, 27);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(158, 65);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu";
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Black;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(12, 116);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(252, 31);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Employees";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnTools
            // 
            this.btnTools.BackColor = System.Drawing.Color.Black;
            this.btnTools.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTools.ForeColor = System.Drawing.Color.White;
            this.btnTools.Location = new System.Drawing.Point(12, 186);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(252, 31);
            this.btnTools.TabIndex = 1;
            this.btnTools.Text = "Tools";
            this.btnTools.UseVisualStyleBackColor = false;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnDepot
            // 
            this.btnDepot.BackColor = System.Drawing.Color.Black;
            this.btnDepot.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDepot.ForeColor = System.Drawing.Color.White;
            this.btnDepot.Location = new System.Drawing.Point(12, 329);
            this.btnDepot.Name = "btnDepot";
            this.btnDepot.Size = new System.Drawing.Size(252, 31);
            this.btnDepot.TabIndex = 1;
            this.btnDepot.Text = "Equipment Depot";
            this.btnDepot.UseVisualStyleBackColor = false;
            this.btnDepot.Click += new System.EventHandler(this.btnDepot_Click);
            // 
            // btnSkills
            // 
            this.btnSkills.BackColor = System.Drawing.Color.Black;
            this.btnSkills.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSkills.ForeColor = System.Drawing.Color.White;
            this.btnSkills.Location = new System.Drawing.Point(12, 256);
            this.btnSkills.Name = "btnSkills";
            this.btnSkills.Size = new System.Drawing.Size(252, 31);
            this.btnSkills.TabIndex = 1;
            this.btnSkills.Text = "Skill Adjustments";
            this.btnSkills.UseVisualStyleBackColor = false;
            this.btnSkills.Click += new System.EventHandler(this.btnSkills_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 438);
            this.Controls.Add(this.btnSkills);
            this.Controls.Add(this.btnDepot);
            this.Controls.Add(this.btnTools);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.lblMenu);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMenu;
        private Button btnEmployee;
        private Button btnTools;
        private Button btnDepot;
        private Button btnSkills;
    }
}