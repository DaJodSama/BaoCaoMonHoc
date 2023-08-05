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
    public partial class ADO02 : Form
    {
        public ADO02()
        {
            InitializeComponent();
        }

        private void ADO02_Load(object sender, EventArgs e)
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
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-H74STMF; Initial Catalog=sale; User Id=sa; Password=Thiendao322001";
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int idx = e.RowIndex;
            if (reader.HasRows)
            {
                tbId.Text = dgvCustomer.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvCustomer.Rows[idx].Cells[1].Value.ToString();

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-H74STMF; Initial Catalog=sale; User Id=sa; Password=Thiendao322001";
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into customer values ("+tbId.Text+",'"+tbName.Text+"')";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();

            dgvCustomer.Rows.Add(tbId.Text, tbName.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-H74STMF; Initial Catalog=sale; User Id=sa; Password=Thiendao322001";
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update customer set Name='" + tbName.Text +"' where id =" + tbId.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();

            int idx=dgvCustomer.CurrentCell.RowIndex;
            dgvCustomer.Rows[idx].Cells[1].Value=tbName.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-H74STMF; Initial Catalog=sale; User Id=sa; Password=Thiendao322001";
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from customer where id =" + tbId.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();

            int idx=dgvCustomer.CurrentCell.RowIndex;
            dgvCustomer.Rows.RemoveAt(idx);
        }
    }
}
