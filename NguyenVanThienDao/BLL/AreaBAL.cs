using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AreaBAL
    {
        AreaDAL dal=new AreaDAL();
        public List<AreaBEL> ReadAreaList()
        {
            List<AreaBEL> listArea=dal.ReadAreaList();
            return listArea;
        }
    }
}
