namespace Implementation.View
{
    partial class EmployeeEntryForm
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
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.comboBoxDepartments = new System.Windows.Forms.ComboBox();
            this.lblDepartments = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.groupBoxEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.Controls.Add(this.comboBoxDepartments);
            this.groupBoxEmployee.Controls.Add(this.lblDepartments);
            this.groupBoxEmployee.Controls.Add(this.btnAdd);
            this.groupBoxEmployee.Controls.Add(this.textBoxSalary);
            this.groupBoxEmployee.Controls.Add(this.lblSalary);
            this.groupBoxEmployee.Controls.Add(this.textBoxName);
            this.groupBoxEmployee.Controls.Add(this.lblName);
            this.groupBoxEmployee.Controls.Add(this.textBoxId);
            this.groupBoxEmployee.Controls.Add(this.lblId);
            this.groupBoxEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEmployee.Location = new System.Drawing.Point(74, 48);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Size = new System.Drawing.Size(639, 377);
            this.groupBoxEmployee.TabIndex = 0;
            this.groupBoxEmployee.TabStop = false;
            this.groupBoxEmployee.Text = "ENTER EMPLOYEE DETAILS: ";
            // 
            // comboBoxDepartments
            // 
            this.comboBoxDepartments.FormattingEnabled = true;
            this.comboBoxDepartments.Location = new System.Drawing.Point(323, 197);
            this.comboBoxDepartments.Name = "comboBoxDepartments";
            this.comboBoxDepartments.Size = new System.Drawing.Size(250, 28);
            this.comboBoxDepartments.TabIndex = 8;
            // 
            // lblDepartments
            // 
            this.lblDepartments.AutoSize = true;
            this.lblDepartments.Location = new System.Drawing.Point(60, 197);
            this.lblDepartments.Name = "lblDepartments";
            this.lblDepartments.Size = new System.Drawing.Size(204, 20);
            this.lblDepartments.TabIndex = 7;
            this.lblDepartments.Text = "SELECT DEPARTMENT: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(221, 274);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(191, 40);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "ADD RECORD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(323, 139);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(250, 26);
            this.textBoxSalary.TabIndex = 5;
            this.textBoxSalary.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(56, 139);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(79, 20);
            this.lblSalary.TabIndex = 4;
            this.lblSalary.Text = "SALARY:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(323, 88);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(250, 26);
            this.textBoxName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(56, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "NAME: ";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(323, 37);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(250, 26);
            this.textBoxId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(56, 37);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(36, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID: ";
            // 
            // EmployeeEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxEmployee);
            this.Name = "EmployeeEntryForm";
            this.Text = "EmployeeEntryForm";
            this.Load += new System.EventHandler(this.EmployeeEntryForm_Load);
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEmployee;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.ComboBox comboBoxDepartments;
    }
}