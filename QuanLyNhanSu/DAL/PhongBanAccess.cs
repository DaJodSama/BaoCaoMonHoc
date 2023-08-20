using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhongBanAccess:DBConnection
    {
        public List<PhongBan> ReadPB()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_PhongBan", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<PhongBan> list = new List<PhongBan>();
            
            while (reader.Read())
            {
                PhongBan tk = new PhongBan();
                tk.Id_PB = int.Parse(reader["Id_PB"].ToString());
                tk.Name_PB = reader["Name_PB"].ToString();

                list.Add(tk);
            }
            conn.Close();
            return list;
        }
        public void AddPB(PhongBan pb)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_PhongBan values(@id,@name)", conn);
            cmd.Parameters.Add(new SqlParameter("@id", pb.Id_PB));
            cmd.Parameters.Add(new SqlParameter("@name", pb.Name_PB));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void EditPB(PhongBan pb)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update tbl_PhongBan set Name_PB=@name where Id_PB =@id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", pb.Id_PB));
            cmd.Parameters.Add(new SqlParameter("@name", pb.Name_PB));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeletePB(PhongBan pb)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from tbl_PhongBan where Id_PB=@id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", pb.Id_PB));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
