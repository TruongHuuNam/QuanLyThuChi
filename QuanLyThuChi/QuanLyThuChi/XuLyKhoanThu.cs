﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi
{
    class XuLyKhoanThu
    {
       
        private List<KhoanThu> dskhoanthu;
        
        public XuLyKhoanThu()
        {
            dskhoanthu = new List<KhoanThu>();
        }

        public List<KhoanThu> Dskhoanthu
        {
            get { return this.dskhoanthu.ToList(); }
            set { this.dskhoanthu = value; }
        }
       
        

        public void themthu(KhoanThu kt)
        {
            this.dskhoanthu.Add(kt);
        }
        public void xoathu(KhoanThu kt)
        {
            this.dskhoanthu.Remove(kt);
        }
        public void xoathu(int vitrihientai)
        {
            this.dskhoanthu.RemoveAt(vitrihientai);
        }
        public List<KhoanThu> TimTheoTen(string Tenthu)
        {
            List<KhoanThu> dsketqua = new List<KhoanThu>();
            foreach(KhoanThu kt in this.dskhoanthu)
            {
                if (kt.TenThu.Equals(Tenthu))
                    dsketqua.Add(kt);
            }
            return dsketqua;
        }
    }
}
