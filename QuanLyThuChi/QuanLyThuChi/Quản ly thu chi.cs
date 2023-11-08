using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace QuanLyThuChi
{
    public partial class Quản_ly_thu_chi : Form
    {
        XuLyKhoanThu dmkhoanthu;
        private int vitrihientai = -1;

        public Quản_ly_thu_chi()
        {
            InitializeComponent();
        }

        private void datetimeNgayThu_ValueChanged(object sender, EventArgs e)
        {

        }
        public bool checkData()
        {
            if(string.IsNullOrWhiteSpace(cbxTenThu.Text))
            {
                MessageBox.Show("Bạn chưa chọn tên khoản thu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxTenThu.Focus();
                return false;
            }    
            if(string.IsNullOrWhiteSpace(txtSotienThu.Text))
            {
                MessageBox.Show("Bạn chưa nhập số tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSotienThu.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(datetimeNgayThu.Text))
            {
                MessageBox.Show("Bạn chưa chọn ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                datetimeNgayThu.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtghichuthu.Text))
            {
                MessageBox.Show("Bạn chưa nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtghichuthu.Focus();
                return false;
            }return true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //flag = "edit";
            if (vitrihientai >= 0)
            {
                DateTime datetimethu = Convert.ToDateTime(datetimeNgayThu.Text);
                dmkhoanthu.Dskhoanthu[vitrihientai].TenThu = cbxTenThu.Text;
                dmkhoanthu.Dskhoanthu[vitrihientai].Sotienthu = txtSotienThu.Text;
                dmkhoanthu.Dskhoanthu[vitrihientai].Thoigianthu = datetimethu;
                dmkhoanthu.Dskhoanthu[vitrihientai].Ghichuthu = txtghichuthu.Text;
                dgvKhoanThu.DataSource = dmkhoanthu.Dskhoanthu;
            }
        }

        private void Quản_ly_thu_chi_Load(object sender, EventArgs e)
        {
            dmkhoanthu = new XuLyKhoanThu();
            

            
        }
        private void hienthidanhsachkhoanthu(DataGridView dgv, List<KhoanThu> ds)
        {

            dgv.DataSource = ds;
        }

        private void btnThemThu_Click(object sender, EventArgs e)
        {

            if (checkData())
            {
                DateTime datetimethu = Convert.ToDateTime(datetimeNgayThu.Text);
                KhoanThu kt = new KhoanThu(cbxTenThu.Text, txtSotienThu.Text, datetimethu, txtghichuthu.Text);
                dmkhoanthu.themthu(kt);
                hienthidanhsachkhoanthu(dgvKhoanThu, dmkhoanthu.Dskhoanthu);
            }

        }

        private void dgvKhoanThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitrihientai = e.RowIndex;
            if (vitrihientai >= 0)
            {
                cbxTenThu.Text = dmkhoanthu.Dskhoanthu[vitrihientai].TenThu;
                txtSotienThu.Text = dmkhoanthu.Dskhoanthu[vitrihientai].Sotienthu;
                DateTime datetimethu = dmkhoanthu.Dskhoanthu[vitrihientai].Thoigianthu;
                txtghichuthu.Text = dmkhoanthu.Dskhoanthu[vitrihientai].Ghichuthu;
                hienthidanhsachkhoanthu(dgvKhoanThu, dmkhoanthu.Dskhoanthu);
            }

        }

        private void btnXoaThu_Click(object sender, EventArgs e)
        {
           
                if (MessageBox.Show("Bạn có muốn xóa mục này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                this.dmkhoanthu.xoathu(vitrihientai);
                hienthidanhsachkhoanthu(dgvKhoanThu, dmkhoanthu.Dskhoanthu); 
            }
        }
        

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void dgvKhoanThu_SelectionChanged(object sender, EventArgs e)
        {
          
        }

        private void btnTimTheoTen_Click(object sender, EventArgs e)
        {
            List<KhoanThu> dsketqua = new List<KhoanThu>();
            dsketqua = dmkhoanthu.TimTheoTen(cbxTenThu.Text);
            hienthidanhsachkhoanthu(dgvKhoanThu, dsketqua);
        }
    }
}
