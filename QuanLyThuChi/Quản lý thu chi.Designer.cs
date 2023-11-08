
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quản_lý_thu_chi));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGhiFile = new System.Windows.Forms.Button();
            this.grboxTimChi = new System.Windows.Forms.GroupBox();
            this.txtTimChi = new System.Windows.Forms.TextBox();
            this.btnTimChi = new System.Windows.Forms.Button();
            this.btnthoatChi = new System.Windows.Forms.Button();
            this.txtghichuChi = new System.Windows.Forms.TextBox();
            this.txtSotienChi = new System.Windows.Forms.TextBox();
            this.cbxTenChi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoaChi = new System.Windows.Forms.Button();
            this.btnSuaChi = new System.Windows.Forms.Button();
            this.btnThemChi = new System.Windows.Forms.Button();
            this.datetimeNgayChi = new System.Windows.Forms.DateTimePicker();
            this.dgvKhoanChi = new System.Windows.Forms.DataGridView();
            this.dgvTenChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoTienChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvThoiGianChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGhiChuChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grboxTimChi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanChi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(948, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.btnGhiFile);
            this.tabPage1.Controls.Add(this.grboxTimChi);
            this.tabPage1.Controls.Add(this.btnthoatChi);
            this.tabPage1.Controls.Add(this.txtghichuChi);
            this.tabPage1.Controls.Add(this.txtSotienChi);
            this.tabPage1.Controls.Add(this.cbxTenChi);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnXoaChi);
            this.tabPage1.Controls.Add(this.btnSuaChi);
            this.tabPage1.Controls.Add(this.btnThemChi);
            this.tabPage1.Controls.Add(this.datetimeNgayChi);
            this.tabPage1.Controls.Add(this.dgvKhoanChi);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(940, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Khoản chi";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnGhiFile
            // 
            this.btnGhiFile.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiFile.Location = new System.Drawing.Point(723, 106);
            this.btnGhiFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGhiFile.Name = "btnGhiFile";
            this.btnGhiFile.Size = new System.Drawing.Size(100, 42);
            this.btnGhiFile.TabIndex = 10;
            this.btnGhiFile.Text = "Ghi File";
            this.btnGhiFile.UseVisualStyleBackColor = true;
            this.btnGhiFile.Click += new System.EventHandler(this.btnGhiFile_Click);
            // 
            // grboxTimChi
            // 
            this.grboxTimChi.Controls.Add(this.txtTimChi);
            this.grboxTimChi.Controls.Add(this.btnTimChi);
            this.grboxTimChi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxTimChi.Location = new System.Drawing.Point(599, 11);
            this.grboxTimChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grboxTimChi.Name = "grboxTimChi";
            this.grboxTimChi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grboxTimChi.Size = new System.Drawing.Size(329, 80);
            this.grboxTimChi.TabIndex = 22;
            this.grboxTimChi.TabStop = false;
            this.grboxTimChi.Text = "Tìm thông tin khoản chi";
            // 
            // txtTimChi
            // 
            this.txtTimChi.Location = new System.Drawing.Point(5, 30);
            this.txtTimChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimChi.Name = "txtTimChi";
            this.txtTimChi.Size = new System.Drawing.Size(217, 29);
            this.txtTimChi.TabIndex = 8;
            // 
            // btnTimChi
            // 
            this.btnTimChi.Location = new System.Drawing.Point(235, 30);
            this.btnTimChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimChi.Name = "btnTimChi";
            this.btnTimChi.Size = new System.Drawing.Size(69, 27);
            this.btnTimChi.TabIndex = 9;
            this.btnTimChi.Text = "Tìm";
            this.btnTimChi.UseVisualStyleBackColor = true;
            this.btnTimChi.Click += new System.EventHandler(this.btnTimChi_Click);
            // 
            // btnthoatChi
            // 
            this.btnthoatChi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoatChi.Location = new System.Drawing.Point(833, 106);
            this.btnthoatChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthoatChi.Name = "btnthoatChi";
            this.btnthoatChi.Size = new System.Drawing.Size(80, 43);
            this.btnthoatChi.TabIndex = 11;
            this.btnthoatChi.Text = "Thoát";
            this.btnthoatChi.UseVisualStyleBackColor = true;
            this.btnthoatChi.Click += new System.EventHandler(this.btnthoatChi_Click);
            // 
            // txtghichuChi
            // 
            this.txtghichuChi.Location = new System.Drawing.Point(237, 128);
            this.txtghichuChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtghichuChi.Name = "txtghichuChi";
            this.txtghichuChi.Size = new System.Drawing.Size(220, 29);
            this.txtghichuChi.TabIndex = 4;
            // 
            // txtSotienChi
            // 
            this.txtSotienChi.Location = new System.Drawing.Point(237, 52);
            this.txtSotienChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSotienChi.Name = "txtSotienChi";
            this.txtSotienChi.Size = new System.Drawing.Size(220, 29);
            this.txtSotienChi.TabIndex = 2;
            // 
            // cbxTenChi
            // 
            this.cbxTenChi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxTenChi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbxTenChi.Location = new System.Drawing.Point(237, 17);
            this.cbxTenChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTenChi.Name = "cbxTenChi";
            this.cbxTenChi.Size = new System.Drawing.Size(220, 29);
            this.cbxTenChi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ghi chú";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thời gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên khoản chi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnXoaChi
            // 
            this.btnXoaChi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaChi.Location = new System.Drawing.Point(492, 121);
            this.btnXoaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaChi.Name = "btnXoaChi";
            this.btnXoaChi.Size = new System.Drawing.Size(84, 42);
            this.btnXoaChi.TabIndex = 7;
            this.btnXoaChi.Text = "Xóa";
            this.btnXoaChi.UseVisualStyleBackColor = true;
            this.btnXoaChi.Click += new System.EventHandler(this.btnXoaChi_Click);
            // 
            // btnSuaChi
            // 
            this.btnSuaChi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaChi.Location = new System.Drawing.Point(492, 69);
            this.btnSuaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaChi.Name = "btnSuaChi";
            this.btnSuaChi.Size = new System.Drawing.Size(84, 43);
            this.btnSuaChi.TabIndex = 6;
            this.btnSuaChi.Text = "Sửa";
            this.btnSuaChi.UseVisualStyleBackColor = true;
            this.btnSuaChi.Click += new System.EventHandler(this.btnSuaChi_Click);
            // 
            // btnThemChi
            // 
            this.btnThemChi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemChi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemChi.Image = global::QuanLyThuChi.Properties.Resources.tich_xanh_icon;
            this.btnThemChi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemChi.Location = new System.Drawing.Point(492, 17);
            this.btnThemChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemChi.Name = "btnThemChi";
            this.btnThemChi.Size = new System.Drawing.Size(84, 39);
            this.btnThemChi.TabIndex = 5;
            this.btnThemChi.Text = "Thêm";
            this.btnThemChi.UseVisualStyleBackColor = true;
            this.btnThemChi.Click += new System.EventHandler(this.btnThemChi_Click);
            // 
            // datetimeNgayChi
            // 
            this.datetimeNgayChi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeNgayChi.Location = new System.Drawing.Point(237, 89);
            this.datetimeNgayChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datetimeNgayChi.Name = "datetimeNgayChi";
            this.datetimeNgayChi.Size = new System.Drawing.Size(220, 29);
            this.datetimeNgayChi.TabIndex = 3;
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
            this.dgvKhoanChi.Location = new System.Drawing.Point(32, 174);
            this.dgvKhoanChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKhoanChi.Name = "dgvKhoanChi";
            this.dgvKhoanChi.RowHeadersWidth = 51;
            this.dgvKhoanChi.RowTemplate.Height = 24;
            this.dgvKhoanChi.Size = new System.Drawing.Size(881, 231);
            this.dgvKhoanChi.TabIndex = 7;
            this.dgvKhoanChi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoanChi_CellClick);
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
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(940, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Quản_lý_thu_chi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(949, 448);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Quản_lý_thu_chi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản_lý_thu_chi";
            this.Load += new System.EventHandler(this.Quản_lý_thu_chi_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grboxTimChi.ResumeLayout(false);
            this.grboxTimChi.PerformLayout();
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
        private System.Windows.Forms.GroupBox grboxTimChi;
        private System.Windows.Forms.Button btnGhiFile;
    }
}