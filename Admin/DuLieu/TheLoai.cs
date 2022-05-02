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
        DataProvider data = new DataProvider();
        TheLoaiDAO theLoaiDAO = new TheLoaiDAO();
        PhimDAO phimDAO = new PhimDAO();
        public TheLoai()
        {
            InitializeComponent();
           
        }
        void LoadTheLoai()
        {
            dgvTheLoai.DataSource = theLoaiDAO.GetTheLoai();
       
           
        }
        private void btnTheLoaiThem_Click(object sender, EventArgs e)
        {
            AddTheLoai addTheLoai = new AddTheLoai();
            addTheLoai.d = new AddTheLoai.Mydel(LoadTheLoai);
            addTheLoai.Show();
        }

        private void btnTheLoaiThemXem_Click(object sender, EventArgs e)
        {
            LoadTheLoai();
          
           
        }

        private void dgvTheLoai_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvTheLoai.SelectedRows.Count == 1)
            {
                txtTheLoaiMa.Enabled =false; 
                txtTheLoaiMa.Text = dgvTheLoai.SelectedRows[0].Cells["Mã thể loại"].Value.ToString();
                txtTheLoaiTen.Text = dgvTheLoai.SelectedRows[0].Cells["Tên thể loại"].Value.ToString();
            }
        }
        void SuaTheLoai(string id, string name)
        {
            if (theLoaiDAO.SuaTheLoai(id, name))
            {
                MessageBox.Show("Sửa thể loại thành công");
            }
            else
            {
                MessageBox.Show("Sửa thể loại thất bại");
            }
        }
        private void btnTheLoaiSua_Click(object sender, EventArgs e)
        {
            try
            {
           
            string MaTheLoai = txtTheLoaiMa.Text;
            string TenTheLoai = txtTheLoaiTen.Text;
            SuaTheLoai(MaTheLoai, TenTheLoai);
                LoadTheLoai();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void XoaTheLoai(string id)
        {
            if (theLoaiDAO.DelTheLoai(id))
            {
                MessageBox.Show("Xóa thể loại thành công");
            }
            else
            {
                MessageBox.Show("Xóa thể loại thất bại");
            }
        }
        private void btnTheLoaiXoa_Click(object sender, EventArgs e)
        {
            try
            { 
                if (dgvTheLoai.SelectedRows.Count == 1)
                {
                    DialogResult ret = MessageBox.Show("Bạn có muốn xóa sản phẩm này?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                     if (ret == DialogResult.Yes)
                    {
                        {
                            string maTheLoai = dgvTheLoai.SelectedRows[0].Cells["Mã thể loại"].Value.ToString();       
                            XoaTheLoai(maTheLoai);
                            LoadTheLoai();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn để xóa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
