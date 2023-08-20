using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class UserMainBLL
    {
        UserAccess dal = new UserAccess();
        public string CheckLogin(TaiKhoan taikhoan)
        {
            if (taikhoan.sTaiKhoan=="") {
                return "requeid_taikhoan";
            }
            if (taikhoan.sMatKhau == "")
            {
                return "requeid_matkhau";
            }
            string info=dal.CheckLogin(taikhoan);
            return info;
        }
        public List<TaiKhoan> ReadCustomer()
        {
            List<TaiKhoan> list = dal.ReadCustomer();
            return list;
        }
        public void AddCustomer(TaiKhoan tk)
        {
            dal.AddCustomer(tk);
        }
        public void DeleteCustomer(TaiKhoan tk)
        {
            dal.DeleteCustomer(tk);
        }
        public void EditCustomer(TaiKhoan tk)
        {
            dal.EditCustomer(tk);
        }
    }
}
