using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL05:DBConnection
    {
        public List<CustomerBEL05> ReadCustomer05()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer05", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<CustomerBEL05> list = new List<CustomerBEL05>();
            AreaDAL are = new AreaDAL();
            while (reader.Read())
            {
                CustomerBEL05 cus = new CustomerBEL05();
                cus.Id = int.Parse(reader["id"].ToString());
                cus.Name = reader["name"].ToString();
                cus.Area = are.ReadArea(int.Parse(reader["id_area"].ToString()));
                list.Add(cus);
            }
            conn.Close();
            return list;
        }

        public void DeleteCustomer05(CustomerBEL05 cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from customer05 where id=@id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void NewCustomer05(CustomerBEL05 cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into customer05 values(@id,@name,@id_area)", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.Name));
            cmd.Parameters.Add(new SqlParameter("@id_area", cus.Area.Id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void EditCustomer05(CustomerBEL05 cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update customer05 set name=@name, id_area=@id_area where id =@id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.Name));
            cmd.Parameters.Add(new SqlParameter("@id_area", cus.Area.Id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
