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
    public partial class AddPhim : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        DataProvider data = new DataProvider();
        PhimDAL phimDAO = new PhimDAL();
        public AddPhim()
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

        private void lblMovieGenre_Click(object sender, EventArgs e)
        {

        }

        private void cboTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        private void btnOk_Click(object sender, EventArgs e)
        {
            string MaPhim = txtPhimMa.Text;
            string TenPhim = txtPhimTen.Text;
            float ThoiLuongPhim = float.Parse(txtPhimThoiLuong.Text);
            DateTime NgayKCPhim = dtpPhimNgayKC.Value;
            DateTime NgayKTPhim = dtpPhimNgayKT.Value;
            string SanXuatPhim = txtPhimSanXuat.Text;
            string DaoDienPhim = txtPhimDaoDien.Text;
            int NamSXPhim = int.Parse(txtPhimNamSX.Text);
            string id = ((CBBTheLoai)cboTheLoai.SelectedItem).value;
            string IDPhim = "";
            foreach (CBBTheLoai r in cboTheLoai.Items)
            {
                if (r.value == id)
                {
                    IDPhim = r.value;
                }
            }
            InsertMovie(MaPhim, TenPhim, ThoiLuongPhim, NgayKCPhim, NgayKTPhim, SanXuatPhim, DaoDienPhim, NamSXPhim, IDPhim);
            d();
            this.Close();
            
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
