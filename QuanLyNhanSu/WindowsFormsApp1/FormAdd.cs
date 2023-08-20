using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1
{
    public partial class FormAdd : Form
    {
        NhanVienBLL nvbll = new NhanVienBLL();
        PBBLL pb = new PBBLL();
        GTBLL gt = new GTBLL();
        TTBLL tt = new TTBLL();
        public FormAdd()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            
        }
        //public bool checkData()
        //{
        //    List<NhanVien> lst = nvbll.ReadNV();
        //    NhanVien nv = new NhanVien();

        //    string input1 = txbMNV.Text.Trim();
        //    string input2 = txbName.Text.Trim();
        //    string input3 = dtBirth.Text.Trim();
        //    string input4 = txbAddress.Text.Trim();
        //    string input5 = txbEmail.Text.Trim();
        //    string input6 = cbGender.Text.Trim();
        //    string input7 = txbVH.Text.Trim();
        //    string input8 = cbTT.Text.Trim();
        //    string input9 = txbSDT.Text.Trim();
        //    string input10 = cbPB.Text.Trim();

        //    if (string.IsNullOrWhiteSpace(input1))
        //    {
        //        MessageBox.Show("Bạn chưa nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txbMNV.Focus();
        //        return false;
        //    }
        //    if (txbMNV.Text.Any(c => !char.IsDigit(c)))
        //        {
        //            MessageBox.Show("Mã sinh viên chỉ được nhập số.");
        //            txbMNV.Focus();
        //            return false;
        //        }
        //    if (string.IsNullOrWhiteSpace(input2))
        //    {
        //        MessageBox.Show("Bạn chưa nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txbName.Focus();
        //        return false;
        //    }
        //    if (input2.Any(char.IsDigit))
        //    {
        //        MessageBox.Show("Tên nhân viên không được chứa số.");
        //        txbName.Focus();
        //        return false;
        //    }
        //    if (string.IsNullOrWhiteSpace(input3))
        //    {
        //        MessageBox.Show("Bạn chưa nhập ngày sinh nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        dtBirth.Focus();
        //        return false;
        //    }
        //    if (string.IsNullOrWhiteSpace(input4))
        //    {
        //        MessageBox.Show("Bạn chưa nhập địa chỉ nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txbAddress.Focus();
        //        return false;
        //    }
        //    if (string.IsNullOrWhiteSpace(input5))
        //    {
        //        MessageBox.Show("Bạn chưa nhập email nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txbEmail.Focus();
        //        return false;
        //    }
        //    if (string.IsNullOrWhiteSpace(input6))
        //    {
        //        MessageBox.Show("Bạn chưa chọn giới tính nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        cbGender.Focus();
        //        return false;
        //    }
        //    if (string.IsNullOrWhiteSpace(input9))
        //    {
        //        MessageBox.Show("Bạn chưa nhập số điện thoại nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txbSDT.Focus();
        //        return false;
        //    }
        //    if (!string.IsNullOrEmpty(input9))
        //    {
        //        if (txbSDT.Text.Any(c => !char.IsDigit(c)))
        //        {
        //            MessageBox.Show("Số điện thoại chỉ được nhập số.");
        //            txbSDT.Focus();
        //            return false;
        //        }
        //    }
        //    if (string.IsNullOrWhiteSpace(input7))
        //    {
        //        MessageBox.Show("Bạn chưa nhập văn hóa nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txbVH.Focus();
        //        return false;
        //    }
        //    if (string.IsNullOrWhiteSpace(input10))
        //    {
        //        MessageBox.Show("Bạn chưa chọn phòng ban nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        cbPB.Focus();
        //        return false;
        //    }
        //    if (string.IsNullOrWhiteSpace(input8))
        //    {
        //        MessageBox.Show("Bạn chưa tinh trạng nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        cbTT.Focus();
        //        return false;
        //    }

        //    return true;
        //}
    }
}
