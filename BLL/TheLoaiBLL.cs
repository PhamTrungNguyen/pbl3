using pbl3.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3.BLL
{
    public class TheLoaiBLL
    {
        TheLoaiDAL theLoaiDAL = new TheLoaiDAL();
        public DataTable LoadTheLoai()
        {
            return theLoaiDAL.GetTheLoai();
        }
        public void SuaTheLoai(string id, string name)
        {
            if (theLoaiDAL.SuaTheLoai(id, name))
            {
                MessageBox.Show("Sửa thể loại thành công");
            }
            else
            {
                MessageBox.Show("Sửa thể loại thất bại");
            }
        }
        public void XoaTheLoai(string id)
        {
            if (theLoaiDAL.DelTheLoai(id))
            {
                MessageBox.Show("Xóa thể loại thành công");
            }
            else
            {
                MessageBox.Show("Xóa thể loại thất bại");
            }
        }
    }
}
