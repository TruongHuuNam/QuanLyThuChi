using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi
{
    class KhoanThu
    {
        private string _tenThu;
        private string _sotienthu;
        private DateTime _thoigianthu;
        private string _ghichuthu;
     

        public KhoanThu(string tenThu, string sotienthu, DateTime thoigianthu, string ghichu)
        {
            _tenThu = tenThu;
            _sotienthu = sotienthu;
            _thoigianthu = thoigianthu;
            _ghichuthu = ghichu;
        }

        public string TenThu { get => _tenThu; set => _tenThu = value; }
        public string Sotienthu { get => _sotienthu; set => _sotienthu = value; }
        public DateTime Thoigianthu { get => _thoigianthu; set => _thoigianthu = value; }
        public string Ghichuthu { get => _ghichuthu; set => _ghichuthu = value; }
    }
}
