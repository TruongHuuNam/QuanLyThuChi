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
    public partial class Quản_lý_thu_chi : Form
    {
        
        XuLyKhoanChi dmkhoanchi;
        private int vitri = -1;
        private string tenFileText2 = "Dulieu2.txt";
        public Quản_lý_thu_chi()
        {
            InitializeComponent();
        }

        private void Quản_lý_thu_chi_Load(object sender, EventArgs e)
        {
            dmkhoanchi = new XuLyKhoanChi();
        }
        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(cbxTenChi.Text))
            {
                MessageBox.Show("Bạn chưa chọn tên khoản chi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxTenChi.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSotienChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập số tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSotienChi.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(datetimeNgayChi.Text))
            {
                MessageBox.Show("Bạn chưa chọn ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                datetimeNgayChi.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtghichuChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtghichuChi.Focus();
                return false;
            }
            return true;
        }

        private void btnThemChi_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                KhoanChi kc = new KhoanChi(cbxTenChi.Text, txtSotienChi.Text, datetimeNgayChi.Value, txtghichuChi.Text);
                this.dmkhoanchi.them(kc);
                hienthidanhsachkhoanchi(dgvKhoanChi, dmkhoanchi.Dskhoanchi);
            }
        }
        private void hienthidanhsachkhoanchi(DataGridView dgv, List<KhoanChi> ds)
        {
            dgv.DataSource = ds;
        }

        private void btnthoatChi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimChi_Click(object sender, EventArgs e)
        {
            List<KhoanChi> DSketqua = new List<KhoanChi>();
            DSketqua = dmkhoanchi.TimTheoTen(txtTimChi.Text);
            hienthidanhsachkhoanchi(dgvKhoanChi, DSketqua);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvKhoanChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            if (vitri >= 0)
            {
                cbxTenChi.Text = dmkhoanchi.Dskhoanchi[vitri].Tenchi;
                txtSotienChi.Text = dmkhoanchi.Dskhoanchi[vitri].Sotienchi;
                datetimeNgayChi.Value = dmkhoanchi.Dskhoanchi[vitri].Thoigianchi;
                txtghichuChi.Text = dmkhoanchi.Dskhoanchi[vitri].Ghichu;
                dgvKhoanChi.DataSource = dmkhoanchi.Dskhoanchi;
            }
        }

        private void btnSuaChi_Click(object sender, EventArgs e)
        {
            if (vitri >= 0)
            {
                dmkhoanchi.Dskhoanchi[vitri].Tenchi = cbxTenChi.Text;
                dmkhoanchi.Dskhoanchi[vitri].Sotienchi = txtSotienChi.Text;
                dmkhoanchi.Dskhoanchi[vitri].Thoigianchi = datetimeNgayChi.Value;
                dmkhoanchi.Dskhoanchi[vitri].Ghichu = txtghichuChi.Text;
                dgvKhoanChi.DataSource = dmkhoanchi.Dskhoanchi;
            }
        }

        private void btnXoaChi_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa mục này?","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                this.dmkhoanchi.xoachi(vitri);
                dgvKhoanChi.DataSource = dmkhoanchi.Dskhoanchi;
            }
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(tenFileText2, false, Encoding.UTF8);
                foreach(KhoanChi kc in dmkhoanchi.Dskhoanchi)
            {
                string row = kc.Tenchi + "\t" + kc.Sotienchi + "\t" + kc.Thoigianchi + "\t" + kc.Ghichu;
                sw.WriteLine(row);
            }
                sw.Close();
            MessageBox.Show("Đã ghi dữ liệu khoản chi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
