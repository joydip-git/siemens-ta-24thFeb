namespace Implementation.View
{
    partial class DepartmentDetailsForm
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
            this.lblDepartments = new System.Windows.Forms.Label();
            this.comboBoxDepartments = new System.Windows.Forms.ComboBox();
            this.dataGridEmployees = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coulmnSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioId = new System.Windows.Forms.RadioButton();
            this.radioName = new System.Windows.Forms.RadioButton();
            this.radioSalary = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepartments
            // 
            this.lblDepartments.AutoSize = true;
            this.lblDepartments.Location = new System.Drawing.Point(90, 51);
            this.lblDepartments.Name = "lblDepartments";
            this.lblDepartments.Size = new System.Drawing.Size(177, 17);
            this.lblDepartments.TabIndex = 0;
            this.lblDepartments.Text = "SELECT A DEPARTMENT:";
            // 
            // comboBoxDepartments
            // 
            this.comboBoxDepartments.FormattingEnabled = true;
            this.comboBoxDepartments.Location = new System.Drawing.Point(348, 42);
            this.comboBoxDepartments.Name = "comboBoxDepartments";
            this.comboBoxDepartments.Size = new System.Drawing.Size(239, 24);
            this.comboBoxDepartments.TabIndex = 1;
            this.comboBoxDepartments.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartments_SelectedIndexChanged);
            // 
            // dataGridEmployees
            // 
            this.dataGridEmployees.AllowUserToAddRows = false;
            this.dataGridEmployees.AllowUserToDeleteRows = false;
            this.dataGridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnName,
            this.coulmnSalary});
            this.dataGridEmployees.Location = new System.Drawing.Point(138, 124);
            this.dataGridEmployees.Name = "dataGridEmployees";
            this.dataGridEmployees.ReadOnly = true;
            this.dataGridEmployees.RowHeadersWidth = 51;
            this.dataGridEmployees.RowTemplate.Height = 24;
            this.dataGridEmployees.Size = new System.Drawing.Size(520, 265);
            this.dataGridEmployees.TabIndex = 2;
            this.dataGridEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmployees_CellContentClick);
            // 
            // columnId
            // 
            this.columnId.DataPropertyName = "EmployeeId";
            this.columnId.HeaderText = "ID";
            this.columnId.MinimumWidth = 6;
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            this.columnId.Width = 125;
            // 
            // columnName
            // 
            this.columnName.DataPropertyName = "EmployeeName";
            this.columnName.HeaderText = "NAME";
            this.columnName.MinimumWidth = 6;
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            this.columnName.Width = 125;
            // 
            // coulmnSalary
            // 
            this.coulmnSalary.DataPropertyName = "Salary";
            this.coulmnSalary.HeaderText = "SALARY";
            this.coulmnSalary.MinimumWidth = 6;
            this.coulmnSalary.Name = "coulmnSalary";
            this.coulmnSalary.ReadOnly = true;
            this.coulmnSalary.Width = 125;
            // 
            // radioId
            // 
            this.radioId.AutoSize = true;
            this.radioId.Location = new System.Drawing.Point(146, 86);
            this.radioId.Name = "radioId";
            this.radioId.Size = new System.Drawing.Size(94, 21);
            this.radioId.TabIndex = 3;
            this.radioId.TabStop = true;
            this.radioId.Text = "Sort By Id:";
            this.radioId.UseVisualStyleBackColor = true;
            this.radioId.CheckedChanged += new System.EventHandler(this.radioId_CheckedChanged);
            // 
            // radioName
            // 
            this.radioName.AutoSize = true;
            this.radioName.Location = new System.Drawing.Point(348, 86);
            this.radioName.Name = "radioName";
            this.radioName.Size = new System.Drawing.Size(120, 21);
            this.radioName.TabIndex = 4;
            this.radioName.TabStop = true;
            this.radioName.Text = "Sort By Name:";
            this.radioName.UseVisualStyleBackColor = true;
            this.radioName.CheckedChanged += new System.EventHandler(this.radioName_CheckedChanged);
            // 
            // radioSalary
            // 
            this.radioSalary.AutoSize = true;
            this.radioSalary.Location = new System.Drawing.Point(535, 86);
            this.radioSalary.Name = "radioSalary";
            this.radioSalary.Size = new System.Drawing.Size(123, 21);
            this.radioSalary.TabIndex = 5;
            this.radioSalary.TabStop = true;
            this.radioSalary.Text = "Sort By Salary:";
            this.radioSalary.UseVisualStyleBackColor = true;
            this.radioSalary.CheckedChanged += new System.EventHandler(this.radioSalary_CheckedChanged);
            // 
            // DepartmentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.radioSalary);
            this.Controls.Add(this.radioName);
            this.Controls.Add(this.radioId);
            this.Controls.Add(this.dataGridEmployees);
            this.Controls.Add(this.comboBoxDepartments);
            this.Controls.Add(this.lblDepartments);
            this.Name = "DepartmentDetailsForm";
            this.Text = "DepartmentDetailsForm";
            this.Load += new System.EventHandler(this.DepartmentDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.ComboBox comboBoxDepartments;
        private System.Windows.Forms.DataGridView dataGridEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn coulmnSalary;
        private System.Windows.Forms.RadioButton radioId;
        private System.Windows.Forms.RadioButton radioName;
        private System.Windows.Forms.RadioButton radioSalary;
    }
}