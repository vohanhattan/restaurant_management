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

namespace Management_Restaurant.GUI.Admin.Menu
{
    public partial class frm_AddMenu : Form
    {
        private DAL.Menu menu;
        public frm_AddMenu()
        {
            InitializeComponent();
        }
        public frm_AddMenu(DAL.Menu menu)
        {
            InitializeComponent();
            this.label2.Text = "Edit menu";
            this.btnAddMenu.Text = "Update";
            this.menu = menu;
            this.txtName.Text = this.menu.Name;
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please fill menu's name.");
                return;
            }

            MenuBLL menuBLL = new MenuBLL();
            if (this.menu == null)
            {
                menuBLL.CreateMenu(txtName.Text);
            }
            else
            {
                menuBLL.Update(this.menu, txtName.Text);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
