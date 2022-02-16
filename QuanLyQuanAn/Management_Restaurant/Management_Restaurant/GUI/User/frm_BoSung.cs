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

namespace Management_Restaurant.GUI.User
{
    public partial class frm_BoSung : Form
    {
        public Order order;
        public frm_BoSung()
        {
            InitializeComponent();
        }
        public frm_BoSung(Order order)
        {
            InitializeComponent();
            this.order = order;
            this.loadData();
        }
        private void loadData()
        {
            if (order != null)
            {
                if (order.Extra != null && order.ExtraContent != null)
                {
                    tvContent.Text = order.ExtraContent;
                    tvExtra.Value = (decimal)order.Extra;
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            this.addExtra();
        }

        private void tvExtra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.addExtra();
            }
        }
        private void addExtra()
        {
            if (tvContent.Text.Trim() == "") MessageBox.Show("Please, Enter the extra content!", "Warning", MessageBoxButtons.OK);
            else
            {
                if (tvExtra.Value == 0 || tvExtra.Value < 0) MessageBox.Show("Please, Enter the right value for the extra!", "Warning", MessageBoxButtons.OK);
                else
                {
                    OrderBLL orderBLL = new OrderBLL();
                    this.order = orderBLL.AddExtra(order, Convert.ToInt32(tvExtra.Value), tvContent.Text.Trim());
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
