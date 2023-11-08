using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi
{
    class KhoanChi
    {
        private string _tenchi;
        private string _sotienchi;
        private string _thoigianchi;
        private string _ghichu;

        public KhoanChi(string tenchi, string sotienchi, string thoigianchi, string ghichu)
        {
            _tenchi = tenchi;
            _sotienchi = sotienchi;
            _thoigianchi = thoigianchi;
            _ghichu = ghichu;
        }

        public string Tenchi { get => _tenchi; set => _tenchi = value; }
        public string Sotienchi { get => _sotienchi; set => _sotienchi = value; }
        public string Thoigianchi { get => _thoigianchi; set => _thoigianchi = value; }
        public string Ghichu { get => _ghichu; set => _ghichu = value; }
    }
}
