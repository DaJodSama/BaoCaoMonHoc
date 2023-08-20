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
    public partial class FormHome : Form
    {
        public bool isExit = true;

        public event EventHandler LogOut;
        public FormHome()
        {
            InitializeComponent();
        }

        

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình?", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOut(this, new EventArgs());
        }

        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }
        }
        private void tsUser_Click(object sender, EventArgs e)
        {
            FormUsers f = new FormUsers();
            f.ShowDialog();
        }
        private void tsPB_Click(object sender, EventArgs e)
        {
            FormDepartment f = new FormDepartment();
            f.ShowDialog();
        }

        private void tsEmployee_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain();
            f.ShowDialog();
        }
    }
}
