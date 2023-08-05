using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerBLL05
    {
        CustomerDAL05 dal = new CustomerDAL05();
        public List<CustomerBEL05> ReadCustomer05()
        {
            List<CustomerBEL05> list = dal.ReadCustomer05();
            return list;
        }
        public void NewCustomer05(CustomerBEL05 cus)
        {
            dal.NewCustomer05(cus);
        }
        public void DeleteCustomer05(CustomerBEL05 cus)
        {
            dal.DeleteCustomer05(cus);
        }
        public void EditCustomer05(CustomerBEL05 cus)
        {
            dal.EditCustomer05(cus);
        }
    }
}
