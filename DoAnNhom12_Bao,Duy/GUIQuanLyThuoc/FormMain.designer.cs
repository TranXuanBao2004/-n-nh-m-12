namespace DoAn_Winform
{
    partial class frmQuanLyNhaThuoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNhaThuoc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNhapThuoc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnNSX = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnNhaPhanPhoi = new System.Windows.Forms.Button();
            this.btnKH = new System.Windows.Forms.Button();
            this.btnThuoc = new System.Windows.Forms.Button();
            this.btnBanThuoc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.contextMenuTaiKhoan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMain = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.contextMenuTaiKhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.btnNhapThuoc);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnNSX);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Controls.Add(this.btnNhaPhanPhoi);
            this.panel1.Controls.Add(this.btnKH);
            this.panel1.Controls.Add(this.btnThuoc);
            this.panel1.Controls.Add(this.btnBanThuoc);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 1208);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnNhapThuoc
            // 
            this.btnNhapThuoc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNhapThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNhapThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapThuoc.ForeColor = System.Drawing.Color.White;
            this.btnNhapThuoc.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapThuoc.Image")));
            this.btnNhapThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapThuoc.Location = new System.Drawing.Point(0, 767);
            this.btnNhapThuoc.Name = "btnNhapThuoc";
            this.btnNhapThuoc.Size = new System.Drawing.Size(193, 79);
            this.btnNhapThuoc.TabIndex = 11;
            this.btnNhapThuoc.Text = "Nhập thuốc";
            this.btnNhapThuoc.UseVisualStyleBackColor = false;
            this.btnNhapThuoc.Click += new System.EventHandler(this.btnNhapThuoc_Click_1);
            this.btnNhapThuoc.MouseLeave += new System.EventHandler(this.btnNhapThuoc_MouseLeave);
            this.btnNhapThuoc.MouseHover += new System.EventHandler(this.btnNhapThuoc_MouseHover);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(0, 886);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(193, 77);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnThoat.MouseLeave += new System.EventHandler(this.btnThoat_MouseLeave);
            this.btnThoat.MouseHover += new System.EventHandler(this.btnThoat_MouseHover);
            // 
            // btnNSX
            // 
            this.btnNSX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNSX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNSX.ForeColor = System.Drawing.Color.White;
            this.btnNSX.Image = ((System.Drawing.Image)(resources.GetObject("btnNSX.Image")));
            this.btnNSX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNSX.Location = new System.Drawing.Point(0, 647);
            this.btnNSX.Name = "btnNSX";
            this.btnNSX.Size = new System.Drawing.Size(193, 80);
            this.btnNSX.TabIndex = 10;
            this.btnNSX.Text = "Nhà sản xuất";
            this.btnNSX.UseVisualStyleBackColor = false;
            this.btnNSX.Click += new System.EventHandler(this.btnNSX_Click);
            this.btnNSX.MouseLeave += new System.EventHandler(this.btnNSX_MouseLeave);
            this.btnNSX.MouseHover += new System.EventHandler(this.btnNSX_MouseHover);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 525);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(193, 78);
            this.btnNhanVien.TabIndex = 8;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            this.btnNhanVien.MouseLeave += new System.EventHandler(this.btnNhanVien_MouseLeave);
            this.btnNhanVien.MouseHover += new System.EventHandler(this.btnNhanVien_MouseHover);
            // 
            // btnNhaPhanPhoi
            // 
            this.btnNhaPhanPhoi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNhaPhanPhoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNhaPhanPhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaPhanPhoi.ForeColor = System.Drawing.Color.White;
            this.btnNhaPhanPhoi.Image = ((System.Drawing.Image)(resources.GetObject("btnNhaPhanPhoi.Image")));
            this.btnNhaPhanPhoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhaPhanPhoi.Location = new System.Drawing.Point(0, 400);
            this.btnNhaPhanPhoi.Name = "btnNhaPhanPhoi";
            this.btnNhaPhanPhoi.Size = new System.Drawing.Size(193, 82);
            this.btnNhaPhanPhoi.TabIndex = 6;
            this.btnNhaPhanPhoi.Text = "Nhà phân phối";
            this.btnNhaPhanPhoi.UseVisualStyleBackColor = false;
            this.btnNhaPhanPhoi.Click += new System.EventHandler(this.btnNhaPhanPhoi_Click);
            this.btnNhaPhanPhoi.MouseLeave += new System.EventHandler(this.btnNhaCungCap_MouseLeave);
            this.btnNhaPhanPhoi.MouseHover += new System.EventHandler(this.btnNhaCungCap_MouseHover);
            // 
            // btnKH
            // 
            this.btnKH.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnKH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKH.ForeColor = System.Drawing.Color.White;
            this.btnKH.Image = ((System.Drawing.Image)(resources.GetObject("btnKH.Image")));
            this.btnKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKH.Location = new System.Drawing.Point(0, 287);
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(193, 71);
            this.btnKH.TabIndex = 5;
            this.btnKH.Text = "Khách hàng";
            this.btnKH.UseVisualStyleBackColor = false;
            this.btnKH.Click += new System.EventHandler(this.btnKH_Click);
            this.btnKH.MouseLeave += new System.EventHandler(this.btnKH_MouseLeave);
            this.btnKH.MouseHover += new System.EventHandler(this.btnKH_MouseHover);
            // 
            // btnThuoc
            // 
            this.btnThuoc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuoc.ForeColor = System.Drawing.Color.White;
            this.btnThuoc.Image = ((System.Drawing.Image)(resources.GetObject("btnThuoc.Image")));
            this.btnThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThuoc.Location = new System.Drawing.Point(0, 187);
            this.btnThuoc.Name = "btnThuoc";
            this.btnThuoc.Size = new System.Drawing.Size(193, 66);
            this.btnThuoc.TabIndex = 4;
            this.btnThuoc.Text = "Thuốc";
            this.btnThuoc.UseVisualStyleBackColor = false;
            this.btnThuoc.Click += new System.EventHandler(this.btnThuoc_Click);
            this.btnThuoc.MouseLeave += new System.EventHandler(this.btnThuoc_MouseLeave);
            this.btnThuoc.MouseHover += new System.EventHandler(this.btnThuoc_MouseHover);
            // 
            // btnBanThuoc
            // 
            this.btnBanThuoc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBanThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBanThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanThuoc.ForeColor = System.Drawing.Color.White;
            this.btnBanThuoc.Image = ((System.Drawing.Image)(resources.GetObject("btnBanThuoc.Image")));
            this.btnBanThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanThuoc.Location = new System.Drawing.Point(0, 89);
            this.btnBanThuoc.Name = "btnBanThuoc";
            this.btnBanThuoc.Size = new System.Drawing.Size(193, 59);
            this.btnBanThuoc.TabIndex = 3;
            this.btnBanThuoc.Text = "Bán thuốc";
            this.btnBanThuoc.UseVisualStyleBackColor = false;
            this.btnBanThuoc.Click += new System.EventHandler(this.btnBanThuoc_Click);
            this.btnBanThuoc.MouseEnter += new System.EventHandler(this.btnDanhMuc_MouseEnter);
            this.btnBanThuoc.MouseLeave += new System.EventHandler(this.btnDanhMuc_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.btnTaiKhoan);
            this.panel2.Controls.Add(this.lblMain);
            this.panel2.Location = new System.Drawing.Point(193, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2053, 83);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.btnTaiKhoan.ContextMenuStrip = this.contextMenuTaiKhoan;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.Image")));
            this.btnTaiKhoan.Location = new System.Drawing.Point(1823, 10);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(67, 63);
            this.btnTaiKhoan.TabIndex = 3;
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTaiKhoan_MouseClick);
            // 
            // contextMenuTaiKhoan
            // 
            this.contextMenuTaiKhoan.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuTaiKhoan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.đăngXuấtToolStripMenuItem});
            this.contextMenuTaiKhoan.Name = "contextMenuTaiKhoan";
            this.contextMenuTaiKhoan.Size = new System.Drawing.Size(178, 48);
            this.contextMenuTaiKhoan.Text = "Tài khoản";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.toolStripMenuItem1.Text = "Thông tin tài khoản";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // lblMain
            // 
            this.lblMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMain.AutoSize = true;
            this.lblMain.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.Black;
            this.lblMain.Location = new System.Drawing.Point(509, 15);
            this.lblMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(313, 39);
            this.lblMain.TabIndex = 2;
            this.lblMain.Text = "Quản lý nhà thuốc";
            this.lblMain.Click += new System.EventHandler(this.lblMain_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(193, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1092, 880);
            this.panel3.TabIndex = 13;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // frmQuanLyNhaThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 963);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmQuanLyNhaThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà thuốc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyNhaThuoc_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyNhaThuoc_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuTaiKhoan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBanThuoc;
        private System.Windows.Forms.Button btnKH;
        private System.Windows.Forms.Button btnThuoc;
        private System.Windows.Forms.Button btnNhaPhanPhoi;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.ContextMenuStrip contextMenuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Button btnNhapThuoc;
        private System.Windows.Forms.Button btnNSX;
        private System.Windows.Forms.Panel panel3;
    }
}

