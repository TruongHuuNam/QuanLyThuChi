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
            get { return this.dskhoanchi.ToList(); }
            set { this.dskhoanchi = value; }
          }
        public void them(KhoanChi kc)
        {
            this.dskhoanchi.Add(kc);
        }
        public void xoachi(KhoanChi kt)
        {
            this.dskhoanchi.Remove(kt);
        }
        public void xoachi(int vitri)
        {
            this.dskhoanchi.RemoveAt(vitri); 
        }
        public List<KhoanChi> TimTheoTen(string tenKC)
        {
            List<KhoanChi> DSketqua=new List<KhoanChi>();
            foreach(KhoanChi kc in this.dskhoanchi)
            {
                if (kc.Tenchi.Equals(tenKC))
                    DSketqua.Add(kc);
            }
            return DSketqua;
        }
    }
}
