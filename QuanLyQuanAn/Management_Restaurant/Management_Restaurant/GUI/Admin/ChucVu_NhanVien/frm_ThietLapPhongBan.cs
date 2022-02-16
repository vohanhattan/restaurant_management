using Management_Restaurant.BLL;
using Management_Restaurant.DAL;
using Management_Restaurant.GUI.Control;
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
    public partial class frm_ThietLapPhongBan : Form
    {
        List<DataGridView> listDataGridView = new List<DataGridView>();
        public frm_ThietLapPhongBan()
        {
            InitializeComponent();
            this.Text = Utilities.UtilsForm.GetFormTitle(this.Text);
            this.LoadData();
        }
        public void LoadData()
        {
            this.tabControl.Controls.Clear();
            listDataGridView.Clear();

            DepartmentBLL departmentBLL = new DepartmentBLL();
            List<DAL.Department> listDepartment = departmentBLL.ListDepartment();
            for (int i = 0; i < listDepartment.Count; i++)
            {
                var t = new System.Windows.Forms.TabPage();
                t.Name = listDepartment[i].Name;
                t.Text = listDepartment[i].Name;
                t.Location = new System.Drawing.Point(4, 22);
                t.Padding = new System.Windows.Forms.Padding(3);
                t.Size = new System.Drawing.Size(597, 257);
                t.UseVisualStyleBackColor = true;
                t.AutoScroll = true;

                //add gridview
                var dataGridView = new System.Windows.Forms.DataGridView();
                var bindingSource = new System.Windows.Forms.BindingSource();
                ((System.ComponentModel.ISupportInitialize)(dataGridView)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(bindingSource)).BeginInit();
                dataGridView.AutoGenerateColumns = false;
                dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dataGridView.DataSource = bindingSource;
                dataGridView.Location = new System.Drawing.Point(0, 0);
                dataGridView.Size = new System.Drawing.Size(567, 228);

                var col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                var col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                var col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                col1.DataPropertyName = "ID";
                col1.HeaderText = "ID";
                col1.Width = 174;
                col2.DataPropertyName = "Name";
                col2.HeaderText = "Name";
                col2.Width = 174;
                col3.DataPropertyName = "Username";
                col3.HeaderText = "Username";
                col3.Width = 176;
                dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { col1, col2, col3 });

                //add list data gridview

                listDataGridView.Add(dataGridView);

                // add addbutton
                Button button = new Button();
                button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                button.Location = new System.Drawing.Point(490, 7);
                button.Size = new System.Drawing.Size(100, 20);
                button.Tag = listDepartment[i];
                button.Text = "Thêm nhân viên";
                button.Click += new EventHandler(this.btnAddEmloyee_Click);

                t.Controls.Add(button);

                // add button edit department

                Button btEditDepartment = new Button();
                btEditDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                btEditDepartment.Location = new System.Drawing.Point(490, 30);
                btEditDepartment.Size = new System.Drawing.Size(100, 20);
                btEditDepartment.Tag = listDepartment[i];
                btEditDepartment.Text = "Edit Chức vụ";
                btEditDepartment.Click += new EventHandler(this.btEditDepartment_Click);

                t.Controls.Add(btEditDepartment);

                // add button delete department

                if (listDepartment[i].ID != 1 && listDepartment[i].ID != 2)
                {
                    Button btDeleteDepartment = new Button();
                    btDeleteDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
                    btDeleteDepartment.Location = new System.Drawing.Point(480, 55);
                    btDeleteDepartment.Size = new System.Drawing.Size(120, 20);
                    btDeleteDepartment.Tag = listDepartment[i];
                    btDeleteDepartment.Text = "Xóa chức vụ";
                    btDeleteDepartment.Click += new EventHandler(this.btDeleteDepartment_Click);

                    t.Controls.Add(btDeleteDepartment);
                }

                //get emloyees for department 

                EmployeeBLL employeeBLL = new EmployeeBLL();
                List<Employee> listEmployee = employeeBLL.ListEmployeeByDepartment(listDepartment[i]);
                dataGridView.DataSource = listEmployee;

                t.Controls.Add(dataGridView);
                //var dmc = new DepartmentControl(listDepartment[i]);
                //dmc.OnDelete += new DepartmentControl.OnDeleteHandler(this.departmentControl_OnDelete);
                //int cols = (this.Width - minPadding) / (width + minPadding);
                //int rows = (this.Height - minPadding) / (height + minPadding);
                //dmc.Location = new System.Drawing.Point(minPadding + (width + minPadding) , minPadding + (height + minPadding) );
                //dmc.Size = new System.Drawing.Size(width, height);
                //t.Controls.Add(dmc);

                this.tabControl.Controls.Add(t);
            }
            this.UpdateControlPosition();
        }
        private void btEditDepartment_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DAL.Department department = (DAL.Department)btn.Tag;
            this.EditDepartment(department);
        }

        private void btDeleteDepartment_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DAL.Department department = (DAL.Department)btn.Tag;
            this.DeleteDepartment(department);
        }

        private void btnAddEmloyee_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DAL.Department department = (DAL.Department)btn.Tag;
            new frm_AddNhanVien(department).ShowDialog();
            this.LoadData();
        }


        private void UpdateControlPosition()
        {
            int tableWidth = 150;
            int tableHeight = 70;
            int minPadding = 6;

            List<TableControl> controls = this.Controls.OfType<TableControl>().ToList();

            int cols = (this.Width - minPadding) / (tableWidth + minPadding);
            int rows = (this.Height - minPadding) / (tableHeight + minPadding);

            // calculate paddingHorizontal
            int containerWidth = (tableWidth + minPadding) * Math.Min(cols, controls.Count) - minPadding;
            int paddingHorizontal = (this.Width - containerWidth) / 2;

            for (int j = 0; j < controls.Count; j++)
            {
                int x = j % cols;
                int y = j / cols;
                controls[j].Size = new System.Drawing.Size(tableWidth, tableHeight);
                controls[j].Location = new System.Drawing.Point(paddingHorizontal + (tableWidth + minPadding) * x, minPadding + (tableHeight + minPadding) * y);
            }
        }

        private void DepartmentSetup_Resize(object sender, EventArgs e)
        {
            this.UpdateControlPosition();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl_TabIndexChanged(object sender, EventArgs e)
        {
            this.UpdateControlPosition();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void editPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void DeleteDepartment(DAL.Department department)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc là xóa chức vụ này \"" + department.Name + "\"", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                EmloyeeDepartmentBLL emloyeeDepartmentBLL = new EmloyeeDepartmentBLL();
                EmployeeBLL employeeBLL = new EmployeeBLL();
                employeeBLL.DeleteByDepartment(emloyeeDepartmentBLL.ListEmployeeDepartmentByDepartment(department));
                DepartmentBLL departmentBLL = new DepartmentBLL();
                departmentBLL.DeleteDepartment(department);
                this.LoadData();
            }
        }

        private void EditDepartment(DAL.Department department)
        {
            frm_EditChucVu departmentEditDialog = new frm_EditChucVu(department);
            DialogResult dr = departmentEditDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.LoadData();
            }
        }

        

        private void frm_ThietLapPhongBan_Load(object sender, EventArgs e)
        {

        }

        private void btnAddDepartment_Click_1(object sender, EventArgs e)
        {
            frm_AddChucVu departmentAddDialog = new frm_AddChucVu();
            DialogResult dr = departmentAddDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.LoadData();
            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DataGridView dgv = this.listDataGridView[this.tabControl.SelectedIndex];
            int index;
            try
            {
                index = dgv.SelectedRows[0].Index;
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn nhân viên mà bạn muốn xóa bên dưới!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<Employee> listEmp = (List<Employee>)dgv.DataSource;

            if (MessageBox.Show("Bạn có chắc là xóa nhân viên này \"" + listEmp[index].Name + "\"", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EmployeeBLL employeeBLL = new EmployeeBLL();
                employeeBLL.Delete(listEmp[index]);
                this.LoadData();

            }
        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DataGridView dgv = this.listDataGridView[this.tabControl.SelectedIndex];
            int index;
            try
            {
                index = dgv.SelectedRows[0].Index;
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần chỉnh sửa thông tin!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<Employee> listEmp = (List<Employee>)dgv.DataSource;

            frm_EditNhanVien emloyeeEditDialog = new frm_EditNhanVien(listEmp[index]);
            DialogResult dr = emloyeeEditDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.LoadData();
            }
        }

        private void editPasswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DataGridView dgv = this.listDataGridView[this.tabControl.SelectedIndex];
            int index;
            try
            {
                index = dgv.SelectedRows[0].Index;
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn nhân viên mà bạn cần đổi mật khẩu!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<Employee> listEmp = (List<Employee>)dgv.DataSource;

            frm_ChangePassword ChangePassword = new frm_ChangePassword(listEmp[index]);
            DialogResult dr = ChangePassword.ShowDialog();
            if (dr == DialogResult.OK)
            {

            }
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            DataGridView dgv = this.listDataGridView[this.tabControl.SelectedIndex];
            int index;
            try
            {
                 index = dgv.SelectedRows[0].Index;                
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa bên dưới!","WARNING",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            List<Employee> listEmp = (List<Employee>)dgv.DataSource;

            if (MessageBox.Show("Bạn có chắc là muốn xóa nhân viên này \"" + listEmp[index].Name + "\"", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EmployeeBLL employeeBLL = new EmployeeBLL();
                employeeBLL.Delete(listEmp[index]);
                this.LoadData();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridView dgv = this.listDataGridView[this.tabControl.SelectedIndex];
            int index;
            try
            {
                index = dgv.SelectedRows[0].Index;
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần chỉnh sửa thông tin!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<Employee> listEmp = (List<Employee>)dgv.DataSource;

            frm_EditNhanVien emloyeeEditDialog = new frm_EditNhanVien(listEmp[index]);
            DialogResult dr = emloyeeEditDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.LoadData();
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            DataGridView dgv = this.listDataGridView[this.tabControl.SelectedIndex];
            int index;
            try
            {
                index = dgv.SelectedRows[0].Index;
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn nhân viên mà bạn cần đổi mật khẩu bên dưới!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<Employee> listEmp = (List<Employee>)dgv.DataSource;

            frm_ChangePassword ChangePassword = new frm_ChangePassword(listEmp[index]);
            DialogResult dr = ChangePassword.ShowDialog();
            if (dr == DialogResult.OK)
            {

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
