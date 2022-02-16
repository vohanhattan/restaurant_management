namespace Management_Restaurant.GUI.Customer_Table
{
    partial class frm_AddKhuVuc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTable = new System.Windows.Forms.Panel();
            this.txtTableTo = new System.Windows.Forms.NumericUpDown();
            this.txtTableFrom = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAddTable = new System.Windows.Forms.CheckBox();
            this.txtAreaName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTable
            // 
            this.panelTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTable.Controls.Add(this.txtTableTo);
            this.panelTable.Controls.Add(this.txtTableFrom);
            this.panelTable.Controls.Add(this.label4);
            this.panelTable.Controls.Add(this.label3);
            this.panelTable.Enabled = false;
            this.panelTable.Location = new System.Drawing.Point(55, 210);
            this.panelTable.Margin = new System.Windows.Forms.Padding(4);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(352, 57);
            this.panelTable.TabIndex = 10;
            // 
            // txtTableTo
            // 
            this.txtTableTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTableTo.Location = new System.Drawing.Point(202, 20);
            this.txtTableTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTableTo.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.txtTableTo.Name = "txtTableTo";
            this.txtTableTo.Size = new System.Drawing.Size(143, 22);
            this.txtTableTo.TabIndex = 4;
            // 
            // txtTableFrom
            // 
            this.txtTableFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTableFrom.Location = new System.Drawing.Point(8, 20);
            this.txtTableFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtTableFrom.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.txtTableFrom.Name = "txtTableFrom";
            this.txtTableFrom.Size = new System.Drawing.Size(143, 22);
            this.txtTableFrom.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Table to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Table from";
            // 
            // cbAddTable
            // 
            this.cbAddTable.AutoSize = true;
            this.cbAddTable.Location = new System.Drawing.Point(55, 181);
            this.cbAddTable.Margin = new System.Windows.Forms.Padding(4);
            this.cbAddTable.Name = "cbAddTable";
            this.cbAddTable.Size = new System.Drawing.Size(94, 21);
            this.cbAddTable.TabIndex = 9;
            this.cbAddTable.Text = "Thêm bàn";
            this.cbAddTable.UseVisualStyleBackColor = true;
            this.cbAddTable.CheckedChanged += new System.EventHandler(this.cbAddTable_CheckedChanged);
            // 
            // txtAreaName
            // 
            this.txtAreaName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAreaName.Location = new System.Drawing.Point(55, 134);
            this.txtAreaName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.Size = new System.Drawing.Size(350, 22);
            this.txtAreaName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên khu vực";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thêm khu vực";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 274);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Tạo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_AddKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 353);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.cbAddTable);
            this.Controls.Add(this.txtAreaName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "frm_AddKhuVuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AddKhuVuc";
            this.panelTable.ResumeLayout(false);
            this.panelTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.NumericUpDown txtTableTo;
        private System.Windows.Forms.NumericUpDown txtTableFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbAddTable;
        private System.Windows.Forms.TextBox txtAreaName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}