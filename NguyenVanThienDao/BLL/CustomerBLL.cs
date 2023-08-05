using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerBLL
    {
        CustomerDAL dal = new CustomerDAL();
        public List<CustomerBEL> ReadCustomer()
        {
            List<CustomerBEL> list = dal.ReadCustomer();
            return list;
        }
        public void NewCustomer(CustomerBEL cus)
        {
            dal.NewCustomer(cus);
        }
        public void DeleteCustomer(CustomerBEL cus)
        {
            dal.DeleteCustomer(cus);
        }
        public void EditCustomer(CustomerBEL cus)
        {
            dal.EditCustomer(cus);
        }
    }
}
