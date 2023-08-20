using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class UsersBLL
    {
        UserAccess dal = new UserAccess();
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
