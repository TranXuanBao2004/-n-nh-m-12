using GUIQuanLyThuoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Winform
{
    public partial class frmQuanLyNhaThuoc : Form
    {
       

        public frmQuanLyNhaThuoc()
        {
            InitializeComponent();         
        }   
        private void frmQuanLyNhaThuoc_Load(object sender, EventArgs e)
        {
           //urImage img = new urImage();
            //pnelUser.Controls.Clear();
            //pnelUser.Controls.Add(img);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhMuc_MouseEnter(object sender, EventArgs e)
        {
            btnBanThuoc.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnDanhMuc_MouseLeave(object sender, EventArgs e)
        {
            btnBanThuoc.BackColor = SystemColors.ControlDark;
        }

        private void btnThuoc_MouseHover(object sender, EventArgs e)
        {
            btnThuoc.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnThuoc_MouseLeave(object sender, EventArgs e)
        {
            btnThuoc.BackColor = SystemColors.ControlDark;
        }

        private void btnKH_MouseHover(object sender, EventArgs e)
        {
            btnKH.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnKH_MouseLeave(object sender, EventArgs e)
        {
            btnKH.BackColor = SystemColors.ControlDark;
        }

        private void btnNhaCungCap_MouseHover(object sender, EventArgs e)
        {
            btnNhaPhanPhoi.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnNhaCungCap_MouseLeave(object sender, EventArgs e)
        {
            btnNhaPhanPhoi.BackColor = SystemColors.ControlDark;
        }
   

        private void btnNhanVien_MouseHover(object sender, EventArgs e)
        {
            btnNhanVien.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnNhanVien_MouseLeave(object sender, EventArgs e)
        {
            btnNhanVien.BackColor = SystemColors.ControlDark;
        }

        private void btnThoat_MouseHover(object sender, EventArgs e)
        {
            btnThoat.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnThoat_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.BackColor = SystemColors.ControlDark;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string msg = "Tên đăng nhập: Admin \n Loại tài khoản: Quản trị viên";
            MessageBox.Show(msg, "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuTaiKhoan.Show(btnTaiKhoan, new Point(0, btnTaiKhoan.Height));
        }

        private void frmQuanLyNhaThuoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No)
            {
                e.Cancel = true;
            }          
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "Phần mềm quản lý nhà thuốc \n Phiên bản 1.0 \n Copyright © Nhóm ";
            MessageBox.Show(msg, "Thông tin phần mềm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThuoc_Click(object sender, EventArgs e)
        {
            UcThuoc ucThuoc = new UcThuoc();
            panel3.Controls.Clear();
            panel3.Controls.Add(ucThuoc);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            UcNhanVien nhanVien = new UcNhanVien();
            panel3.Controls.Clear();
            panel3.Controls.Add(nhanVien);
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            UcKhachHang uc = new UcKhachHang();
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }
               
        private void btnNSX_MouseHover(object sender, EventArgs e)
        {
            btnNSX.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnNhapThuoc_Click(object sender, EventArgs e)
        {
            btnNhapThuoc.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnNSX_MouseLeave(object sender, EventArgs e)
        {
            btnNSX.BackColor = SystemColors.ControlDark;
        }

        private void btnNhapThuoc_MouseHover(object sender, EventArgs e)
        {
            btnNhapThuoc.BackColor = SystemColors.ControlDarkDark;
        }

        private void btnNhapThuoc_MouseLeave(object sender, EventArgs e)
        {
            btnNhapThuoc.BackColor = SystemColors.ControlDark;
        }

        private void btnNhapThuoc_Click_1(object sender, EventArgs e)
        {
            UcNhapThuoc nt = new UcNhapThuoc();
            panel3.Controls.Clear();
            panel3.Controls.Add(nt);
        }

        private void btnNhaPhanPhoi_Click(object sender, EventArgs e)
        {
            UcNhaPhanPhoi npp = new UcNhaPhanPhoi();
            panel3.Controls.Clear();
            panel3.Controls.Add(npp);
        }

        private void btnNSX_Click(object sender, EventArgs e)
        {
            UcNhaSanXuat nsx = new UcNhaSanXuat();
            panel3.Controls.Clear();
            panel3.Controls.Add(nsx);
        }

        private void pnelUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBanThuoc_Click(object sender, EventArgs e)
        {
            UcBanThuoc nt = new UcBanThuoc();
            panel3.Controls.Clear();
            panel3.Controls.Add(nt);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMain_Click(object sender, EventArgs e)
        {

        }
    }
}
