using pbl3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3.BLL
{
    public class LoaiMHBLL
    {
        LoaiMHDAL loaiMHDAL = new LoaiMHDAL();
        public DataTable LoadLoaiMH()
        {
            return loaiMHDAL.GetLoaiMH();
        }
        public void UpdateLoaiMH(string id, string name)
        {
            if (loaiMHDAL.SuaLoaiMH(id, name))
            {
                MessageBox.Show("Sửa loại màn hình thành công");
            }
            else
            {
                MessageBox.Show("Sửa loại màn hình thất bại");
            }
        }
        public void XoaLoaiMH(string id)
        {
            if (loaiMHDAL.DelLoaiMH(id))
            {
                MessageBox.Show("Xóa loại màn hình thành công");
            }
            else
            {
                MessageBox.Show("Xóa loại màn hình thất bại");
            }
        }
    }
}
