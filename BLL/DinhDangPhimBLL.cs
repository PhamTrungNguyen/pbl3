using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl3.DAL;
namespace pbl3.BLL
{
    public class DinhDangPhimBLL
    {
        DinhDangPhimDAL dinhDangPhimDAL = new DinhDangPhimDAL();
        public DataTable LoadDinhDangPhim()
        {
            return dinhDangPhimDAL.GetDinhDangPhim();
        }
        public void UpdateDinhDangPhim(string idManHinh, string idPhim, string idDinhDang)
        {
            if (dinhDangPhimDAL.SuaTheLoai(idManHinh, idPhim, idDinhDang))
            {
                MessageBox.Show("Sửa định dạng phim thành công");
            }
            else
            {
                MessageBox.Show("Sửa định dạng phim thất bại");
            }
        }
    }
}
