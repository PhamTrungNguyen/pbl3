using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl3.DAO;

namespace pbl3.Admin.DuLieu
{
    public partial class AddTheLoai : Form
    {
        public delegate void Mydel();
        public Mydel d;
        TheLoaiDAL theLoaiDao = new TheLoaiDAL();
        public AddTheLoai()
        {
            InitializeComponent();
        }

        private void btnTheLoaiOK_Click(object sender, EventArgs e)
        {
            string maTheLoai = txtTheLoaiMa.Text;
            string tenTheLoai = txtTheLoaiTen.Text;
            InsertTheLoai(maTheLoai, tenTheLoai);
            d();
            this.Close();
        }
        private void InsertTheLoai(string idTheLoai, string tenTheLoai)
        {
            if(theLoaiDao.ThemTheLoai(idTheLoai,tenTheLoai))
            {
                MessageBox.Show("Thêm thể loại thành công");
            }
            else
            {
                MessageBox.Show("Thêm thể loại thất bại");
            }    
        }
    }
}
