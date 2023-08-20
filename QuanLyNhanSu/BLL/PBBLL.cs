using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PBBLL
    {
        PBDAL dal = new PBDAL();
        public List<PhongBanBEL> ReadPBList()
        {
            List<PhongBanBEL> lst = dal.ReadPBList();
            return lst;
        }
    }
}
