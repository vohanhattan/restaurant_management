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

namespace Management_Restaurant.GUI.Customer_Table
{
    public partial class frm_EditKhuVuc : Form
    {
        public DAL.Area area;
        public frm_EditKhuVuc()
        {
            InitializeComponent();
        }
        public frm_EditKhuVuc(DAL.Area area)
        {
            InitializeComponent();
            this.area = area;
            this.LoadData();
        }

        private void LoadData()
        {
            this.txtName.Text = this.area.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.save();
        }
        private void save()
        {
            this.area.Name = this.txtName.Text;
            AreaBLL areaBLL = new AreaBLL();
            areaBLL.Update(this.area);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.save();
            }
        }
    }
}
