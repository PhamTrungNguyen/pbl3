
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3.DAO
{
    public class TheLoaiDAO
    {
        DataProvider data = new DataProvider();
        public  DataTable GetTheLoai()
        {
            return data.ExecuteQuery("SELECT IDTheLoai AS [Mã thể loại], TenTheLoai AS [Tên thể loại], MoTa AS [Mô tả] FROM dbo.TheLoai");
        }
    }
}
