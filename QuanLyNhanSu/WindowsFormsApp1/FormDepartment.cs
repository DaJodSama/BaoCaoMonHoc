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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class FormDepartment : Form
    {
        PhongBanBLL pbbll = new PhongBanBLL();

        public FormDepartment()
        {
            InitializeComponent();
        }
        private void FormDepartment_Load(object sender, EventArgs e)
        {
            List<PhongBan> lst = pbbll.ReadPB();
            foreach (PhongBan pb in lst)
            {
                dtgvDept.Rows.Add(pb.Id_PB,pb.Name_PB);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            PhongBan pb = new PhongBan();
            pb.Id_PB = int.Parse(txbId.Text);
            pb.Name_PB = txbInfo.Text;

            pbbll.AddPB(pb);

            dtgvDept.Rows.Add(pb.Id_PB, pb.Name_PB);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtgvDept.CurrentRow;
            if (row != null)
            {
                PhongBan pb = new PhongBan();

                pb.Id_PB = int.Parse(txbId.Text);
                pb.Name_PB = txbInfo.Text;

                pbbll.AddPB(pb);

                row.Cells[0].Value = pb.Id_PB;
                row.Cells[1].Value = pb.Name_PB;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            PhongBan pb = new PhongBan();

            pb.Id_PB = int.Parse(txbId.Text);
            pb.Name_PB = txbInfo.Text;

            if (dtgvDept.Rows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int idx = dtgvDept.CurrentCell.RowIndex;
                    pbbll.DeletePB(pb);
                    dtgvDept.Rows.RemoveAt(idx);
                }
            }
            else
            {
                MessageBox.Show("Không có hàng nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void dtgvDept_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow row = dtgvDept.Rows[idx];
            if (row.Cells[0].Value != null)
            {
                txbId.Text = row.Cells[0].Value.ToString();
                txbInfo.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
