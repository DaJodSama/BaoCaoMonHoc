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

        private void btn20_Click(object sender, EventArgs e)
        {
            Cau20 cau20=new Cau20();
            cau20.ShowDialog();
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            Cau23 cau23 = new Cau23();
            cau23.ShowDialog();
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            Cau24 cau24 = new Cau24();
            cau24.ShowDialog();
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            Cau25 cau25 = new Cau25();
            cau25.ShowDialog();
        }

        private void btnADO01_Click(object sender, EventArgs e)
        {
            ADO01 aDO01 = new ADO01();
            aDO01.ShowDialog();
        }

        private void btnADO02_Click(object sender, EventArgs e)
        {
            ADO02 aDO02 = new ADO02();
            aDO02.ShowDialog();
        }

        private void btnADO03_Click(object sender, EventArgs e)
        {
            ADO03 aDO03 = new ADO03();
            aDO03.ShowDialog();
        }

        private void btnADO04_Click(object sender, EventArgs e)
        {
            CustomerGUI aDO04 = new CustomerGUI();
            aDO04.ShowDialog();
        }

        private void btnADO05_Click(object sender, EventArgs e)
        {
            ADO05 aDO05 = new ADO05();
            aDO05.ShowDialog();
        }
    }
}
