using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class UserAccess:DBConnection
    {
        public string CheckLogin(TaiKhoan tk)
        {
            
            string user = null;
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_taikhoan where sTaiKhoan=@user and sMatKhau=@pass", conn);
            cmd.Parameters.Add(new SqlParameter("@user", tk.sTaiKhoan));
            cmd.Parameters.Add(new SqlParameter("@pass", tk.sMatKhau));
            SqlDataReader reader = cmd.ExecuteReader();

            //List<TaiKhoan> list = new List<TaiKhoan>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader[0].ToString();
                    return user;
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }
            return user;
        }
        
        public List<TaiKhoan> ReadCustomer()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_taikhoan", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<TaiKhoan> list = new List<TaiKhoan>();
            QuyenDAL qdal = new QuyenDAL();
            while (reader.Read())
            {
                TaiKhoan tk = new TaiKhoan();
                tk.sMaTK = int.Parse(reader["sMaTK"].ToString());
                tk.sTaiKhoan = reader["sTaiKhoan"].ToString();
                tk.sMatKhau = reader["sMatKhau"].ToString();
                tk.QuyenHan = qdal.ReadQuyen(int.Parse(reader["id_quyen"].ToString()));
                //tk.filename = reader["FileName"].ToString();
                
                list.Add(tk);
            }
            conn.Close();
            return list;
        }
        public void AddCustomer(TaiKhoan tk)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_taikhoan values(@id,@name,@password,@id_quyen)", conn);
            cmd.Parameters.Add(new SqlParameter("@id", tk.sMaTK));
            cmd.Parameters.Add(new SqlParameter("@name", tk.sTaiKhoan));
            cmd.Parameters.Add(new SqlParameter("@password", tk.sMatKhau));
            cmd.Parameters.Add(new SqlParameter("@id_quyen", tk.QuyenHan.iMaQuyen));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void EditCustomer(TaiKhoan tk)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update tbl_taikhoan set sTaiKhoan=@name, sMatKhau=@password, id_quyen=@id_quyen where sMaTK =@id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", tk.sMaTK));
            cmd.Parameters.Add(new SqlParameter("@name", tk.sTaiKhoan));
            cmd.Parameters.Add(new SqlParameter("@password", tk.sMatKhau));
            cmd.Parameters.Add(new SqlParameter("@id_quyen", tk.QuyenHan.iMaQuyen));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteCustomer(TaiKhoan tk)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from tbl_taikhoan where sMaTK=@id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", tk.sMaTK));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        
    }
}
