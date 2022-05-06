using pbl3.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3.BLL
{
    public class LichChieuBLL
    {
        LichChieuDAL lichchieu = new LichChieuDAL();
        public DataTable LoadLichChieu()
        {
            return lichchieu.GetLichChieu();
        }
    }
}
