using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuChi
{
    public partial class Quản_lý_thu_chi : Form
    {
        XuLyKhoanChi dmkhoanchi;
        public Quản_lý_thu_chi()
        {
            InitializeComponent();
        }

        private void Quản_lý_thu_chi_Load(object sender, EventArgs e)
        {
            dmkhoanchi = new XuLyKhoanChi();
        }

        private void btnThemChi_Click(object sender, EventArgs e)
        {
            KhoanChi kc = new KhoanChi(cbxTenChi.Text, txtSotienChi.Text, datetimeNgayChi.Text, txtghichuChi.Text);
            this.dmkhoanchi.them(kc);
            hienthidanhsachkhoanchi(dgvKhoanChi);
        }
        public void hienthidanhsachkhoanchi(DataGridView dgv)
        {
            //dgvKhoanChi.DataSource = null;
            dgv.DataSource = dmkhoanchi.Dskhoanchi;
        }
    }
}
