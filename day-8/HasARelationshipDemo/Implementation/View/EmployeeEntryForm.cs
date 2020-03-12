﻿using Implementation.DAL;
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
    public partial class EmployeeEntryForm : Form
    {
        public EmployeeEntryForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);
            string name = textBoxName.Text;
            decimal salary = decimal.Parse(textBoxSalary.Text);
            Department selectedDepartment = comboBoxDepartments.SelectedItem as Department;

            Employee employee = new Employee
            {
                EmployeeId = id,
                EmployeeName = name,
                Salary = salary,
                DepartmentInfo = selectedDepartment
            };

            EmployeeDataAccessObject employeeDao = new EmployeeDataAccessObject();
            bool status = employeeDao.Add(employee);
            if (status)
                MessageBox.Show("employee record added successfully");
            else
                MessageBox.Show("employee record not added");
            Reset();
        }

        private void Reset()
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxSalary.Text = "";
        }

        private void EmployeeEntryForm_Load(object sender, EventArgs e)
        {
            DepartmentDataAccessObject departmentDao =
                new DepartmentDataAccessObject();
            var departments = departmentDao.GetAll();

            comboBoxDepartments.DataSource = departments.ToList<Department>();
            comboBoxDepartments.DisplayMember = "DepartmentName";
        }
    }
}
