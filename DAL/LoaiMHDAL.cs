using pbl3.DAL;
using pbl3.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3.DTO
{
    public class LoaiMHDAL
    {
        DataProvider data = new DataProvider();
        PhongChieuDAL phongchieuDAL = new PhongChieuDAL();
        public DataTable GetLoaiMH()
        {
            return data.ExecuteQuery("SELECT IDLoaiManHinh AS [Mã loại màn hình], TenManHinh AS [Tên màn hình] FROM dbo.LoaiManHinh");
        }
        public string getIDPhongChieu(string id)
        {
            string IDPhongChieu = "";
            foreach (DataRow i in phongchieuDAL.GetPhongChieu().Rows)
            {
                if (i["Mã màn hình"].ToString() == id)
                {
                    IDPhongChieu = i["Mã phòng chiếu"].ToString();
                    break;
                }
            }
            return IDPhongChieu;
        }
        public bool ThemLoaiMH(string id, string ten)
        {
            int result = data.ExecuteNonQuery("EXEC USP_InsertLoaiManHinh @IDLoaiMH , @TenLoaiMH", new object[] { id, ten });
            return result > 0;
        }

        public bool SuaLoaiMH(string id, string name)
        {
            int result = data.ExecuteNonQuery("EXEC USP_UpdateLoaiManHinh @id , @tenLoaiMH", new object[] { id, name });
            return result > 0;
        }
        public bool DelLoaiMH(string id)
        {
            data.ExecuteNonQuery("DELETE from PhongChieu WHERE IDPhongChieu = '" + getIDPhongChieu(id) + "'");
            int result = data.ExecuteNonQuery("DELETE from LoaiManHinh where IDLoaiManHinh = '" + id + "'");
            return result > 0;

        }
    }
}
