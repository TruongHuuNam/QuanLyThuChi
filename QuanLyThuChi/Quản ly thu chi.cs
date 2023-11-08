using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyThuChi
{
    [Serializable]
    public partial class Quản_ly_thu_chi : Form
    {
        XuLyKhoanThu dmkhoanthu;
        private int vitrihientai = -1;
        private string tenFileText = "Dulieu.txt";
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
            if (vitrihientai >= 0)
            {
                
                dmkhoanthu.Dskhoanthu[vitrihientai].TenThu = cbxTenThu.Text;
                dmkhoanthu.Dskhoanthu[vitrihientai].Sotienthu = txtSotienThu.Text;
                dmkhoanthu.Dskhoanthu[vitrihientai].Thoigianthu = datetimeNgayThu.Value;
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
                
                KhoanThu kt = new KhoanThu(cbxTenThu.Text, txtSotienThu.Text, datetimeNgayThu.Value, txtghichuthu.Text);
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
                datetimeNgayThu.Value = dmkhoanthu.Dskhoanthu[vitrihientai].Thoigianthu;
                txtghichuthu.Text = dmkhoanthu.Dskhoanthu[vitrihientai].Ghichuthu;
                hienthidanhsachkhoanthu(dgvKhoanThu, dmkhoanthu.Dskhoanthu);
            }

        }

        private void btnXoaThu_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa mục này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                this.dmkhoanthu.xoaThu(vitrihientai);
                dgvKhoanThu.DataSource = dmkhoanthu.Dskhoanthu;
            }
            
        }
        

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ghiFileText_Click(object sender, EventArgs e)
        {
            StreamWriter swt = new StreamWriter(tenFileText, false, Encoding.UTF8);
            foreach (KhoanThu kt in dmkhoanthu.Dskhoanthu)
            {
                string dong = kt.TenThu + "\t" + kt.Sotienthu + "\t" + kt.Thoigianthu + "\t " + kt.Ghichuthu;
                swt.WriteLine(dong);
            }
            swt.Close();
            MessageBox.Show("Đã ghi dữ liệu khoản thu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_TimTenThu_Click(object sender, EventArgs e)
        {
            
            List<KhoanThu> dsKetQua = new List<KhoanThu>();
            dsKetQua = dmkhoanthu.timTheoTen(txt_timTenThu.Text);
            hienthidanhsachkhoanthu(dgvKhoanThu, dsKetQua);
        }
    }
}
