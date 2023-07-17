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
    public partial class formRegister : Form
    {
        public formRegister()
        {
            InitializeComponent();
            registerEvent();
        }

        void registerEvent()
        {
            lbClose.Click += LbClose_Click;
        }

        private void LbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin frmLogin = new formLogin();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == txtUser.Text && txtPassword.Text == txtPassword.Text)
            {
                MessageBox.Show("Dang nhap thanh cong!");
                formLogin frmLogin = new formLogin(txtUser.Text, txtPassword.Text);
                this.Hide();
                frmLogin.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Dang nhap that bai!");
            }
        }
    }
}
