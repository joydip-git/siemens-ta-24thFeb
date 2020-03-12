using Implementation.DAL;
using Implementation.IOC;
using Implementation.Models;
using Implementation.BL;

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
    public partial class DepartmentDetailsForm : Form
    {
        public DepartmentDetailsForm()
        {
            InitializeComponent();
        }

        private void DepartmentDetailsForm_Load(object sender, EventArgs e)
        {
            DataAccessObjectProvider provider
                = new DataAccessObjectProvider();
            //provider.Create();
            DepartmentDataAccessObject departmentDao
                = new DepartmentDataAccessObject();
            var departments = departmentDao.GetAll();

            comboBoxDepartments.DataSource = departments.ToList<Department>();
            comboBoxDepartments.DisplayMember = "DepartmentName";
        }

        private void comboBoxDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDepartment = comboBoxDepartments.SelectedItem as Department;

            if (selectedDepartment != null)
            {
                EmployeeDataAccessObject employeeDao = new EmployeeDataAccessObject();
                var list = employeeDao.GetById(selectedDepartment.DepartmentId);

                if (list != null && list.Count > 0)
                {
                    dataGridEmployees.AutoGenerateColumns = false;
                    dataGridEmployees.DataSource = list;
                }
            }
        }

        private void dataGridEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioId_CheckedChanged(object sender, EventArgs e)
        {
            if (radioId.Checked)
            {
                GetSortedRecords(EmployeeSortChoice.SortById);
            }
        }

        private void radioName_CheckedChanged(object sender, EventArgs e)
        {
            if (radioName.Checked)
                GetSortedRecords(EmployeeSortChoice.SortByName);
        }
        private void radioSalary_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSalary.Checked)
                GetSortedRecords(EmployeeSortChoice.SortBySalary);
        }
        private void GetSortedRecords(EmployeeSortChoice choice)
        {
            EmployeeBusinessComponent empBo = new EmployeeBusinessComponent();
            var collection = dataGridEmployees.DataSource as List<Employee>;

            var sortedCollection = empBo.SortRecords(collection, choice);
            dataGridEmployees.DataSource = null;
            dataGridEmployees.DataSource = sortedCollection;
        }
    }
}
