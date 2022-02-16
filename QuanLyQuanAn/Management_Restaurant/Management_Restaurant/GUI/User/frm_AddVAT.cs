﻿using Management_Restaurant.BLL;
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
    public partial class frm_AddVAT : Form
    {
        private DAL.Order order;
        public frm_AddVAT()
        {
            InitializeComponent();
            this.numericUpDown1.Controls[0].Visible = false;
        }
        public frm_AddVAT(DAL.Order order)
        {
            InitializeComponent();
            this.numericUpDown1.Controls[0].Visible = false;
            this.Order = order;
        }
        public Order Order
        {
            get { return order; }
            set
            {
                order = value;
                if (order.VAT != null)
                {
                    this.checkBox1.Checked = this.order.VAT == null;
                    if (this.order.VAT != null)
                    {
                        this.checkBox1.Checked = false;
                        this.numericUpDown1.Value = (decimal)order.VAT;
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.numericUpDown1.ReadOnly = this.checkBox1.Checked;
            this.numericUpDown1.Controls[0].Visible = !this.checkBox1.Checked;
            if (this.checkBox1.Checked)
                this.numericUpDown1.Value = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OrderBLL orderBLL = new OrderBLL();
            if (this.checkBox1.Checked)
            {
                orderBLL.AddVAT(this.Order, null);
            }
            else
            {
                orderBLL.AddVAT(this.Order, this.numericUpDown1.Value);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
