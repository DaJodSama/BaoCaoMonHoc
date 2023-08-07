using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artical01
{
    public partial class Form1 : Form
    {
        public Form1()
        {            InitializeComponent();
            this.Load += Form1_Load;
            this.ResizeEnd += Form1_ResizeEnd;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;
            this.Text = width.ToString() + " - " + height.ToString();
            
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;
            this.Text = width.ToString() + " - " + height.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}
