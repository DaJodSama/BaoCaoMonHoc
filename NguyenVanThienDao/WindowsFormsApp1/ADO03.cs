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
    public partial class ADO03 : Form
    {
        public ADO03()
        {
            InitializeComponent();
        }

        private void ADO03_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-H74STMF; Initial Catalog=sale; User Id=sa; Password=Thiendao322001";
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dgvCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                }
            }
            conn.Close();
        }

        private void dgvCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbId.Text = dgvCustomer.Rows[idx].Cells[0].Value.ToString();
            tbName.Text = dgvCustomer.Rows[idx].Cells[1].Value.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-H74STMF; Initial Catalog=sale; User Id=sa; Password=Thiendao322001";
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into customer values (@id,@name)";
            cmd.Connection = conn;
            cmd.Parameters.Add(new SqlParameter("@id", tbId.Text));
            cmd.Parameters.Add(new SqlParameter("@name", tbName.Text));
            cmd.ExecuteNonQuery();
            conn.Close();

            dgvCustomer.Rows.Add(tbId.Text, tbName.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-H74STMF; Initial Catalog=sale; User Id=sa; Password=Thiendao322001";
            conn.Open();
            SqlCommand cmd = new SqlCommand("update customer set Name=@name where id =@id",conn);
            cmd.Parameters.Add(new SqlParameter("@id", tbId.Text));
            cmd.Parameters.Add(new SqlParameter("@name", tbName.Text));
            cmd.ExecuteNonQuery();
            conn.Close();

            int idx = dgvCustomer.CurrentCell.RowIndex;
            dgvCustomer.Rows[idx].Cells[1].Value = tbName.Text;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-H74STMF; Initial Catalog=sale; User Id=sa; Password=Thiendao322001";
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from customer where id =@id",conn);
            cmd.Parameters.Add(new SqlParameter("@id", tbId.Text));
            cmd.ExecuteNonQuery();
            conn.Close();

            int idx = dgvCustomer.CurrentCell.RowIndex;
            dgvCustomer.Rows.RemoveAt(idx);
        }
    }
}
