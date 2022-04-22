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

namespace pbl3.Admin.DuLieu
{
    public partial class Phim : UserControl
    {
        public Phim()
        {
            InitializeComponent();
        }
        MovieDAO movieDAO=new MovieDAO();
        private void lblMovieEndDate_Click(object sender, EventArgs e)
        {

        }

        private void txtPhimNgayKT_ValueChanged(object sender, EventArgs e)
        {

        }
        void LoadMovie()
        {
            dgvMovie.DataSource = movieDAO.GetMovie();
        }
        private void btnPhimXem_Click(object sender, EventArgs e)
        {
            LoadMovie();
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
            movieDAO.InsertMovie(MaPhim, TenPhim, ThoiLuongPhim, NgayKCPhim, NgayKTPhim, SanXuatPhim, DaoDienPhim, NamSXPhim);
            LoadMovie();
        }

        void UpdateMovie(string id, string name, float length, DateTime startDate, DateTime endDate, string productor, string director, int year)
        {
            if (movieDAO.UpdateMovie(id, name, length, startDate, endDate, productor, director, year))
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
            int NamSXPhim =Int32.Parse(txtPhimNamSX.Text);
            UpdateMovie(MaPhim, TenPhim, ThoiLuongPhim, NgayKCPhim, NgayKTPhim, SanXuatPhim, DaoDienPhim, NamSXPhim);
            LoadMovie();
        }

        private void dgvMovie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvMovie.Rows.Count == 1)
            //{

            //    txtPhimMa.Text = dgvMovie.SelectedRows[0].Cells["Mã phim"].Value.ToString();
            //}
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
            }
        }
        //void DeleteMovie(string id)
        //{
        //    if (MovieDAO.DeleteMovie(id))
        //    {
        //        MessageBox.Show("Xóa phim thành công");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Xóa phim thất bại");
        //    }
        //}
        private void btnPhimXoa_Click(object sender, EventArgs e)
        {

            //string movieID = txtMovieID.Text;
            //DeleteMovie(movieID);
            //LoadMovieList();
        }
    }
}
