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

namespace Management_Restaurant.GUI.Customer_Table
{
    public partial class frm_EditBanAn : Form
    {
        public Table table;
        public frm_EditBanAn()
        {
            InitializeComponent();
            this.LoadData();
        }
        public frm_EditBanAn(Table table)
        {
            this.table = table;

            InitializeComponent();
            this.LoadData();
        }
        private void LoadData()
        {
            this.txtName.Text = this.table.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.save();
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.save();
            }
        }
        private void save()
        {
            this.table.Name = this.txtName.Text;
            TableBLL tableBLL = new TableBLL();
            tableBLL.Update(this.table);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
