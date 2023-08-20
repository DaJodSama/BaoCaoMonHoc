using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GioiTinhDAL:DBConnection
    {
        public List<GioiTinhBEL> ReadGTList()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_GioiTinh", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<GioiTinhBEL> listArea = new List<GioiTinhBEL>();

            while (reader.Read())
            {
                GioiTinhBEL gt = new GioiTinhBEL();
                gt.Id = int.Parse(reader["Id"].ToString());
                gt.GioiTinh = reader["GioiTinh"].ToString();
                listArea.Add(gt);
            }
            conn.Close();
            return listArea;
        }
        public GioiTinhBEL ReadGT(int Id)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_GioiTinh where Id=" + Id.ToString(), conn);
            SqlDataReader reader = cmd.ExecuteReader();
            GioiTinhBEL gt = new GioiTinhBEL();
            if (reader.HasRows && reader.Read())
            {
                gt.Id = int.Parse(reader["Id"].ToString());
                gt.GioiTinh = reader["GioiTinh"].ToString();
            }
            conn.Close();
            return gt;
        }
    }
}
