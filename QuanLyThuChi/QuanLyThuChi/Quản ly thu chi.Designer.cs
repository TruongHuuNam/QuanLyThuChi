
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPageKhoanThu = new System.Windows.Forms.TabPage();
            this.btnthoatThu = new System.Windows.Forms.Button();
            this.txtghichuthu = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this.btnTimTheoTen = new System.Windows.Forms.Button();
            this.tabPageKhoanThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanThu)).BeginInit();
            this.tabControlQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 407);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Thống kê";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPageKhoanThu
            // 
            this.tabPageKhoanThu.Controls.Add(this.btnTimTheoTen);
            this.tabPageKhoanThu.Controls.Add(this.btnthoatThu);
            this.tabPageKhoanThu.Controls.Add(this.txtghichuthu);
            this.tabPageKhoanThu.Controls.Add(this.textBox3);
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
            this.tabPageKhoanThu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageKhoanThu.Location = new System.Drawing.Point(4, 25);
            this.tabPageKhoanThu.Name = "tabPageKhoanThu";
            this.tabPageKhoanThu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKhoanThu.Size = new System.Drawing.Size(768, 407);
            this.tabPageKhoanThu.TabIndex = 0;
            this.tabPageKhoanThu.Text = "Khoản thu";
            this.tabPageKhoanThu.UseVisualStyleBackColor = true;
            // 
            // btnthoatThu
            // 
            this.btnthoatThu.Location = new System.Drawing.Point(636, 63);
            this.btnthoatThu.Name = "btnthoatThu";
            this.btnthoatThu.Size = new System.Drawing.Size(70, 43);
            this.btnthoatThu.TabIndex = 6;
            this.btnthoatThu.Text = "Thoát";
            this.btnthoatThu.UseVisualStyleBackColor = true;
            this.btnthoatThu.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtghichuthu
            // 
            this.txtghichuthu.Location = new System.Drawing.Point(132, 126);
            this.txtghichuthu.Name = "txtghichuthu";
            this.txtghichuthu.Size = new System.Drawing.Size(145, 22);
            this.txtghichuthu.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(430, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 22);
            this.textBox3.TabIndex = 5;
            // 
            // txtSotienThu
            // 
            this.txtSotienThu.Location = new System.Drawing.Point(132, 51);
            this.txtSotienThu.Name = "txtSotienThu";
            this.txtSotienThu.Size = new System.Drawing.Size(145, 22);
            this.txtSotienThu.TabIndex = 5;
            // 
            // cbxTenThu
            // 
            this.cbxTenThu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbxTenThu.FormattingEnabled = true;
            this.cbxTenThu.Items.AddRange(new object[] {
            "LƯƠNG",
            "THƯỞNG",
            "CHO THUÊ",
            "HOÀN TIỀN",
            "BÁN HÀNG",
            "CỔ TỨC"});
            this.cbxTenThu.Location = new System.Drawing.Point(132, 17);
            this.cbxTenThu.Name = "cbxTenThu";
            this.cbxTenThu.Size = new System.Drawing.Size(145, 24);
            this.cbxTenThu.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi chú";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thời gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Khoản Thu";
            // 
            // btnXoaThu
            // 
            this.btnXoaThu.Location = new System.Drawing.Point(302, 112);
            this.btnXoaThu.Name = "btnXoaThu";
            this.btnXoaThu.Size = new System.Drawing.Size(71, 42);
            this.btnXoaThu.TabIndex = 2;
            this.btnXoaThu.Text = "Xóa";
            this.btnXoaThu.UseVisualStyleBackColor = true;
            this.btnXoaThu.Click += new System.EventHandler(this.btnXoaThu_Click);
            // 
            // btnSuaThu
            // 
            this.btnSuaThu.Location = new System.Drawing.Point(302, 62);
            this.btnSuaThu.Name = "btnSuaThu";
            this.btnSuaThu.Size = new System.Drawing.Size(71, 43);
            this.btnSuaThu.TabIndex = 2;
            this.btnSuaThu.Text = "Sửa";
            this.btnSuaThu.UseVisualStyleBackColor = true;
            this.btnSuaThu.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThemThu
            // 
            this.btnThemThu.ForeColor = System.Drawing.Color.Indigo;
            this.btnThemThu.Image = global::QuanLyThuChi.Properties.Resources.tich_xanh_icon;
            this.btnThemThu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemThu.Location = new System.Drawing.Point(302, 17);
            this.btnThemThu.Name = "btnThemThu";
            this.btnThemThu.Size = new System.Drawing.Size(71, 40);
            this.btnThemThu.TabIndex = 2;
            this.btnThemThu.Text = "Thêm";
            this.btnThemThu.UseVisualStyleBackColor = true;
            this.btnThemThu.Click += new System.EventHandler(this.btnThemThu_Click);
            // 
            // datetimeNgayThu
            // 
            this.datetimeNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeNgayThu.Location = new System.Drawing.Point(132, 88);
            this.datetimeNgayThu.Name = "datetimeNgayThu";
            this.datetimeNgayThu.Size = new System.Drawing.Size(145, 22);
            this.datetimeNgayThu.TabIndex = 1;
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
            this.dgvKhoanThu.Location = new System.Drawing.Point(6, 180);
            this.dgvKhoanThu.Name = "dgvKhoanThu";
            this.dgvKhoanThu.RowHeadersWidth = 51;
            this.dgvKhoanThu.RowTemplate.Height = 24;
            this.dgvKhoanThu.Size = new System.Drawing.Size(745, 231);
            this.dgvKhoanThu.TabIndex = 0;
            this.dgvKhoanThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoanThu_CellClick);
            this.dgvKhoanThu.SelectionChanged += new System.EventHandler(this.dgvKhoanThu_SelectionChanged);
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
            this.tabControlQL.Location = new System.Drawing.Point(12, 2);
            this.tabControlQL.Name = "tabControlQL";
            this.tabControlQL.SelectedIndex = 0;
            this.tabControlQL.Size = new System.Drawing.Size(776, 436);
            this.tabControlQL.TabIndex = 0;
            // 
            // btnTimTheoTen
            // 
            this.btnTimTheoTen.Location = new System.Drawing.Point(645, 17);
            this.btnTimTheoTen.Name = "btnTimTheoTen";
            this.btnTimTheoTen.Size = new System.Drawing.Size(75, 23);
            this.btnTimTheoTen.TabIndex = 7;
            this.btnTimTheoTen.Text = "Tìm";
            this.btnTimTheoTen.UseVisualStyleBackColor = true;
            this.btnTimTheoTen.Click += new System.EventHandler(this.btnTimTheoTen_Click);
            // 
            // Quản_ly_thu_chi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlQL);
            this.Name = "Quản_ly_thu_chi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản_ly_thu_chi";
            this.Load += new System.EventHandler(this.Quản_ly_thu_chi_Load);
            this.tabPageKhoanThu.ResumeLayout(false);
            this.tabPageKhoanThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoanThu)).EndInit();
            this.tabControlQL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageKhoanThu;
        private System.Windows.Forms.TextBox txtghichuthu;
        private System.Windows.Forms.TextBox textBox3;
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
        private System.Windows.Forms.Button btnTimTheoTen;
    }
}