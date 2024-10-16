using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhanVien
    {
        private readonly DbQLThuocDataContext _db = new DbQLThuocDataContext();
        public List<NhanVien> GetAllNhanVien()
        {
            var listnv = from i in this._db.NHANVIENs
                         select new NhanVien(i.MaNV, i.TenNv, i.SDT, i.GioiTinh, i.NgaySinh, i.Diachi, i.Email, i.Luong, (float?)Convert.ToSingle(i.hsluong), i.maql);
            return listnv.ToList();
        }
    }
}
