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
using System.Xml.Linq;
using BLL;
using DTO;

namespace WindowsFormsApp1
{
    public partial class FormUsers : Form
    {
        UsersBLL us = new UsersBLL();
        QuyenBLL quyen = new QuyenBLL();
        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            List<TaiKhoan> lst = us.ReadCustomer();
            foreach (TaiKhoan tk in lst)
            {
                dtgvUser.Rows.Add(tk.sMaTK, tk.sTaiKhoan, tk.sMatKhau, tk.TenQuyen);
            }
            List<QuyenBEL> listArea = quyen.ReadQuyenList();
            foreach (QuyenBEL q in listArea)
            {
                cbArea.Items.Add(q);
            }
            cbArea.DisplayMember = "sTenQuyen";
            
        }

        //byte[] ConvertImageToBytes(Image image)
        //{
        //    using(MemoryStream ms = new MemoryStream())
        //    {
        //        image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
        //        return ms.ToArray();
        //    }
        //}
        //public Image ConvertByteToImage(byte[] data)
        //{
        //    using(MemoryStream ms = new MemoryStream(data))
        //    {
        //        return Image.FromStream(ms);
        //    }
        //}
        //private void btnUpLoad_Click(object sender, EventArgs e)
        //{
        //    using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg;*.png)|*.jpg|*.jpeg|*.png", Multiselect = false })
        //    {
        //        if (ofd.ShowDialog() == DialogResult.OK)
        //        {
        //            TaiKhoan tk = new TaiKhoan();
        //            pictureBox1.Image = Image.FromFile(ofd.FileName);
        //            txbFileName.Text = ofd.FileName;
                    
        //        }
        //    }
        //}

        private void dtgvUser_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow row = dtgvUser.Rows[idx];
            if (row.Cells[0].Value != null)
            {
                txbId.Text = row.Cells[0].Value.ToString();
                txbName.Text = row.Cells[1].Value.ToString();
                txbPass.Text = row.Cells[2].Value.ToString();
                cbArea.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();

            tk.sMaTK = int.Parse(txbId.Text);
            tk.sTaiKhoan = txbName.Text;
            tk.sMatKhau = txbPass.Text;
            tk.QuyenHan = (QuyenBEL)cbArea.SelectedItem;
            
            us.AddCustomer(tk);

            dtgvUser.Rows.Add(tk.sMaTK, tk.sTaiKhoan, tk.sMaTK, tk.QuyenHan.sTenQuyen);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtgvUser.CurrentRow;
            if (row != null)
            {
                TaiKhoan tk = new TaiKhoan();

                tk.sMaTK = int.Parse(txbId.Text);
                tk.sTaiKhoan = txbName.Text;
                tk.sMatKhau = txbPass.Text;
                tk.QuyenHan = (QuyenBEL)cbArea.SelectedItem;
                
                us.EditCustomer(tk);

                row.Cells[0].Value = tk.sMaTK;
                row.Cells[1].Value = tk.sTaiKhoan;
                row.Cells[2].Value = tk.sMatKhau;
                row.Cells[3].Value = tk.TenQuyen;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();

            tk.sMaTK = int.Parse(txbId.Text);
            tk.sTaiKhoan = txbName.Text;
            tk.sMatKhau = txbPass.Text;
            tk.QuyenHan = (QuyenBEL)cbArea.SelectedItem;

            if (dtgvUser.Rows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int idx = dtgvUser.CurrentCell.RowIndex;
                    us.DeleteCustomer(tk);
                    dtgvUser.Rows.RemoveAt(idx);
                }
            }
            else
            {
                MessageBox.Show("Không có hàng nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            //FormMain f = new FormMain();
            //f.Show();
            this.Hide();
            //f.LogOut += F_LogOut;
        }

        //private void F_LogOut(object sender, EventArgs e)
        //{
        //    (sender as FormMain).isExit = false;
        //    (sender as FormMain).Close();
        //    this.Show();
        //}

        private void btnUpLoad_Click(object sender, EventArgs e)
        {

        }
    }
}
