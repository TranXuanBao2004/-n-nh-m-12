using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang
    {
        private readonly DbQLThuocDataContext _db = new DbQLThuocDataContext();
        public List<KhachHang> GetAllKhachHang()
        {
            var khachhang = from i in this._db.KHACHHANGs
                            select new KhachHang(i.MaKH, i.TenKH, i.SDT, i.GioiTinh, i.NgaySinh, i.Diachi, i.Email);
            return khachhang.ToList();
        }
        public void ThemKhachHang(KhachHang khachhang)
        {

            try
            {
                KHACHHANG newKhachhang = new KHACHHANG
                {
                    MaKH = khachhang.MaKH,
                    TenKH = khachhang.TenKH,
                    SDT = khachhang.SDT,
                    GioiTinh = khachhang.GioiTinh,
                    NgaySinh = khachhang.NgaySinh,
                    Diachi = khachhang.Diachi,
                    Email = khachhang.Email
                };
                this._db.KHACHHANGs.InsertOnSubmit(newKhachhang);
            }
            catch (Exception ex)
            {
                throw new Exception("Không Thể Thêm :" + ex.Message.ToString());
            }
            finally
            {
                this._db.SubmitChanges();
            }
        }
        public void XoaKhachHang(string makh)
        {
            var xoa= from i in this._db.KHACHHANGs
                    where i.MaKH==makh
                    select i;
            foreach(var i in xoa)
            {
                this._db.KHACHHANGs.DeleteOnSubmit(i);
                this._db.SubmitChanges();
            }
        }
        public void CapNhatKhachHang(string makh,KhachHang khachhang)
        {
            var result = this._db.KHACHHANGs.FirstOrDefault(x=>x.MaKH==makh);
            result.TenKH = khachhang.TenKH;
            result.SDT = khachhang.SDT;
            result.GioiTinh = khachhang.GioiTinh;
            result.NgaySinh = khachhang.NgaySinh;
            result.Diachi = khachhang.Diachi;
            result.Email = khachhang.Email;
            this._db.SubmitChanges();

        }
       
    }
}
