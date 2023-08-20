using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class QuyenDAL:DBConnection
    {
        public List<QuyenBEL> ReadQuyenList()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_Quyen", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<QuyenBEL> listArea = new List<QuyenBEL>();
            
            while (reader.Read())
            {
                QuyenBEL quyen = new QuyenBEL();
                quyen.iMaQuyen = int.Parse(reader["iMaQuyen"].ToString());
                quyen.sTenQuyen = reader["sTenQuyen"].ToString();
                listArea.Add(quyen);
            }
            conn.Close();
            return listArea;
        }
        public QuyenBEL ReadQuyen(int iMaQuyen)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_Quyen where iMaQuyen=" + iMaQuyen.ToString(), conn);
            SqlDataReader reader = cmd.ExecuteReader();
            QuyenBEL q = new QuyenBEL();
            if (reader.HasRows && reader.Read())
            {
                q.iMaQuyen = int.Parse(reader["iMaQuyen"].ToString());
                q.sTenQuyen = reader["sTenQuyen"].ToString();
            }
            conn.Close();
            return q;
        }
    }
}
