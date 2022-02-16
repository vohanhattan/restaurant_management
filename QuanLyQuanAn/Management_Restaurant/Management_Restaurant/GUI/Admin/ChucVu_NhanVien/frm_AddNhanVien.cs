using Management_Restaurant.BLL;
using Management_Restaurant.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Restaurant.GUI.Admin.ChucVu_NhanVien
{
    public partial class frm_AddNhanVien : Form
    {
        DAL.Department department;
        public frm_AddNhanVien()
        {
            InitializeComponent();
        }
        public frm_AddNhanVien(DAL.Department department)
        {
            InitializeComponent();
            this.department = department;
        }

        private void tvRetypePassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.addEmployee();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.addEmployee();
        }
        private void addEmployee()
        {
            if (this.tvName.Text.Trim() == "")
            {
                MessageBox.Show("Please, enter the employee's full name!", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                if (this.tvUserName.Text.Trim() == "")
                {
                    MessageBox.Show("Please, enter your full username!", "Warning", MessageBoxButtons.OK);
                }
                else
                {
                    if (this.tvPassword.Text == this.tvRetypePassword.Text)
                    {
                        EmployeeBLL employeeBLL = new EmployeeBLL();
                        EmloyeeDepartmentBLL emloyeeDepartmentBLL = new EmloyeeDepartmentBLL();

                        string mySalt = BCrypt.Net.BCrypt.GenerateSalt();
                        string userPassWork = BCrypt.Net.BCrypt.HashPassword(this.tvRetypePassword.Text, mySalt);

                        Employee employee = employeeBLL.CreateEmployee(this.tvName.Text, this.tvUserName.Text, userPassWork);
                        EmployeeDepartment employeeDepartment = new EmployeeDepartment();
                        employeeDepartment.DepartmentID = department.ID;
                        employeeDepartment.EmployeeID = employee.ID;
                        emloyeeDepartmentBLL.CreateEmployeeDepartment(employeeDepartment);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("The retype password you entered is incorrect!", "Warning", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            this.addEmployee();
        }
    }
}
