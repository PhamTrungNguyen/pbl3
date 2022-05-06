using pbl3.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3.DAL
{
    public class PhongChieuDAL
    {
        DataProvider data = new DataProvider();
        public DataTable GetPhongChieu()
        {
            return data.ExecuteQuery("SELECT IDPhongChieu AS [Mã phòng chiếu], TenPhong AS [Tên phòng], IDManHinh AS[Mã màn hình], SoChoNgoi AS [Số chỗ ngồi], TinhTrang AS[Tình trạng], SoHangGhe AS [Số hàng ghế], SoGheMotHang AS [Số ghế một hàng] FROM dbo.PhongChieu");
        }
        public bool ThemPhongChieu(string id, string ten, string idmh, int scn, string tt, int shg, int sg1h)
        {
            int result = data.ExecuteNonQuery("EXEC USP_InsertPhongChieu @IDPhongChieu , @tenPhong , @idMH , @soChoNgoi , @tinhTrang , @soHangGhe , @soGheMotHang", new object[] { id, ten, idmh, scn, tt, shg, sg1h });
            return result > 0;
        }

        public bool UpdatePhongChieu(string id, string name, string idmh, int scn, string tt, int shg, int sg1h)
        {
            int result = data.ExecuteNonQuery("EXEC USP_UpdatePhongChieu @IDPhongChieu , @TenPhongChieu , @IDManHinh , @SoChoNgoi , @TinhTrang , @SoHangGhe , @SoGheMotHang  ", new object[] { id, name, idmh, scn, tt, shg, sg1h });
            return result > 0;
        }
        public bool DelPhongChieu(string id)
        {
            int result = data.ExecuteNonQuery("DELETE from PhongChieu where IDPhongChieu = '" + id + "'");
            return result > 0;

        }
    }
}
