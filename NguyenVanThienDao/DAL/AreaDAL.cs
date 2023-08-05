using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class AreaDAL:DBConnection
    {
        public List<AreaBEL> ReadAreaList()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from areas", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<AreaBEL> listArea=new List<AreaBEL>();
            while (reader.Read())
            {
                AreaBEL area = new AreaBEL();
                area.Id = int.Parse(reader["id"].ToString());
                area.Name = reader["name"].ToString();
                listArea.Add(area);
            }
            conn.Close();
            return listArea;
        }
        public AreaBEL ReadArea(int id)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from areas where id=" + id.ToString(), conn);
            SqlDataReader reader = cmd.ExecuteReader();
            AreaBEL area = new AreaBEL();
            if (reader.HasRows && reader.Read())
            {
                area.Id = int.Parse(reader["id"].ToString());   
                area.Name = reader["name"].ToString();
            }
            conn.Close();
            return area;
        }

    }
}
