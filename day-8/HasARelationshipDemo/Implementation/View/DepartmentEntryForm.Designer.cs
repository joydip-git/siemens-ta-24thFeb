namespace Implementation.View
{
    partial class DepartmentEntryForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxDepartment = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBoxDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(334, 397);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 47);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBoxDepartment
            // 
            this.groupBoxDepartment.Controls.Add(this.btnAdd);
            this.groupBoxDepartment.Controls.Add(this.textBoxName);
            this.groupBoxDepartment.Controls.Add(this.lblName);
            this.groupBoxDepartment.Controls.Add(this.textBoxId);
            this.groupBoxDepartment.Controls.Add(this.lblId);
            this.groupBoxDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDepartment.Location = new System.Drawing.Point(136, 41);
            this.groupBoxDepartment.Name = "groupBoxDepartment";
            this.groupBoxDepartment.Size = new System.Drawing.Size(511, 285);
            this.groupBoxDepartment.TabIndex = 1;
            this.groupBoxDepartment.TabStop = false;
            this.groupBoxDepartment.Text = "ENTER DEPARTMENT DETAILS: ";
            this.groupBoxDepartment.Enter += new System.EventHandler(this.groupBoxDepartment_Enter);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(40, 47);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID: ";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(179, 47);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(187, 26);
            this.textBoxId.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(179, 122);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(187, 26);
            this.textBoxName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(40, 122);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "NAME: ";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(188, 203);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(178, 44);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD RECORD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DepartmentEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 470);
            this.Controls.Add(this.groupBoxDepartment);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepartmentEntryForm";
            this.Text = "DepartmentEntryForm";
            this.Load += new System.EventHandler(this.DepartmentEntryForm_Load);
            this.groupBoxDepartment.ResumeLayout(false);
            this.groupBoxDepartment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBoxDepartment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label lblId;
    }
}