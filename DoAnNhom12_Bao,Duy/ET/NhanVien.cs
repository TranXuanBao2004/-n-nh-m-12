using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class NhanVien
    {
       

        public NhanVien(string tenNv, string sDT, string gioiTinh, DateTime? ngaySinh, string diachi, string email, int? luong, float? hsluong, string maql)
        {
            TenNv = tenNv;
            SDT = sDT;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Diachi = diachi;
            Email = email;
            Luong = luong;
            this.hsluong = hsluong;
            this.maql = maql;
        }

        public NhanVien(string maNV, string tenNv, string sDT, string gioiTinh, DateTime? ngaySinh, string diachi, string email, int? luong, float? hsluong, string maql)
        {
            MaNV = maNV;
            TenNv = tenNv;
            SDT = sDT;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Diachi = diachi;
            Email = email;
            Luong = luong;
            this.hsluong = hsluong;
            this.maql = maql;
        }

        public string MaNV { get; set; }
        public string TenNv { get; set; }
        public string SDT { get; set; }
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string Diachi { get; set; }
        public string Email { get; set; }
        public int? Luong { get; set; }
        public float? hsluong { get; set; }
        public string maql {get;set;}
    }
}
