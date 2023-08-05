using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cau20 : Form
    {
        string flag;
        DataTable dtSV;
        int index;
        public Cau20()
        {
            InitializeComponent();
        }
        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSV");
            dt.Columns.Add("TenSV");
            dt.Columns.Add("Diem");
            dt.Columns.Add("Lop");
            //dt.Columns.Add("Image");
            return dt;
        }
        public void LockControl()
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            //btnHuy.Enabled = false;
            //btnAnh.Enabled = false;

            txtMasv.ReadOnly = true;
            txtTenSV.ReadOnly = true;
            txtDiem.ReadOnly = true;
            txtLop.ReadOnly = true;

            btnThem.Focus();

        }
        public void UnlockControl()
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            //btnAnh.Enabled= false;
            btnLuu.Enabled = true;
            //btnHuy.Enabled = true;
            
            txtMasv.ReadOnly = false;
            txtTenSV.ReadOnly = false;
            txtDiem.ReadOnly = false;
            txtLop.ReadOnly = false;

            txtMasv.Focus();
        }

        private void Cau20_Load(object sender, EventArgs e)
        {
            LockControl();
            dtSV = createTable();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnlockControl();
            flag = "add";

            txtMasv.Text = "";
            txtTenSV.Text = "";
            txtDiem.Text = "";
            txtLop.Text = "";
            
            
            

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UnlockControl();
            flag = "edit";
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*.JpG; *.png; *.Gif)|*.JpG; *.png; *.Gif";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image=Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (checkData())
                {
                    dtSV.Rows.Add(txtMasv.Text, txtTenSV.Text, txtDiem.Text, txtLop.Text);

                    dataGridSinhVien.DataSource = dtSV;
                    dataGridSinhVien.RefreshEdit();
                    LockControl();
                }
                else
                {
                    UnlockControl();
                }
                
            }
            else if (flag == "edit")
            {
                if (checkData())
                {
                    dtSV.Rows[index][0] = txtMasv.Text;
                    dtSV.Rows[index][1] = txtTenSV.Text;
                    dtSV.Rows[index][2] = txtDiem.Text;
                    dtSV.Rows[index][3] = txtLop.Text;
                    dataGridSinhVien.DataSource = dtSV;
                    dataGridSinhVien.RefreshEdit();
                    LockControl();
                }
                else
                {
                    UnlockControl();
                }
                
            }
            
        }
        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(txtMasv.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasv.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiem.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLop.Text))
            {
                MessageBox.Show("Bạn chưa nhập lớp sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLop.Focus();
                return false;
            }
            return true;
        }

        private void dataGridSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            index = dataGridSinhVien.CurrentCell == null ? -1 : dataGridSinhVien.CurrentCell.RowIndex;
            DataTable dt = (DataTable)dataGridSinhVien.DataSource;
            if (index != -1)
            {
                txtMasv.Text = dataGridSinhVien.Rows[index].Cells[0].Value.ToString();
                txtTenSV.Text = dataGridSinhVien.Rows[index].Cells[1].Value.ToString();
                txtDiem.Text = dataGridSinhVien.Rows[index].Cells[2].Value.ToString();
                txtLop.Text = dataGridSinhVien.Rows[index].Cells[3].Value.ToString();
                //pictureBox1.Text = dataGridSinhVien.Rows[index].Cells[4].Value.ToString();
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtSV.Rows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    dtSV.Rows.RemoveAt(index);
                    dataGridSinhVien.DataSource = dtSV;
                    dataGridSinhVien.RefreshEdit();
                }
            }
            else
            {
                MessageBox.Show("Không có hàng nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Exit()
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DataGridViewImageColumn dtImg=new DataGridViewImageColumn();
            

        }
    }
}
