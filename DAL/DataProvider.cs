using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3.DAO
{
    public class DataProvider
    {
        private static string connectionSTR = "";//= "Data Source=THAITHANG-PC;Initial Catalog=QuanLyRapPhim;User ID=sa;pwd=thaithang1";
        public  bool ConnectionSQL(string s)
        {
            bool result = false;
            connectionSTR = s;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    result = true;
                    connection.Close();
                }
            }
            catch
            {
                return false;
            }            
            return result;
        }
        // xem dữ liệu bằng lệnh select
        public  DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            try
            {
                // kết thúc khối lệnh thì dữ liệu tự dc giải phóng
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    // thực thi câu truy vấn
                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    // lấy dữ liệu ra
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    // đẩy dữ liệu lên
                    adapter.Fill(data);

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return data;
        }

        // *ExecuteNonQuery có tác động có thay đổi có điều kiện ( add,del,update )
        // trả về số dòng thành công
        public int ExecuteNonQuery(string query, object[] paramater = null)
        {
            int data = 0;

            // kết thúc khối lệnh thì dữ liệu tự dc giải phóng
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery(); // hàm để add update del
                connection.Close();
            }

            return data;
            // hiển thị từng được tác động

        }

        // E1xecuteScalar : có tác động nhưng ko thay đổi
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            //số lượng trả về , dòng đầu tiên trong dataset
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }

    }
}
