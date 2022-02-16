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
    public partial class frm_MainUser : Form
    {
        public frm_MainUser()
        {
            InitializeComponent();
        }

        private void frm_MainUser_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
           // this.tabControl1.TabPages.Remove(tabPage1);
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            frm_Table mdi_child1 = new frm_Table();
            mdi_child1.TopLevel = false;
            mdi_child1.FormBorderStyle = FormBorderStyle.None;
            mdi_child1.Dock = DockStyle.Fill;
            tabPage1.Controls.Add(mdi_child1);
            tabControl1.Visible = true;
            tabControl1.SelectedTab = tabPage1;
            tabPage1.Text = "Làm việc";
            mdi_child1.Visible = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
