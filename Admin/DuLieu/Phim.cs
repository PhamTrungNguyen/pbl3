
using pbl3.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl3.DTO;

namespace pbl3.Admin.DuLieu
{
    public partial class Phim : UserControl
    {
        DataProvider data = new DataProvider();
        PhimDAO phimDAO = new PhimDAO();
        TheLoaiDAO theLoaiDAO = new TheLoaiDAO();
        public Phim()
        {
            InitializeComponent();
            string query = "select * from TheLoai"; // 
            foreach (DataRow i in data.ExecuteQuery(query).Rows)
            {
                cboTheLoai.Items.Add(new CBBTheLoai
                {
                    value = i["IDTheLoai"].ToString(),
                    text = i["TenTheLoai"].ToString()
                });
            }
        }

        void LoadMovie()
        {
            dgvMovie.DataSource = phimDAO.GetMovie();
        }
        private void btnPhimXem_Click(object sender, EventArgs e)
        {
            LoadMovie();
           
        }
        void InsertMovie(string id, string name, float length, DateTime startDate, DateTime endDate, string productor, string director, int year, string idTheLoai)
        {
            if (phimDAO.InsertMovie(id, name, length, startDate, endDate, productor, director, year, idTheLoai))
            {
                MessageBox.Show("Thêm phim thành công");
            }
            else
            {
                MessageBox.Show("Thêm phim thất bại");
            }
        }

        private void btnPhimThem_Click(object sender, EventArgs e)
        {   
            string MaPhim = txtPhimMa.Text;
            string TenPhim = txtPhimTen.Text;
            float ThoiLuongPhim = float.Parse(txtPhimThoiLuong.Text);
            DateTime NgayKCPhim = dtpPhimNgayKC.Value;
            DateTime NgayKTPhim = dtpPhimNgayKT.Value;
            string SanXuatPhim = txtPhimSanXuat.Text;
            string DaoDienPhim = txtPhimDaoDien.Text;
            int NamSXPhim = int.Parse(txtPhimNamSX.Text);
            string IDPhim = cboTheLoai.SelectedItem.ToString(); 
            InsertMovie(MaPhim, TenPhim, ThoiLuongPhim, NgayKCPhim, NgayKTPhim, SanXuatPhim, DaoDienPhim, NamSXPhim, IDPhim);
            LoadMovie();

        }

        void UpdateMovie(string id, string name, float length, DateTime startDate, DateTime endDate, string productor, string director, int year)
        {
            if (phimDAO.UpdateMovie(id, name, length, startDate, endDate, productor, director, year))
            {
                MessageBox.Show("Sửa phim thành công");
            }
            else
            {
                MessageBox.Show("Sửa phim thất bại");
            }
        }
        private void btnPhimSua_Click(object sender, EventArgs e)
        {
            string MaPhim = txtPhimMa.Text;
            string TenPhim = txtPhimTen.Text;
            float ThoiLuongPhim = float.Parse(txtPhimThoiLuong.Text);
            DateTime NgayKCPhim = dtpPhimNgayKC.Value;
            DateTime NgayKTPhim = dtpPhimNgayKT.Value;
            string SanXuatPhim = txtPhimSanXuat.Text;
            string DaoDienPhim = txtPhimDaoDien.Text;
            int NamSXPhim = Int32.Parse(txtPhimNamSX.Text);
            UpdateMovie(MaPhim, TenPhim, ThoiLuongPhim, NgayKCPhim, NgayKTPhim, SanXuatPhim, DaoDienPhim, NamSXPhim);
            LoadMovie();
        }



        private void dgvMovie_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvMovie.SelectedRows.Count == 1)
            {

                txtPhimMa.Text = dgvMovie.SelectedRows[0].Cells["Mã phim"].Value.ToString();
                txtPhimTen.Text = dgvMovie.SelectedRows[0].Cells["Tên phim"].Value.ToString();
                txtPhimThoiLuong.Text = dgvMovie.SelectedRows[0].Cells["Thời lượng"].Value.ToString();
                txtPhimNamSX.Text = dgvMovie.SelectedRows[0].Cells["Năm SX"].Value.ToString();
                dtpPhimNgayKC.Value = Convert.ToDateTime(dgvMovie.SelectedRows[0].Cells["Ngày khởi chiếu"].Value.ToString());
                dtpPhimNgayKT.Value = Convert.ToDateTime(dgvMovie.SelectedRows[0].Cells["Ngày kết thúc"].Value.ToString());
                txtPhimSanXuat.Text = dgvMovie.SelectedRows[0].Cells["Sản xuất"].Value.ToString();
                txtPhimDaoDien.Text = dgvMovie.SelectedRows[0].Cells["Đạo diễn"].Value.ToString();
                string id = dgvMovie.SelectedRows[0].Cells["TheLoai"].Value.ToString();
                foreach (CBBTheLoai r in cboTheLoai.Items)
                {
                    if (r.value == id)
                    {
                        cboTheLoai.SelectedItem = r;
                    }
                }
            }

        }
        private void btnPhimXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMovie.SelectedRows.Count == 1)
                {
                    DialogResult ret = MessageBox.Show("Bạn có muốn xóa sản phẩm này?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ret == DialogResult.Yes)
                    {
                        string maPhim = dgvMovie.SelectedRows[0].Cells["Mã phim"].Value.ToString();
                        string queryDel = "delete from Phim where IDPhim = '" + maPhim + "'";
                        data.ExecuteNonQuery(queryDel, null);
                        LoadMovie();
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

        private void txtPhimMa_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
