using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ADO01 : Form
    {
        public ADO01()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-H74STMF; Initial Catalog=sale; User Id=sa; Password=Thiendao322001";
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into customer values (5,'Nguyen Van M')";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-H74STMF; Initial Catalog=sale; User Id=sa; Password=Thiendao322001";
            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from customer where id = 2", conn);
            
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-H74STMF; Initial Catalog=sale; User Id=sa; Password=Thiendao322001";
            conn.Open();

            SqlCommand cmd = new SqlCommand("update customer set Name='Nguyen Van Thien Dao' where id = 5", conn);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-H74STMF; Initial Catalog=sale; User Id=sa; Password=Thiendao322001";
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    dgvCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                }
            }
            conn.Close();
        }
    }
}
