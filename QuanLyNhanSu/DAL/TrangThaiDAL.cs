using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TrangThaiDAL:DBConnection
    {
        public List<TrangThaiBEL> ReadTTList()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tblTrangThai", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<TrangThaiBEL> listArea = new List<TrangThaiBEL>();

            while (reader.Read())
            {
                TrangThaiBEL tt = new TrangThaiBEL();
                tt.Id = int.Parse(reader["Id"].ToString());
                tt.TrangThai = reader["TrangThai"].ToString();
                listArea.Add(tt);
            }
            conn.Close();
            return listArea;
        }
        public TrangThaiBEL ReadTT(int Id)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tblTrangThai where Id=" + Id.ToString(), conn);
            SqlDataReader reader = cmd.ExecuteReader();
            TrangThaiBEL pb = new TrangThaiBEL();
            if (reader.HasRows && reader.Read())
            {
                pb.Id = int.Parse(reader["Id"].ToString());
                pb.TrangThai = reader["TrangThai"].ToString();
            }
            conn.Close();
            return pb;
        }
    }
}
