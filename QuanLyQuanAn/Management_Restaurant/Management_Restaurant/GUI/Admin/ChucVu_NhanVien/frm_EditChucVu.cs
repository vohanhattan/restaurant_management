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
    public partial class frm_EditChucVu : Form
    {
        public DAL.Department department;

        public frm_EditChucVu()
        {
            InitializeComponent();
            this.LoadData();
        }

        public frm_EditChucVu(DAL.Department department)
        {
            this.department = department;

            InitializeComponent();
            this.LoadData();
        }

        private void LoadData()
        {
            this.tvNameOfDepartment.Text = this.department.Name;
        }      
        private void save()
        {
            this.department.Name = this.tvNameOfDepartment.Text;
            DepartmentBLL departmentBLL = new DepartmentBLL();
            departmentBLL.Update(this.department);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tvNameOfDepartment_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.save();
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            this.save();
        }
    }
}
