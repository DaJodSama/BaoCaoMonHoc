using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DTO;

namespace DAL
{
    public class CustomerDAL:DBConnection
    {
        public List<CustomerBEL> ReadCustomer()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<CustomerBEL> list = new List<CustomerBEL>();
            while (reader.Read())
            {
                CustomerBEL cus = new CustomerBEL();
                cus.Id = int.Parse(reader["id"].ToString());
                cus.Name = reader["name"].ToString();
                list.Add(cus);
            }
            conn.Close();
            return list;
        }

        public void DeleteCustomer(CustomerBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from customer where id=@id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void NewCustomer(CustomerBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into customer values(@id,@name)", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.Name));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void EditCustomer(CustomerBEL cus)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("update customer set Name=@name where id =@id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", cus.Id));
            cmd.Parameters.Add(new SqlParameter("@name", cus.Name));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        

    }
}
