using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GTBLL
    {
        GioiTinhDAL dal = new GioiTinhDAL();
        public List<GioiTinhBEL> ReadGTList()
        {
            List<GioiTinhBEL> lst = dal.ReadGTList();
            return lst;
        }
    }
}
