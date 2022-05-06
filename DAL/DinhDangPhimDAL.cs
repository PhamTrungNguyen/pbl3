using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pbl3.DAO;
namespace pbl3.DAL
{
    public class DinhDangPhimDAL
    {
        DataProvider data = new DataProvider();
        public DataTable GetDinhDangPhim()
        {
            return data.ExecuteQuery("SELECT IDDinhDangPhim AS [Mã Định Dạng Phim], IDLoaiManHinh AS [Mã Loại Màn Hình],IDPhim AS [Mã Phim] FROM dbo.DinhDangPhim");
        }
        public bool SuaTheLoai(string idManHinh, string idPhim, string idDinhDang)
        {
            int result = data.ExecuteNonQuery("EXEC UpdateDinhDangPhim @idLoaiManHinh , @idPhim , @idDinhDang   ", new object[] { idManHinh, idPhim , idDinhDang });
            return result > 0;
        }
        public bool ThemDinhDang(string idDinhDang, string idPhim, string idLoaiManHinh)
        {
            int result = data.ExecuteNonQuery("EXEC USP_InsertFormatMovie @idDinhDang , @idPhim , @idLoaiManHinh", new object[] { idDinhDang, idPhim, idLoaiManHinh });
            return result > 0;
        }

    }
}
