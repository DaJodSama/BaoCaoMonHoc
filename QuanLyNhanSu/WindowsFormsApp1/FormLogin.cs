using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        TaiKhoan taikhoan = new TaiKhoan();
        UserMainBLL tkBLL = new UserMainBLL();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            taikhoan.sTaiKhoan = txbUserName.Text;
            taikhoan.sMatKhau = txbPassword.Text;

            string getuser = tkBLL.CheckLogin(taikhoan);

            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống");
                    return;
                case "requeid_matkhau":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;
                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    return;
            }

            FormHome f = new FormHome();
            f.Show();
            this.Hide();
            f.LogOut += F_LogOut;
        }

        private void F_LogOut(object sender, EventArgs e)
        {
            (sender as FormHome).isExit = false;
            (sender as FormHome).Close();
            this.Show();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            txbPassword.UseSystemPasswordChar = !cbPass.Checked;
        }

        
    }
}
