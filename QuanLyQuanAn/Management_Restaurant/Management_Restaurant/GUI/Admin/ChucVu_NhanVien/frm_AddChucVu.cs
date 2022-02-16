using Management_Restaurant.BLL;
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
    public partial class frm_AddChucVu : Form
    {
        public frm_AddChucVu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.addDepartment();
            }
        }
        private void addDepartment()
        {
            DepartmentBLL departmentBLL = new DepartmentBLL();
            departmentBLL.CreateDepartment(this.txtName.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            this.addDepartment();
        }
    }
}
