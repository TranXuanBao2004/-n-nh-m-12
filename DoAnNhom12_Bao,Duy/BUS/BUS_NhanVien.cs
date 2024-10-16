using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhanVien
    {
        private readonly DAL_NhanVien dAL_NhanVien = new DAL_NhanVien();
        public List<NhanVien> GetAllNhanVien()
        {
            return this.dAL_NhanVien.GetAllNhanVien();
        }
    }
}
