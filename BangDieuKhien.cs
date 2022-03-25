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
    public partial class BangDieuKhien : Form
    {
        public BangDieuKhien()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnRest.Enabled = false;
            DoiMatKhau  doiMatKhau = new DoiMatKhau();
            this.Hide();
            doiMatKhau.ShowDialog();
            this.Show();
            btnRest.Enabled = true;
        }
    }
}
