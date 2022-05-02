
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl3.DAO;
using pbl3.DTO;
namespace pbl3.DAO
{
    public class TheLoaiDAO
    {
        PhimDAO phimDAO= new PhimDAO();
        DataProvider data = new DataProvider();
        public  DataTable GetTheLoai()
        {
            return data.ExecuteQuery("SELECT IDTheLoai AS [Mã thể loại], TenTheLoai AS [Tên thể loại] FROM dbo.TheLoai");
        }
        public string getIDPhim(string id)
        {
            string phimID = "";
            foreach (DataRow i in phimDAO.GetMovie().Rows)
            {

                if (i["IDTheLoai"].ToString() == id)
                {
                    phimID =i["IDPhim"].ToString();
                    break;
                }
            }
            return phimID;
        }
        public  bool DelTheLoai(string id)
        {     
            data.ExecuteNonQuery("DELETE from Phim WHERE IDPhim = '" + getIDPhim(id) + "'");
            int result = data.ExecuteNonQuery("DELETE dbo.TheLoai WHERE IDTheLoai = '" + id + "'");
            return result > 0;
        }
        public bool ThemTheLoai(string id, string ten)
        {
            int result = data.ExecuteNonQuery("EXEC USP_InsertTheLoai @idTheLoai , @tenTheloai", new object[] { id, ten });
            return result > 0;
        }
        public  bool SuaTheLoai(string id, string name)
        {
          
            int result = data.ExecuteNonQuery("EXEC UpdateTheloai @idtheloai , @tentheloai  ", new object[] { id, name });
            return result > 0;
        }
    }
}
