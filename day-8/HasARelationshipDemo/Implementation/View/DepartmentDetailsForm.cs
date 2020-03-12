using Implementation.DAL;
using Implementation.IOC;
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

            comboBoxDepartments.DataSource = departments;
            comboBoxDepartments.DisplayMember = "DepartmentName";
        }

        private void comboBoxDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDepartment = comboBoxDepartments.SelectedItem as Department;

            if (selectedDepartment != null)
            {
                EmployeeDataAccessObject employeeDao = new EmployeeDataAccessObject();
                var list = employeeDao.GetById(selectedDepartment.DepartmentId);

                if(list != null && list.Count > 0)
                {
                    dataGridEmployees.AutoGenerateColumns = false;
                    dataGridEmployees.DataSource = list;
                }
            }
        }
    }
}
