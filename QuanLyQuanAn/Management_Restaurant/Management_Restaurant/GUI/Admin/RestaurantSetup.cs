using Management_Restaurant.GUI.Admin.ChucVu_NhanVien;
using Management_Restaurant.GUI.Admin.Menu;
using Management_Restaurant.GUI.Customer_Table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Restaurant.GUI.Admin
{
    public partial class RestaurantSetup : Form
    {
        public RestaurantSetup()
        {
            InitializeComponent();
            this.Text = Utilities.UtilsForm.GetFormTitle(this.Text);
        }
        private void btnSeat_Click(object sender, EventArgs e)
        {
          //  new SeatSetup().Show();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
           // new DepartmentSetup().Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
           // new MenuSetup().Show();
        }
        private void btnSeat_Click_1(object sender, EventArgs e)
        {
            /*
            this.Hide();
            new frm_ThiepLapBanAn().ShowDialog();
            this.Show();
            */
            frm_ThiepLapBanAn mdi_child1 = new frm_ThiepLapBanAn();
            mdi_child1.TopLevel = false;
            mdi_child1.FormBorderStyle = FormBorderStyle.None;
            mdi_child1.Dock = DockStyle.Fill;
            tabPage1.Controls.Add(mdi_child1);
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage1;
            tabPage1.Text = "Thiết lập bàn ăn";
            tabPage2.Text = "Thiết lập thực đơn";
            tabPage3.Text = "Thiết lập nhân viên";
            mdi_child1.Visible = true;
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            /*
            this.Hide();
            new frm_ThietLapMenu().ShowDialog();          
            this.Show();
            */
            frm_ThietLapMenu mdi_child2 = new frm_ThietLapMenu();
            mdi_child2.TopLevel = false;
            mdi_child2.FormBorderStyle = FormBorderStyle.None;
            mdi_child2.Dock = DockStyle.Fill;
            tabPage2.Controls.Add(mdi_child2);
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage2;
            tabPage1.Text = "Thiết lập bàn ăn";
            tabPage2.Text = "Thiết lập thực đơn";
            tabPage3.Text = "Thiết lập nhân viên";
            mdi_child2.Visible = true;
        }
        private void btnDepartment_Click_1(object sender, EventArgs e)
        {
            /*
            this.Hide();
            new frm_ThietLapPhongBan().ShowDialog();
            this.Show();
            */
            frm_ThietLapPhongBan mdi_child3 = new frm_ThietLapPhongBan();
            mdi_child3.TopLevel = false;
            mdi_child3.FormBorderStyle = FormBorderStyle.None;
            mdi_child3.Dock = DockStyle.Fill;
            tabPage3.Controls.Add(mdi_child3);
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage3;
            tabPage1.Text = "Thiết lập bàn ăn";
            tabPage2.Text = "Thiết lập thực đơn";
            tabPage3.Text = "Thiết lập nhân viên";
            mdi_child3.Visible = true;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RestaurantSetup_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            //Application.Restart();
            this.DialogResult = DialogResult.OK;
            this.Close();
            //new frm_Main().ShowDialog();
        }
    }
}
