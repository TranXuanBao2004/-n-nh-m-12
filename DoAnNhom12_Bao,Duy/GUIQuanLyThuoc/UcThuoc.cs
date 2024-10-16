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
    public partial class UcThuoc : UserControl
    {
        public UcThuoc()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UcDvt dvt = new UcDvt();
            AddUserControl(dvt);
           
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UcNhomThuoc uc = new UcNhomThuoc();
            AddUserControl(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UcTimThuoc uc = new UcTimThuoc();
            AddUserControl(uc);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
