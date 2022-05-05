using pbl3.BLL;
using pbl3.DAO;
using pbl3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3.Admin.DuLieu
{
    public partial class TheLoai : UserControl
    {
        TheLoaiBLL theLoaiBLL = new TheLoaiBLL();
        public TheLoai()
        {
            InitializeComponent();

        }
        void Reload()
        {
            dgvTheLoai.DataSource = theLoaiBLL.LoadTheLoai();
        }
        private void btnTheLoaiThem_Click(object sender, EventArgs e)
        {
            AddTheLoai addTheLoai = new AddTheLoai();
            addTheLoai.d = new AddTheLoai.Mydel(Reload);
            addTheLoai.Show();
        }

        private void btnTheLoaiThemXem_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void dgvTheLoai_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvTheLoai.SelectedRows.Count == 1)
            {
                txtTheLoaiMa.Enabled = false;
                txtTheLoaiMa.Text = dgvTheLoai.SelectedRows[0].Cells["Mã thể loại"].Value.ToString();
                txtTheLoaiTen.Text = dgvTheLoai.SelectedRows[0].Cells["Tên thể loại"].Value.ToString();
            }
        }
        private void btnTheLoaiSua_Click(object sender, EventArgs e)
        {
            string MaTheLoai = txtTheLoaiMa.Text;
            string TenTheLoai = txtTheLoaiTen.Text;
            theLoaiBLL.SuaTheLoai(MaTheLoai, TenTheLoai);
            Reload();
        }
        private void btnTheLoaiXoa_Click(object sender, EventArgs e)
        {
            if (dgvTheLoai.SelectedRows.Count == 1)
            {
                DialogResult ret = MessageBox.Show("Bạn có muốn xóa sản phẩm này?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    {
                        string maTheLoai = dgvTheLoai.SelectedRows[0].Cells["Mã thể loại"].Value.ToString();
                        theLoaiBLL.XoaTheLoai(maTheLoai);
                        Reload();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn để xóa");
            }
        }
    }
}
