﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class KhachHang
    {
        public KhachHang(string tenKH, string sDT, string gioiTinh, DateTime? ngaySinh, string diachi, string email)
        {
            TenKH = tenKH;
            SDT = sDT;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Diachi = diachi;
            Email = email;
        }

        public KhachHang(string maKH, string tenKH, string sDT, string gioiTinh, DateTime? ngaySinh, string diachi, string email)
        {
            MaKH = maKH;
            TenKH = tenKH;
            SDT = sDT;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Diachi = diachi;
            Email = email;
        }

        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string GioiTinh { get; set; }
        public DateTime ?NgaySinh { get; set; }
        public string Diachi { get; set; }
        public string Email { get;set; }

    }
}
