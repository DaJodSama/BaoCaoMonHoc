using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        public int sMaTK { get; set; }
        public string sTaiKhoan { get; set; }
        public string sMatKhau { get; set; }
        public QuyenBEL QuyenHan { get; set; }
        public string TenQuyen
        {
            get { return QuyenHan.sTenQuyen; }
        }
        public string filename { get; set; }
        public byte[] Image { get; set; }
    }

    public class QuyenBEL
    {
        public int iMaQuyen { get; set; }
        public string sTenQuyen { get; set; }
        public List<TaiKhoan> Customers { get; set; }
    }
}
