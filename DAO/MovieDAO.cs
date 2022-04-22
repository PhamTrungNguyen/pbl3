using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3.DAO
{
    public class MovieDAO
    {
        DataProvider data = new DataProvider();
        public  DataTable GetMovie()
        {
            return data.ExecuteQuery("EXEC USP_GetMovie");
        }
        public  bool InsertMovie(string id, string name, float length, DateTime startDate, DateTime endDate, string productor, string director, int year)
        {
            
            int result = data.ExecuteNonQuery("EXEC USP_InsertMovie @id , @tenPhim  , @thoiLuong , @ngayKhoiChieu , @ngayKetThuc , @sanXuat , @daoDien , @namSX  ", new object[] { id, name, length, startDate, endDate, productor, director, year });
            return result > 0;
        }

        public  bool UpdateMovie(string id, string name, float length, DateTime startDate, DateTime endDate, string productor, string director, int year)
        {
            int result = data.ExecuteNonQuery("EXEC USP_UpdateMovie @id , @tenPhim   , @thoiLuong , @ngayKhoiChieu , @ngayKetThuc , @sanXuat , @daoDien , @namSX  ", new object[] { id, name, length, startDate, endDate, productor, director, year });
            return result > 0;
        }
        //public  bool DeleteMovie(string id)
        //{
        //    data.ExecuteNonQuery("DELETE dbo.PhanLoaiPhim WHERE idPhim = '" + id + "'");
        //    data.ExecuteNonQuery("DELETE dbo.DinhDangPhim WHERE idPhim = '" + id + "'");

        //    MovieByGenreDAO.DeleteMovie_GenreByMovieID(id);
        //    int result = data.ExecuteNonQuery("DELETE dbo.Phim WHERE id = '" + id + "'");
        //    return result > 0;
        //}


    }
}
