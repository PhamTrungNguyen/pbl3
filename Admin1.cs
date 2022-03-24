using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3
{
    public partial class Admin1 : Form
    {
        public Admin1()
        {
            InitializeComponent();
        }

        private void btnDuLieu_Click(object sender, EventArgs e)
        {
            this.Text = "Dữ Liệu";
            pnAdmin.Controls.Clear();
            DuLieu duLieu = new DuLieu();
            duLieu.Dock = DockStyle.Fill;
            pnAdmin.Controls.Add(duLieu);
        }

        private void btnDuLieu_MouseClick(object sender, MouseEventArgs e)
        {
            btnNhanVien.BackColor = Color.Aqua;
            btnKhachHang.BackColor = Color.Aqua;
            btnDanhThu.BackColor = Color.Aqua;
            btnTaiKhoan.BackColor = Color.Aqua;

            btnDuLieu.BackColor = Color.Red;
        }

        private void btnDanhThu_MouseClick(object sender, MouseEventArgs e)
        {
            btnNhanVien.BackColor = Color.Aqua;
            btnKhachHang.BackColor = Color.Aqua;
            btnDuLieu.BackColor = Color.Aqua;
            btnTaiKhoan.BackColor = Color.Aqua;

            btnDanhThu.BackColor = Color.Red;
        }

        private void btnNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            btnDuLieu.BackColor = Color.Aqua;
            btnKhachHang.BackColor = Color.Aqua;
            btnDanhThu.BackColor = Color.Aqua;
            btnTaiKhoan.BackColor = Color.Aqua;

            btnNhanVien.BackColor = Color.Red;
        }

        private void btnKhachHang_MouseClick(object sender, MouseEventArgs e)
        {
            btnDuLieu.BackColor = Color.Aqua;
            btnNhanVien.BackColor = Color.Aqua;
            btnDanhThu.BackColor = Color.Aqua;
            btnTaiKhoan.BackColor = Color.Aqua;

            btnKhachHang.BackColor = Color.Red;
        }

        private void btnTaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            btnDuLieu.BackColor = Color.Aqua;
            btnKhachHang.BackColor = Color.Aqua;
            btnDanhThu.BackColor = Color.Aqua;
            btnKhachHang.BackColor = Color.Aqua;

            btnTaiKhoan.BackColor = Color.Red;
        }
    }
}
