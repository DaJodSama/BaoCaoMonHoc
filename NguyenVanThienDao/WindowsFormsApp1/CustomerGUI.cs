using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace WindowsFormsApp1
{
    public partial class CustomerGUI : Form
    {
        CustomerBLL cusBLL = new CustomerBLL();
        public CustomerGUI()
        {
            InitializeComponent();
        }

        private void CustomerGUI_Load(object sender, EventArgs e)
        {
            List<CustomerBEL> list = cusBLL.ReadCustomer();
            foreach (CustomerBEL cus in list)
            {
                dgvCustomer.Rows.Add(cus.Id, cus.Name);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CustomerBEL cus = new CustomerBEL();
            cus.Id = int.Parse(tbId.Text);
            cus.Name = tbName.Text;

            cusBLL.NewCustomer(cus);

            dgvCustomer.Rows.Add(cus.Id, cus.Name);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CustomerBEL cus = new CustomerBEL();
            cus.Id = int.Parse(tbId.Text);
            cus.Name = tbName.Text;

            cusBLL.DeleteCustomer(cus);

            int idx=dgvCustomer.CurrentCell.RowIndex;
            dgvCustomer.Rows.RemoveAt(idx);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CustomerBEL cus = new CustomerBEL();
            cus.Id = int.Parse(tbId.Text);
            cus.Name = tbName.Text;

            cusBLL.EditCustomer(cus);

            DataGridViewRow row = dgvCustomer.CurrentRow;
            row.Cells[0].Value = cus.Id;
            row.Cells[1].Value = cus.Name;
        }
    }
}
