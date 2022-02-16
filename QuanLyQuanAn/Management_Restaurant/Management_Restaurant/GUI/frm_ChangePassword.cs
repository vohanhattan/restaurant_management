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

namespace Management_Restaurant.GUI
{
    public partial class frm_ChangePassword : Form
    {
        public Employee employee;
        public frm_ChangePassword()
        {
            InitializeComponent();
        }
        public frm_ChangePassword(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (this.txtmkmoi.Text == "")
            {
                MessageBox.Show("Please, enter your new password!", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                if (this.txtmkcu.Text == "")
                {
                    MessageBox.Show("Please, enter your old password!", "Warning", MessageBoxButtons.OK);
                }
                else
                {
                    if (this.txtnhaplaimk.Text == "")
                    {
                        MessageBox.Show("Please, enter your retype password!", "Warning", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (!BCrypt.Net.BCrypt.CheckPassword(this.txtmkcu.Text, employee.Password))
                        {
                            MessageBox.Show("Old password entered incorrectly!", "Warning", MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (this.txtmkmoi.Text != this.txtnhaplaimk.Text)
                            {
                                MessageBox.Show("You re-enter the password incorrectly!", "Warning", MessageBoxButtons.OK);
                            }
                            else
                            {
                                EmployeeBLL employeeBLL = new EmployeeBLL();

                                string mySalt = BCrypt.Net.BCrypt.GenerateSalt();
                                string userNewPasswork = BCrypt.Net.BCrypt.HashPassword(this.txtnhaplaimk.Text, mySalt);

                                this.employee.Password = userNewPasswork;
                                employeeBLL.Update(employee);

                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                    }
                }
            
            }
        }
    }
}
