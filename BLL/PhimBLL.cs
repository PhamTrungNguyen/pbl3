
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl3.Admin;
using pbl3.DAO;
using pbl3.DTO;

namespace pbl3.BLL
{
    public class PhimBLL
    {
        PhimDAL phimDAL = new PhimDAL();
        public DataTable LoadMovie()
        {
            return phimDAL.GetMovie();
        }
        public void UpdateMovie(string id, string name, float length, DateTime startDate, DateTime endDate, string productor, string director, int year, string idTheloai)
        {
            if (phimDAL.UpdateMovie(id, name, length, startDate, endDate, productor, director, year, idTheloai))
            {
                MessageBox.Show("Sửa phim thành công");
            }
            else
            {
                MessageBox.Show("Sửa phim thất bại");
            }
        }
        public void XoaPhim(string id)
        {
            if (phimDAL.DelPhim(id))
            {
                MessageBox.Show("Xóa phim thành công");
            }
            else
            {
                MessageBox.Show("Xóa phim thất bại");
            }
        }

    }
}
