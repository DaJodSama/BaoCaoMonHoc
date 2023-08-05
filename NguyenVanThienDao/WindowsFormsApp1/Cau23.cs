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
    public partial class Cau23 : Form
    {
        PictureBox pb = new PictureBox();
     
        int x = 0;
        int y = 0;
        public Cau23()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(100, 100);
            pb.Location = new Point(x, y);
            this.Controls.Add(pb);
            pb.ImageLocation = @"d:\Images\gio.jpg";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            x -= 10;
            pb.Location = new Point(x, y);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            x += 10;
            pb.Location = new Point(x, y);
        }
    }
}
