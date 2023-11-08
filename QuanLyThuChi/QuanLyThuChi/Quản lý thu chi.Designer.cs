
namespace QuanLyThuChi
{
    partial class Quản_lý_thu_chi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnthoatChi = new System.Windows.Forms.Button();
            this.txtghichuChi = new System.Windows.Forms.TextBox();
            this.txtTimChi = new System.Windows.Forms.TextBox();
            this.txtSotienChi = new System.Windows.Forms.TextBox();
            this.cbxTenChi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoaChi = new System.Windows.Forms.Button();
            this.btnTimChi = new System.Windows.Forms.Button();
            this.btnSuaChi = new System.Windows.Forms.Button();
            this.datetimeNgayChi = new System.Windows.Forms.DateTimePicker();
            this.dgvKhoanChi = new System.Windows.Forms.DataGridView();
            this.btnThemChi = new System.Windows.Forms.Button();
            this.dgvTenChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoTienChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvThoiGianChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGhiChuChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanChi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnthoatChi);
            this.tabPage1.Controls.Add(this.txtghichuChi);
            this.tabPage1.Controls.Add(this.txtTimChi);
            this.tabPage1.Controls.Add(this.txtSotienChi);
            this.tabPage1.Controls.Add(this.cbxTenChi);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnXoaChi);
            this.tabPage1.Controls.Add(this.btnTimChi);
            this.tabPage1.Controls.Add(this.btnSuaChi);
            this.tabPage1.Controls.Add(this.btnThemChi);
            this.tabPage1.Controls.Add(this.datetimeNgayChi);
            this.tabPage1.Controls.Add(this.dgvKhoanChi);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Khoản chi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnthoatChi
            // 
            this.btnthoatChi.Location = new System.Drawing.Point(651, 57);
            this.btnthoatChi.Name = "btnthoatChi";
            this.btnthoatChi.Size = new System.Drawing.Size(70, 43);
            this.btnthoatChi.TabIndex = 21;
            this.btnthoatChi.Text = "Thoát";
            this.btnthoatChi.UseVisualStyleBackColor = true;
            // 
            // txtghichuChi
            // 
            this.txtghichuChi.Location = new System.Drawing.Point(147, 120);
            this.txtghichuChi.Name = "txtghichuChi";
            this.txtghichuChi.Size = new System.Drawing.Size(145, 22);
            this.txtghichuChi.TabIndex = 18;
            // 
            // txtTimChi
            // 
            this.txtTimChi.Location = new System.Drawing.Point(445, 13);
            this.txtTimChi.Name = "txtTimChi";
            this.txtTimChi.Size = new System.Drawing.Size(188, 22);
            this.txtTimChi.TabIndex = 19;
            // 
            // txtSotienChi
            // 
            this.txtSotienChi.Location = new System.Drawing.Point(147, 45);
            this.txtSotienChi.Name = "txtSotienChi";
            this.txtSotienChi.Size = new System.Drawing.Size(145, 22);
            this.txtSotienChi.TabIndex = 20;
            // 
            // cbxTenChi
            // 
            this.cbxTenChi.FormattingEnabled = true;
            this.cbxTenChi.Items.AddRange(new object[] {
            "Ăn uống",
            "Tiền điện",
            "Tiền nước",
            "Tiền xăng",
            "Quần áo",
            "Mua sắm",
            "Nhà ở",
            "Du lịch",
            "Đồ uống",
            "Quà"});
            this.cbxTenChi.Location = new System.Drawing.Point(147, 11);
            this.cbxTenChi.Name = "cbxTenChi";
            this.cbxTenChi.Size = new System.Drawing.Size(145, 24);
            this.cbxTenChi.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ghi chú";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thời gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên khoản chi";
            // 
            // btnXoaChi
            // 
            this.btnXoaChi.Location = new System.Drawing.Point(317, 106);
            this.btnXoaChi.Name = "btnXoaChi";
            this.btnXoaChi.Size = new System.Drawing.Size(71, 42);
            this.btnXoaChi.TabIndex = 9;
            this.btnXoaChi.Text = "Xóa";
            this.btnXoaChi.UseVisualStyleBackColor = true;
            // 
            // btnTimChi
            // 
            this.btnTimChi.Location = new System.Drawing.Point(651, 13);
            this.btnTimChi.Name = "btnTimChi";
            this.btnTimChi.Size = new System.Drawing.Size(70, 24);
            this.btnTimChi.TabIndex = 10;
            this.btnTimChi.Text = "Tìm";
            this.btnTimChi.UseVisualStyleBackColor = true;
            // 
            // btnSuaChi
            // 
            this.btnSuaChi.Location = new System.Drawing.Point(317, 57);
            this.btnSuaChi.Name = "btnSuaChi";
            this.btnSuaChi.Size = new System.Drawing.Size(71, 43);
            this.btnSuaChi.TabIndex = 11;
            this.btnSuaChi.Text = "Sửa";
            this.btnSuaChi.UseVisualStyleBackColor = true;
            // 
            // datetimeNgayChi
            // 
            this.datetimeNgayChi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeNgayChi.Location = new System.Drawing.Point(147, 82);
            this.datetimeNgayChi.Name = "datetimeNgayChi";
            this.datetimeNgayChi.Size = new System.Drawing.Size(145, 22);
            this.datetimeNgayChi.TabIndex = 8;
            // 
            // dgvKhoanChi
            // 
            this.dgvKhoanChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoanChi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKhoanChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoanChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTenChi,
            this.dgvSoTienChi,
            this.dgvThoiGianChi,
            this.dgvGhiChuChi});
            this.dgvKhoanChi.Location = new System.Drawing.Point(21, 174);
            this.dgvKhoanChi.Name = "dgvKhoanChi";
            this.dgvKhoanChi.RowHeadersWidth = 51;
            this.dgvKhoanChi.RowTemplate.Height = 24;
            this.dgvKhoanChi.Size = new System.Drawing.Size(745, 231);
            this.dgvKhoanChi.TabIndex = 7;
            // 
            // btnThemChi
            // 
            this.btnThemChi.ForeColor = System.Drawing.Color.Indigo;
            this.btnThemChi.Image = global::QuanLyThuChi.Properties.Resources.tich_xanh_icon;
            this.btnThemChi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemChi.Location = new System.Drawing.Point(317, 11);
            this.btnThemChi.Name = "btnThemChi";
            this.btnThemChi.Size = new System.Drawing.Size(71, 40);
            this.btnThemChi.TabIndex = 12;
            this.btnThemChi.Text = "Thêm";
            this.btnThemChi.UseVisualStyleBackColor = true;
            this.btnThemChi.Click += new System.EventHandler(this.btnThemChi_Click);
            // 
            // dgvTenChi
            // 
            this.dgvTenChi.DataPropertyName = "Tenchi";
            this.dgvTenChi.HeaderText = "Tên khoản chi";
            this.dgvTenChi.MinimumWidth = 6;
            this.dgvTenChi.Name = "dgvTenChi";
            // 
            // dgvSoTienChi
            // 
            this.dgvSoTienChi.DataPropertyName = "Sotienchi";
            this.dgvSoTienChi.HeaderText = "Số tiền";
            this.dgvSoTienChi.MinimumWidth = 6;
            this.dgvSoTienChi.Name = "dgvSoTienChi";
            // 
            // dgvThoiGianChi
            // 
            this.dgvThoiGianChi.DataPropertyName = "Thoigianchi";
            this.dgvThoiGianChi.HeaderText = "Thời gian";
            this.dgvThoiGianChi.MinimumWidth = 6;
            this.dgvThoiGianChi.Name = "dgvThoiGianChi";
            // 
            // dgvGhiChuChi
            // 
            this.dgvGhiChuChi.DataPropertyName = "Ghichu";
            this.dgvGhiChuChi.HeaderText = "Ghi chú";
            this.dgvGhiChuChi.MinimumWidth = 6;
            this.dgvGhiChuChi.Name = "dgvGhiChuChi";
            // 
            // Quản_lý_thu_chi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Quản_lý_thu_chi";
            this.Text = "Quản_lý_thu_chi";
            this.Load += new System.EventHandler(this.Quản_lý_thu_chi_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanChi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnthoatChi;
        private System.Windows.Forms.TextBox txtghichuChi;
        private System.Windows.Forms.TextBox txtTimChi;
        private System.Windows.Forms.TextBox txtSotienChi;
        private System.Windows.Forms.ComboBox cbxTenChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoaChi;
        private System.Windows.Forms.Button btnTimChi;
        private System.Windows.Forms.Button btnSuaChi;
        private System.Windows.Forms.Button btnThemChi;
        private System.Windows.Forms.DateTimePicker datetimeNgayChi;
        private System.Windows.Forms.DataGridView dgvKhoanChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSoTienChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvThoiGianChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGhiChuChi;
    }
}