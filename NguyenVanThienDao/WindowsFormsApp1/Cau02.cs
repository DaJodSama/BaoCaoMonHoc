using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Cau02 : Form
    { 
        string path = @"D:\form.xml";
        public Cau02()
        {
            InitializeComponent();
            this.Load += Cau02_Load;
            this.ResizeEnd += Cau02_ResizeEnd;
        }

        public void Write(InfoWindows iw)
        {
            XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
            StreamWriter file = new StreamWriter(path);
            writer.Serialize(file, iw);
            file.Close();
        }

        private void Cau02_ResizeEnd(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw);
        }

        private void Cau02_Load(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw);
        }
    }
}
