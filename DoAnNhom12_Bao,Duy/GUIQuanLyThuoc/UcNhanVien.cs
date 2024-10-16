using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIQuanLyThuoc
{
    public partial class UcNhanVien : UserControl
    {
        private readonly BUS_NhanVien bUS_NhanVien = new BUS_NhanVien();
        public UcNhanVien()
        {
            InitializeComponent();
            hienthinhanvien();
        }
        private void hienthinhanvien()
        {
            lvwDanhSachNV.Items.Clear();
            foreach (var item in bUS_NhanVien.GetAllNhanVien())
            {
                ListViewItem kh = lvwDanhSachNV.Items.Add(item.MaNV);
                kh.SubItems.Add(item.TenNv);
                kh.SubItems.Add(item.SDT);
                kh.SubItems.Add(item.GioiTinh);
                kh.SubItems.Add(item.NgaySinh.ToString());
                kh.SubItems.Add(item.Diachi);
                kh.SubItems.Add(item.Email);
                kh.SubItems.Add(item.Luong.ToString());
                kh.SubItems.Add(item.hsluong.ToString());
                kh.SubItems.Add(item.maql.ToString());
                
                

            }
        }
    }
}
