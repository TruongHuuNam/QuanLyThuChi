using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi
{
    class XuLyKhoanChi
    {
        private List<KhoanChi> dskhoanchi;

        public XuLyKhoanChi()
        {
            dskhoanchi = new List<KhoanChi>();
        }
        public List<KhoanChi> Dskhoanchi {
            get { return this.dskhoanchi; }
            set { this.dskhoanchi = value; }
          }
        public void them(KhoanChi kc)
        {
            this.dskhoanchi.Add(kc);
        }

    }
}
