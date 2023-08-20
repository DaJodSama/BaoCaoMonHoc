using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class PhongBanBLL
    {
        PhongBanAccess pba = new PhongBanAccess();
        public List<PhongBan> ReadPB()
        {
            List<PhongBan> lst = pba.ReadPB();
            return lst;
        }
        public void AddPB(PhongBan pb)
        {
            pba.AddPB(pb);
        }
        public void DeletePB(PhongBan pb)
        {
            pba.DeletePB(pb);
        }
        public void EditPB(PhongBan pb)
        {
            pba.EditPB(pb);
        }
    }
}
