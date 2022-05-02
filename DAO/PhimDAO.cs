using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pbl3.DTO;
namespace pbl3.DAO
{
    public class PhimDAO
    {
        DataProvider data = new DataProvider();
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

        public  bool UpdateMovie(string id, string name, float length, DateTime startDate, DateTime endDate, string productor, string director, int year)
        {
            int result = data.ExecuteNonQuery("EXEC USP_UpdateMovie @id , @tenPhim   , @thoiLuong , @ngayKhoiChieu , @ngayKetThuc , @sanXuat , @daoDien , @namSX  ", new object[] { id, name, length, startDate, endDate, productor, director, year });
            return result > 0;
        }
        public bool DelPhim(string id)
        {
            string query = "delete from Phim where IDPhim = '" + id + "'";
            int result = data.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<PhimDTO> GetAllPhim()
        {
            List<PhimDTO> list = new List<PhimDTO>();
            string query = "select * from  Phim";
            foreach (DataRow i in data.ExecuteQuery(query).Rows)
            {
                list.Add(GetPhimDataRow(i));
            }
            return list;
        }
        public PhimDTO GetPhimDataRow(DataRow i)
        {
            return new PhimDTO
            {
                idPhim = i["IDPhim"].ToString(),
                tenPhim = i["TenPhim"].ToString(),
                thoiLuong = Convert.ToInt32(i["ThoiLuong"].ToString()),
                ngayKC = Convert.ToDateTime(i["NgayKhoiChieu"].ToString()),
                ngayKT = Convert.ToDateTime(i["NgayKetThuc"].ToString()),
                sanXuat =i["SanXuat"].ToString(),
                namSanXuat = Convert.ToInt32(i["SanXuat"].ToString()),
                daoDien =i["DaoDien"].ToString(),
                idTheLoai = i["IDTheLoai"].ToString(),
            };
        }
    }
}
