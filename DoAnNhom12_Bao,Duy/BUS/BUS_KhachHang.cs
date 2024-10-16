using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhachHang
    {
        private readonly DAL_KhachHang _dalKhachHang = new DAL_KhachHang();
        public List<KhachHang> GetAllKhachHang()
        {
            return this._dalKhachHang.GetAllKhachHang();
        }
        public void ThemKhachHang(KhachHang newKhachHang)
        {
            this._dalKhachHang.ThemKhachHang(newKhachHang);
        }
        public void XoaKhachHang(string maKhachhang)
        {
            this._dalKhachHang.XoaKhachHang(maKhachhang);

        }
        public void CapNhatKhachHang(string makhachhang,KhachHang updatekh)
        {
            this._dalKhachHang.CapNhatKhachHang(makhachhang,updatekh);
        }
    }
}
