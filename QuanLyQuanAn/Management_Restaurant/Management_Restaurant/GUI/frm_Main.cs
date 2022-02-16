using Management_Restaurant.GUI.Admin;
using Management_Restaurant.GUI.User;
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
    public partial class frm_Main : Form
    {
        private int counttab1 = 0;
        private int counttab2 = 0;
        public frm_Main()
        {
            InitializeComponent();
            this.Text = Utilities.UtilsForm.GetFormTitle(this.Text);
        }

        private void btnThietLapQuanAn_Click(object sender, EventArgs e)
        {
           DialogResult dr= MessageBox.Show("Trước khi thiết lập quán ăn hãy chắc rằng các bàn đã được thanh toán!","Cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                new RestaurantSetup().ShowDialog();
                
            }
            else return;
           
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            if (counttab1 == 0)
            {
                this.tabControl1.TabPages.Add(tabPage1);
                counttab1++;
            }
            else
            {
                tabControl1.SelectedTab = tabPage1;
                return;
            }
           
            /*
            frm_Table mdi_child1 = new frm_Table();
            mdi_child1.MdiParent = this;
            mdi_child1.Show();
            */
            frm_Table mdi_child1 = new frm_Table();
            mdi_child1.TopLevel = false;
            mdi_child1.FormBorderStyle = FormBorderStyle.None;
            mdi_child1.Dock = DockStyle.Fill;
            tabPage1.Controls.Add(mdi_child1);
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage1;
            tabPage1.Text = "Làm việc";
         //   tabPage2.Text = "Thống Kê";
            mdi_child1.Visible = true;            
            /*
            this.Hide();
            new frm_Table().ShowDialog();
            this.Show();
            */
        }
        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            // this.tabControl1.TabPages.Remove(tabPage1);
            if (counttab2 == 0)
            {
                this.tabControl1.TabPages.Add(tabPage2);
                counttab2++;
            }
            else
            {
                tabControl1.SelectedTab = tabPage2;
                return;
            }

            /*
            frm_ThongKe mdi_child2 = new frm_ThongKe();
            mdi_child2.MdiParent = this;
            mdi_child2.Show();
            */
            frm_ThongKe mdi_child2 = new frm_ThongKe();
            mdi_child2.TopLevel = false;
            mdi_child2.FormBorderStyle = FormBorderStyle.None;
            mdi_child2.Dock = DockStyle.Fill;
            tabPage2.Controls.Add(mdi_child2);
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage2;
          //  tabPage1.Text = "Làm việc";
            tabPage2.Text = "Thống Kê";
            mdi_child2.Visible = true;
            /*
            this.Hide();
            new frm_ThongKe().ShowDialog();
            this.Show();
            */
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.tabControl1.TabPages.Remove(tabPage1);
            this.tabControl1.TabPages.Remove(tabPage2);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
           // this.Hide();
            //new Form1().ShowDialog();
            Application.Restart();
            //this.ShowDialog();           
        }
    }
}
