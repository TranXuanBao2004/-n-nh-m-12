using BUS;
using ET;
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
    public partial class UcKhachHang : UserControl
    {
        private readonly BUS_KhachHang bUS_KhachHang = new BUS_KhachHang();
        public UcKhachHang()
        {
            InitializeComponent();
            hienthikhachhang();
        }
        private void hienthikhachhang()
        {
            lvwDanhSachKH.Items.Clear();
            foreach (var item in bUS_KhachHang.GetAllKhachHang())
            {
                ListViewItem kh = lvwDanhSachKH.Items.Add(item.MaKH);
                kh.SubItems.Add(item.TenKH);
                kh.SubItems.Add(item.SDT);
                kh.SubItems.Add(item.GioiTinh);
                kh.SubItems.Add(item.NgaySinh.ToString());
                kh.SubItems.Add(item.Diachi);
                kh.SubItems.Add(item.Email);

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string gt = "";
            if (radNam.Checked == true)
            {
                gt = "Nam";
            }
            else
            {
                gt = "Nữ";
            }
            this.bUS_KhachHang.ThemKhachHang(new KhachHang(txtMaKH.Text, txtTenKH.Text, txtSDT.Text, gt, Convert.ToDateTime(txtNgaySinh.Text), txtDiaChi.Text, txtEmail.Text));
            MessageBox.Show("Thêm Thành Công");
            hienthikhachhang();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Xóa Khách Hàng Này Không", "Xóa Khách Hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.bUS_KhachHang.XoaKhachHang(txtMaKH.Text);
                MessageBox.Show("Xóa Khách Hàng Thành Công");
                hienthikhachhang();
                
            }
        }
        private void LoadForm()
        {
           
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtNgaySinh.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
            
        }

        private void lvwDanhSachKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDanhSachKH.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lvw in lvwDanhSachKH.SelectedItems)
                {
                    ListViewItem item = new ListViewItem();
                    txtMaKH.Text = lvw.SubItems[0].Text;
                    txtTenKH.Text = lvw.SubItems[1].Text;
                    txtSDT.Text = lvw.SubItems[2].Text;
                    string gioiTinh = lvw.SubItems[3].Text;

                    // Thiết lập trạng thái của RadioButton tương ứng
                    if (gioiTinh == "Nam")
                    {
                        radNam.Checked = true;

                    }
                    else if (gioiTinh == "Nữ")
                    {

                        radNu.Checked = true;
                    }
                    txtNgaySinh.Text = lvw.SubItems[4].Text;
                    txtDiaChi.Text = lvw.SubItems[5].Text;
                    txtEmail.Text = lvw.SubItems[6].Text;
                    btnThem.Enabled = false;
                    btnCapNhat.Enabled = true;
                    btnXoa.Enabled = true;

                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string gt = "";
            if (radNam.Checked == true)
            {
                gt = "Nam";
            }
            else
            {
                gt = "Nữ";
            }
            this.bUS_KhachHang.CapNhatKhachHang(txtMaKH.Text, new KhachHang(txtTenKH.Text, txtSDT.Text, gt, Convert.ToDateTime(txtNgaySinh.Text), txtDiaChi.Text, txtEmail.Text));
            MessageBox.Show("Cập Nhật Thành Công");
            hienthikhachhang();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Chắc Muốn Thoát Ứng Dụng Này Không", "Thoát Ứng Dụng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            { 
               this.Hide();
            }
        }
    }
}
