using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ADO05 : Form
    {
        CustomerBLL05 cusBLL05 = new CustomerBLL05();
        AreaBAL areBAL = new AreaBAL();
        public ADO05()
        {
            InitializeComponent();
        }

        private void ADO05_Load(object sender, EventArgs e)
        {
            List<CustomerBEL05> list = cusBLL05.ReadCustomer05();
            foreach (CustomerBEL05 cus in list)
            {
                dgvCustomer.Rows.Add(cus.Id, cus.Name, cus.AreaName);
            }
            List<AreaBEL> listArea = areBAL.ReadAreaList();
            foreach(AreaBEL area in listArea)
            {
                cbArea.Items.Add(area);
            }
            cbArea.DisplayMember= "Name";
        }

        private void dgvCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow row = dgvCustomer.Rows[idx];
            if (row.Cells[0].Value != null)
            {
                tbId.Text = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                cbArea.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CustomerBEL05 cus = new CustomerBEL05();
            cus.Id = int.Parse(tbId.Text);
            cus.Name = tbId.Text;
            cus.Area=(AreaBEL)cbArea.SelectedItem;
            cus.Id=int.Parse(tbId.Text);
            cusBLL05.NewCustomer05(cus);

            dgvCustomer.Rows.Add(cus.Id, cus.Name, cus.Area.Name);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvCustomer.CurrentRow;
            if (row != null)
            {
                CustomerBEL05 cus=new CustomerBEL05();
                cus.Id = int.Parse(tbId.Text);
                cus.Name=tbName.Text;
                cus.Area = (AreaBEL)cbArea.SelectedItem;
                cusBLL05.NewCustomer05(cus);

                row.Cells[0].Value = cus.Id;
                row.Cells[1].Value = cus.Name;
                row.Cells[2].Value = cus.AreaName;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CustomerBEL05 cus = new CustomerBEL05();
            cus.Id= int.Parse(tbId.Text);
            cus.Name = tbName.Text;
            cus.Area= (AreaBEL)cbArea.SelectedItem;
            
            cusBLL05.DeleteCustomer05(cus);

            int idx = dgvCustomer.CurrentCell.RowIndex;
            dgvCustomer.Rows.RemoveAt(idx);
        }
    }
}
