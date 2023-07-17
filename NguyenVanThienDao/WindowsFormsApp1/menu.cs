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
    public partial class menu : Form
    {
        public menu()
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
        private void btnCau01_Click(object sender, EventArgs e)
        {
            Cau01 cau01 = new Cau01();
            cau01.ShowDialog();
        }

        private void btnCau02_Click(object sender, EventArgs e)
        {
            Cau02 cau02 = new Cau02();
            cau02.ShowDialog();
        }
    }
}
