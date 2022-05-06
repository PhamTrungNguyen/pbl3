using pbl3.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3.BLL
{
    public class PhongChieuBLL
    {
        PhongChieuDAL phongchieuDAL = new PhongChieuDAL();
        public DataTable LoadPhongChieu()
        {
            return phongchieuDAL.GetPhongChieu();
        }
        public void UpdatePhongChieu(string id, string name, string idmh, int scn, string tt, int shg, int sg1h)
        {
            if (phongchieuDAL.UpdatePhongChieu(id, name, idmh, scn, tt, shg, sg1h))
            {
                MessageBox.Show("Sửa phòng chiếu thành công");
            }
            else
            {
                MessageBox.Show("Sửa phòng chiếu thất bại");
            }
        }
        public void XoaPhongChieu(string id)
        {
            if (phongchieuDAL.DelPhongChieu(id))
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
