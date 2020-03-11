using Implementation.DAL;
using Implementation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Implementation.View
{
    public partial class DepartmentEntryForm : Form
    {
        public DepartmentEntryForm()
        {
            InitializeComponent();
        }

        private void DepartmentEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            //var--> keyword
            //result-->implicitly typed local variable (c# 3.0 -2007)
            var result = MessageBox.Show("Really like to close?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void groupBoxDepartment_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);
            string name = textBoxName.Text;
            //object initializer (C# 3.0 -2007)
            Department department = new Department
            {
                DepartmentId = id,
                DepartmentName = name
            };
            DepartmentDataAccessObject departmentDao
                = new DepartmentDataAccessObject();
            bool status = departmentDao.Add(department);
            if (status)
                MessageBox.Show("department record added");
            else
                MessageBox.Show("department record not added");

            Reset();
        }
        private void Reset()
        {
            //textBoxId.Text = "";
            //textBoxName.Text = "";
            var controls = this.Controls;
            foreach (Control item in controls)
            {
                if (item is GroupBox)
                {
                    GroupBox gb = item as GroupBox;
                    foreach (Control c in gb.Controls)
                    {
                        if (c is TextBox)
                        {
                            TextBox tx = c as TextBox;
                            tx.Text = "";
                        }
                    }
                }
            }
        }
    }
}
