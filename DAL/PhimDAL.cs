using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pbl3.DTO;
using pbl3.DAL;
namespace pbl3.DAO
{
    public class PhimDAL
    {
        DataProvider data = new DataProvider();
        DinhDangPhimDAL dinhDangPhimDAL = new DinhDangPhimDAL();
        public  DataTable GetMovie()
        {
            string queryGet = "select Phim.IDPhim,Phim.TenPhim,Phim.ThoiLuong ,Phim.NgayKhoiChieu  ,Phim.NgayKetThuc ,Phim.SanXuat , Phim.DaoDien, Phim.NamSX, Phim.IDTheLoai ,TheLoai.TenTheLoai from Phim INNER JOIN TheLoai on Phim.IDTheLoai=TheLoai.IDTheLoai ";
            return data.ExecuteQuery(queryGet);
        }
        public  bool InsertMovie(string id, string name, float length, DateTime startDate, DateTime endDate, string productor, string director, int year ,string idTheLoai)
        {
            
            int result = data.ExecuteNonQuery("EXEC USP_InsertMovie @idPhim , @tenPhim  , @thoiLuong , @ngayKhoiChieu , @ngayKetThuc , @sanXuat , @daoDien , @namSX , @idTheLoai ", new object[] { id, name, length, startDate, endDate, productor, director, year, idTheLoai });
            return result > 0;
        }

        public  bool UpdateMovie(string id, string name, float length, DateTime startDate, DateTime endDate, string productor, string director, int year, string idTheLoai)
        {
            int result = data.ExecuteNonQuery("EXEC USP_UpdateMovie @id , @tenPhim   , @thoiLuong , @ngayKhoiChieu , @ngayKetThuc , @sanXuat , @daoDien , @namSX , @idTheLoai ", new object[] { id, name, length, startDate, endDate, productor, director, year, idTheLoai });
            return result > 0;
        }
        public string GetIDDinhDangPhim(string idPhim)
        {
            string idDinhDangPhim = "";
            foreach(DataRow i in dinhDangPhimDAL.GetDinhDangPhim().Rows)
            {
                if(i["Mã Phim"].ToString() == idPhim)
                {
                    idDinhDangPhim = i["Mã Định Dạng Phim"].ToString();
                }    
            }    
            return idDinhDangPhim;
        }
        public bool DelPhim(string id)
        {
            data.ExecuteNonQuery("DELETE from DinhDangPhim WHERE IDDinhDangPhim = '" + GetIDDinhDangPhim(id) + "'");
            string query = "delete from Phim where IDPhim = '" + id + "'";
            int result = data.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
