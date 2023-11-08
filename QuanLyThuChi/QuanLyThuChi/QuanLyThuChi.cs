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
    public partial class QuanLyThuChi : Form
    {
        public QuanLyThuChi()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void khoảnThuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thông_tin_cá_nhân t = new Thông_tin_cá_nhân();
            t.ShowDialog();
        }

        private void quảnLýThuChiCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quản_ly_thu_chi q = new Quản_ly_thu_chi();
            q.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuất không?","Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK) {
                this.Close();
            }
            
        }

        private void quảnLýChiTiêuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quản_lý_thu_chi qly = new Quản_lý_thu_chi();
            this.Hide();
            qly.ShowDialog();
            this.Show();
        }
    }
}
