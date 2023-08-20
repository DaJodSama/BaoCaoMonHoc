using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PBDAL:DBConnection
    {
        public List<PhongBanBEL> ReadPBList()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_PhongBan", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<PhongBanBEL> listArea = new List<PhongBanBEL>();

            while (reader.Read())
            {
                PhongBanBEL pb = new PhongBanBEL();
                pb.Id_PB = int.Parse(reader["Id_PB"].ToString());
                pb.Name_PB = reader["Name_PB"].ToString();
                listArea.Add(pb);
            }
            conn.Close();
            return listArea;
        }
        public PhongBanBEL ReadPB(int Id_PB)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_PhongBan where Id_PB=" + Id_PB.ToString(), conn);
            SqlDataReader reader = cmd.ExecuteReader();
            PhongBanBEL pb = new PhongBanBEL();
            if (reader.HasRows && reader.Read())
            {
                pb.Id_PB = int.Parse(reader["Id_PB"].ToString());
                pb.Name_PB = reader["Name_PB"].ToString();
            }
            conn.Close();
            return pb;
        }
    }
}
