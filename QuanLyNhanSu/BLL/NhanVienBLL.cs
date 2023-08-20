using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienAccess dal = new NhanVienAccess();
        public List<NhanVien> ReadNV()
        {
            List<NhanVien> list = dal.ReadNV();
            return list;
        }
        public void AddNV(NhanVien nv)
        {
            dal.AddNV(nv);
        }
        public void DeleteNV(NhanVien nv)
        {
            dal.DeleteNV(nv);
        }
        public void EditNV(NhanVien nv)
        {
            dal.EditNV(nv);
        }
        public void SearchNV(NhanVien nv)
        {
            dal.SearchNV(nv);
        }
    }
}
