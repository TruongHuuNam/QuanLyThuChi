
namespace QuanLyThuChi
{
    partial class Quản_ly_thu_chi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quản_ly_thu_chi));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPageKhoanThu = new System.Windows.Forms.TabPage();
            this.GB_TimKiem = new System.Windows.Forms.GroupBox();
            this.btn_TimTenThu = new System.Windows.Forms.Button();
            this.txt_timTenThu = new System.Windows.Forms.TextBox();
            this.btn_ghiFileText = new System.Windows.Forms.Button();
            this.btnthoatThu = new System.Windows.Forms.Button();
            this.txtghichuthu = new System.Windows.Forms.TextBox();
            this.txtSotienThu = new System.Windows.Forms.TextBox();
            this.cbxTenThu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoaThu = new System.Windows.Forms.Button();
            this.btnSuaThu = new System.Windows.Forms.Button();
            this.btnThemThu = new System.Windows.Forms.Button();
            this.datetimeNgayThu = new System.Windows.Forms.DateTimePicker();
            this.dgvKhoanThu = new System.Windows.Forms.DataGridView();
            this.dgvTenThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoTienThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvThoiGianThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGhiChuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlQL = new System.Windows.Forms.TabControl();
            this.tabPageKhoanThu.SuspendLayout();
            this.GB_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanThu)).BeginInit();
            this.tabControlQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(933, 404);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Thống kê";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPageKhoanThu
            // 
            this.tabPageKhoanThu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageKhoanThu.BackgroundImage")));
            this.tabPageKhoanThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageKhoanThu.Controls.Add(this.GB_TimKiem);
            this.tabPageKhoanThu.Controls.Add(this.btn_ghiFileText);
            this.tabPageKhoanThu.Controls.Add(this.btnthoatThu);
            this.tabPageKhoanThu.Controls.Add(this.txtghichuthu);
            this.tabPageKhoanThu.Controls.Add(this.txtSotienThu);
            this.tabPageKhoanThu.Controls.Add(this.cbxTenThu);
            this.tabPageKhoanThu.Controls.Add(this.label4);
            this.tabPageKhoanThu.Controls.Add(this.label1);
            this.tabPageKhoanThu.Controls.Add(this.label3);
            this.tabPageKhoanThu.Controls.Add(this.label2);
            this.tabPageKhoanThu.Controls.Add(this.btnXoaThu);
            this.tabPageKhoanThu.Controls.Add(this.btnSuaThu);
            this.tabPageKhoanThu.Controls.Add(this.btnThemThu);
            this.tabPageKhoanThu.Controls.Add(this.datetimeNgayThu);
            this.tabPageKhoanThu.Controls.Add(this.dgvKhoanThu);
            this.tabPageKhoanThu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageKhoanThu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageKhoanThu.Location = new System.Drawing.Point(4, 28);
            this.tabPageKhoanThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageKhoanThu.Name = "tabPageKhoanThu";
            this.tabPageKhoanThu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageKhoanThu.Size = new System.Drawing.Size(933, 404);
            this.tabPageKhoanThu.TabIndex = 0;
            this.tabPageKhoanThu.Text = "Khoản thu";
            this.tabPageKhoanThu.UseVisualStyleBackColor = true;
            // 
            // GB_TimKiem
            // 
            this.GB_TimKiem.Controls.Add(this.btn_TimTenThu);
            this.GB_TimKiem.Controls.Add(this.txt_timTenThu);
            this.GB_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_TimKiem.Location = new System.Drawing.Point(565, 21);
            this.GB_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.GB_TimKiem.Name = "GB_TimKiem";
            this.GB_TimKiem.Padding = new System.Windows.Forms.Padding(4);
            this.GB_TimKiem.Size = new System.Drawing.Size(353, 87);
            this.GB_TimKiem.TabIndex = 8;
            this.GB_TimKiem.TabStop = false;
            this.GB_TimKiem.Text = "Tìm thông tin khoản thu";
            // 
            // btn_TimTenThu
            // 
            this.btn_TimTenThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimTenThu.Location = new System.Drawing.Point(275, 31);
            this.btn_TimTenThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TimTenThu.Name = "btn_TimTenThu";
            this.btn_TimTenThu.Size = new System.Drawing.Size(72, 32);
            this.btn_TimTenThu.TabIndex = 9;
            this.btn_TimTenThu.Text = "Tìm ";
            this.btn_TimTenThu.UseVisualStyleBackColor = true;
            this.btn_TimTenThu.Click += new System.EventHandler(this.btn_TimTenThu_Click);
            // 
            // txt_timTenThu
            // 
            this.txt_timTenThu.Location = new System.Drawing.Point(17, 31);
            this.txt_timTenThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_timTenThu.Name = "txt_timTenThu";
            this.txt_timTenThu.Size = new System.Drawing.Size(241, 30);
            this.txt_timTenThu.TabIndex = 8;
            // 
            // btn_ghiFileText
            // 
            this.btn_ghiFileText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ghiFileText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ghiFileText.Image = global::QuanLyThuChi.Properties.Resources.tich_xanh_icon;
            this.btn_ghiFileText.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ghiFileText.Location = new System.Drawing.Point(664, 116);
            this.btn_ghiFileText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ghiFileText.Name = "btn_ghiFileText";
            this.btn_ghiFileText.Size = new System.Drawing.Size(109, 39);
            this.btn_ghiFileText.TabIndex = 10;
            this.btn_ghiFileText.Text = "Ghi file";
            this.btn_ghiFileText.UseVisualStyleBackColor = true;
            this.btn_ghiFileText.Click += new System.EventHandler(this.btn_ghiFileText_Click);
            // 
            // btnthoatThu
            // 
            this.btnthoatThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoatThu.Location = new System.Drawing.Point(793, 116);
            this.btnthoatThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthoatThu.Name = "btnthoatThu";
            this.btnthoatThu.Size = new System.Drawing.Size(89, 39);
            this.btnthoatThu.TabIndex = 11;
            this.btnthoatThu.Text = "Thoát";
            this.btnthoatThu.UseVisualStyleBackColor = true;
            this.btnthoatThu.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtghichuthu
            // 
            this.txtghichuthu.Location = new System.Drawing.Point(195, 133);
            this.txtghichuthu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtghichuthu.Name = "txtghichuthu";
            this.txtghichuthu.Size = new System.Drawing.Size(253, 27);
            this.txtghichuthu.TabIndex = 4;
            // 
            // txtSotienThu
            // 
            this.txtSotienThu.Location = new System.Drawing.Point(195, 60);
            this.txtSotienThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSotienThu.Name = "txtSotienThu";
            this.txtSotienThu.Size = new System.Drawing.Size(253, 27);
            this.txtSotienThu.TabIndex = 2;
            // 
            // cbxTenThu
            // 
            this.cbxTenThu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxTenThu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenThu.FormattingEnabled = true;
            this.cbxTenThu.Items.AddRange(new object[] {
            "LƯƠNG",
            "THƯỞNG",
            "CHO THUÊ",
            "HOÀN TIỀN",
            "BÁN HÀNG",
            "CỔ TỨC"});
            this.cbxTenThu.Location = new System.Drawing.Point(195, 25);
            this.cbxTenThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTenThu.Name = "cbxTenThu";
            this.cbxTenThu.Size = new System.Drawing.Size(253, 29);
            this.cbxTenThu.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi chú";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thời gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên khoản thu";
            // 
            // btnXoaThu
            // 
            this.btnXoaThu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThu.Location = new System.Drawing.Point(468, 119);
            this.btnXoaThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaThu.Name = "btnXoaThu";
            this.btnXoaThu.Size = new System.Drawing.Size(77, 42);
            this.btnXoaThu.TabIndex = 7;
            this.btnXoaThu.Text = "Xóa";
            this.btnXoaThu.UseVisualStyleBackColor = true;
            this.btnXoaThu.Click += new System.EventHandler(this.btnXoaThu_Click);
            // 
            // btnSuaThu
            // 
            this.btnSuaThu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaThu.Location = new System.Drawing.Point(468, 69);
            this.btnSuaThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaThu.Name = "btnSuaThu";
            this.btnSuaThu.Size = new System.Drawing.Size(77, 43);
            this.btnSuaThu.TabIndex = 6;
            this.btnSuaThu.Text = "Sửa";
            this.btnSuaThu.UseVisualStyleBackColor = true;
            this.btnSuaThu.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThemThu
            // 
            this.btnThemThu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemThu.Image = global::QuanLyThuChi.Properties.Resources.tich_xanh_icon;
            this.btnThemThu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemThu.Location = new System.Drawing.Point(468, 25);
            this.btnThemThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemThu.Name = "btnThemThu";
            this.btnThemThu.Size = new System.Drawing.Size(77, 39);
            this.btnThemThu.TabIndex = 5;
            this.btnThemThu.Text = "Thêm";
            this.btnThemThu.UseVisualStyleBackColor = true;
            this.btnThemThu.Click += new System.EventHandler(this.btnThemThu_Click);
            // 
            // datetimeNgayThu
            // 
            this.datetimeNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeNgayThu.Location = new System.Drawing.Point(195, 97);
            this.datetimeNgayThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datetimeNgayThu.Name = "datetimeNgayThu";
            this.datetimeNgayThu.Size = new System.Drawing.Size(253, 27);
            this.datetimeNgayThu.TabIndex = 3;
            this.datetimeNgayThu.ValueChanged += new System.EventHandler(this.datetimeNgayThu_ValueChanged);
            // 
            // dgvKhoanThu
            // 
            this.dgvKhoanThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoanThu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKhoanThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoanThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTenThu,
            this.dgvSoTienThu,
            this.dgvThoiGianThu,
            this.dgvGhiChuThu});
            this.dgvKhoanThu.Location = new System.Drawing.Point(25, 172);
            this.dgvKhoanThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKhoanThu.Name = "dgvKhoanThu";
            this.dgvKhoanThu.RowHeadersWidth = 51;
            this.dgvKhoanThu.RowTemplate.Height = 24;
            this.dgvKhoanThu.Size = new System.Drawing.Size(879, 231);
            this.dgvKhoanThu.TabIndex = 0;
            this.dgvKhoanThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoanThu_CellClick);
            // 
            // dgvTenThu
            // 
            this.dgvTenThu.DataPropertyName = "Tenthu";
            this.dgvTenThu.HeaderText = "Tên Khoản Thu";
            this.dgvTenThu.MinimumWidth = 6;
            this.dgvTenThu.Name = "dgvTenThu";
            // 
            // dgvSoTienThu
            // 
            this.dgvSoTienThu.DataPropertyName = "Sotienthu";
            this.dgvSoTienThu.HeaderText = "Số tiền";
            this.dgvSoTienThu.MinimumWidth = 6;
            this.dgvSoTienThu.Name = "dgvSoTienThu";
            // 
            // dgvThoiGianThu
            // 
            this.dgvThoiGianThu.DataPropertyName = "Thoigianthu";
            this.dgvThoiGianThu.HeaderText = "Thời gian";
            this.dgvThoiGianThu.MinimumWidth = 6;
            this.dgvThoiGianThu.Name = "dgvThoiGianThu";
            // 
            // dgvGhiChuThu
            // 
            this.dgvGhiChuThu.DataPropertyName = "Ghichuthu";
            this.dgvGhiChuThu.HeaderText = "Ghi chú";
            this.dgvGhiChuThu.MinimumWidth = 6;
            this.dgvGhiChuThu.Name = "dgvGhiChuThu";
            // 
            // tabControlQL
            // 
            this.tabControlQL.Controls.Add(this.tabPageKhoanThu);
            this.tabControlQL.Controls.Add(this.tabPage1);
            this.tabControlQL.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlQL.Location = new System.Drawing.Point(-1, 3);
            this.tabControlQL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlQL.Name = "tabControlQL";
            this.tabControlQL.SelectedIndex = 0;
            this.tabControlQL.Size = new System.Drawing.Size(941, 436);
            this.tabControlQL.TabIndex = 0;
            // 
            // Quản_ly_thu_chi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(937, 435);
            this.Controls.Add(this.tabControlQL);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Quản_ly_thu_chi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản_ly_thu_chi";
            this.Load += new System.EventHandler(this.Quản_ly_thu_chi_Load);
            this.tabPageKhoanThu.ResumeLayout(false);
            this.tabPageKhoanThu.PerformLayout();
            this.GB_TimKiem.ResumeLayout(false);
            this.GB_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanThu)).EndInit();
            this.tabControlQL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageKhoanThu;
        private System.Windows.Forms.TextBox txtghichuthu;
        private System.Windows.Forms.TextBox txt_timTenThu;
        private System.Windows.Forms.TextBox txtSotienThu;
        private System.Windows.Forms.ComboBox cbxTenThu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoaThu;
        private System.Windows.Forms.Button btnSuaThu;
        private System.Windows.Forms.Button btnThemThu;
        private System.Windows.Forms.DateTimePicker datetimeNgayThu;
        private System.Windows.Forms.DataGridView dgvKhoanThu;
        private System.Windows.Forms.TabControl tabControlQL;
        private System.Windows.Forms.Button btnthoatThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSoTienThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvThoiGianThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGhiChuThu;
        private System.Windows.Forms.GroupBox GB_TimKiem;
        private System.Windows.Forms.Button btn_ghiFileText;
        private System.Windows.Forms.Button btn_TimTenThu;
    }
}