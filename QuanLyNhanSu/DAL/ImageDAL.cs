using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ImageDAL:DBConnection
    {
        public void InsertImage(TaiKhoan tk)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Image,filename from tbl_taikhoan where sMaTK=@id)", conn);
            cmd.Parameters.Add(new SqlParameter("@id", tk.sMaTK));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
