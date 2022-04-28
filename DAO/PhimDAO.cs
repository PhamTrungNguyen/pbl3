using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3.DAO
{
    public class PhimDAO
    {
        DataProvider data = new DataProvider();
        public  DataTable GetMovie()
        {
            return data.ExecuteQuery("EXEC USP_GetMovie");
        }
        public  bool InsertMovie(string id, string name, float length, DateTime startDate, DateTime endDate, string productor, string director, int year ,string idTheLoai)
        {
            
            int result = data.ExecuteNonQuery("EXEC USP_InsertMovie @idPhim , @tenPhim  , @thoiLuong , @ngayKhoiChieu , @ngayKetThuc , @sanXuat , @daoDien , @namSX , @idTheLoai ", new object[] { id, name, length, startDate, endDate, productor, director, year, idTheLoai });
            return result > 0;
        }

        public  bool UpdateMovie(string id, string name, float length, DateTime startDate, DateTime endDate, string productor, string director, int year)
        {
            int result = data.ExecuteNonQuery("EXEC USP_UpdateMovie @id , @tenPhim   , @thoiLuong , @ngayKhoiChieu , @ngayKetThuc , @sanXuat , @daoDien , @namSX  ", new object[] { id, name, length, startDate, endDate, productor, director, year });
            return result > 0;
        }
    }
}
