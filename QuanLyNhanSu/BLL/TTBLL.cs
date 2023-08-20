using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TTBLL
    {
        TrangThaiDAL dal = new TrangThaiDAL();
        public List<TrangThaiBEL> ReadTTList()
        {
            List<TrangThaiBEL> lst = dal.ReadTTList();
            return lst;
        }
    }
}
