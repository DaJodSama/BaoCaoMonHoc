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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Artical01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //byte[] data = (byte[])dt.Rows[0]["IMAGE"];
                //MemoryStream ms = new MemoryStream(data);
                //pictureBox1.Image = Image.FromStream(ms);

                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();
                dataGridView1.Rows.Add(textBoxId.Text, img);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //create a DataGridView Image Column
            DataGridViewImageColumn dgvImage = new DataGridViewImageColumn();
            //set a header test to DataGridView Image Column
            dgvImage.HeaderText = "Image";
            dgvImage.ImageLayout = DataGridViewImageCellLayout.Stretch;

            DataGridViewTextBoxColumn dgvId = new DataGridViewTextBoxColumn();
            dgvId.HeaderText = "Id";

            dataGridView1.Columns.Add(dgvId);
            dataGridView1.Columns.Add(dgvImage);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 120;

            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
