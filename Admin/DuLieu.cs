using pbl3.Admin.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pbl3
{
    public partial class DuLieu : UserControl
    {
        public DuLieu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPhim_Click(object sender, EventArgs e)
        {

        }

        private void btnLoaiManHinh_Click(object sender, EventArgs e)
        {
            this.Text = "Loại Màn Hình";
            pbDuLieu.Controls.Clear();
            LoaiManHinh duLieu = new LoaiManHinh();
            duLieu.Dock = DockStyle.Fill;
            pbDuLieu.Controls.Add(duLieu);
        }

        private void btnPhongChieu_Click(object sender, EventArgs e)
        {
            this.Text = "Phòng Chiếu";
            pbDuLieu.Controls.Clear();
            PhongChieu duLieu = new PhongChieu();
            duLieu.Dock = DockStyle.Fill;
            pbDuLieu.Controls.Add(duLieu);
        }
    }
}
