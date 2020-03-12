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
    public partial class OperationMenuForm : Form
    {
        public OperationMenuForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayForm(new DepartmentEntryForm());
            
            //departmentEntry.MdiParent = this;
            //modeless dialog box
            //departmentEntry.Show();

            //modal dialog box
            //departmentEntry.ShowDialog();
        }


        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //EmployeeEntryForm employeeEntryForm = new EmployeeEntryForm();
            //DisplayForm(employeeEntryForm);
            DisplayForm(new EmployeeEntryForm());
        }

        private void viewDepartmentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayForm(new DepartmentDetailsForm());
        }

        private void viewEmployeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            DisplayForm(new EmployeeDetailsForm());
        }
        private void DisplayForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }
    }
}
