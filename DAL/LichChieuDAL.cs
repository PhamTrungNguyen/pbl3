using pbl3.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3.DAL
{
    public class LichChieuDAL
    {
        DataProvider data = new DataProvider();
        public DataTable GetLichChieu()
        {
            return data.ExecuteQuery("SELECT IDLichChieu AS [Mã lịch chiếu], ThoiGianChieu AS [Thời gian chiếu],IDPhong AS [Mã phòng], IDDinhDang AS[Mã định dạng], GiaVe AS [Giá vé], TrangThai AS [Trạng thái]  FROM dbo.LichChieu");
        }
    }
}
