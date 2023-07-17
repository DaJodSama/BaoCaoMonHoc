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
    public partial class formLogin : Form
    {
        private string username, password;
        public formLogin()
        {
            InitializeComponent();
            registerEvent();
        }

        //Close
        void registerEvent()
        {
            lbClose.Click += LbClose_Click;
        }

        private void LbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //get data
        public formLogin(string name, string pass)
        {
            InitializeComponent();
            this.username = name;
            this.password = pass;
        }
        private void formLogin_Load(object sender, EventArgs e)
        {
            txtUser.Text = username;
            txtPassword.Text = password;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "thiendao" && txtPassword.Text == "123")
            {
                MessageBox.Show("Dang nhap thanh cong!");
                this.Hide();
                menu mn = new menu();
                mn.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Dang nhap that bai!");
            }
        }

        //Click Register
        private void btnSignin_Click(object sender, EventArgs e)
        {
            this.Hide();
            formRegister frmRegis = new formRegister();
            frmRegis.ShowDialog();
            this.Close();
        }
    }
}
