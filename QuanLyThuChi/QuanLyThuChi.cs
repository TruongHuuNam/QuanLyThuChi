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
            
            Application.Exit();
            
        }

        private void quảnLýChiTiêuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quản_lý_thu_chi qly = new Quản_lý_thu_chi();
            this.Hide();
            qly.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
