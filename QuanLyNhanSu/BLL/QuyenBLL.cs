using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QuyenBLL
    {
        QuyenDAL dal = new QuyenDAL();
        public List<QuyenBEL> ReadQuyenList()
        {
            List<QuyenBEL> lst = dal.ReadQuyenList();
            return lst;
        }
    }
}
