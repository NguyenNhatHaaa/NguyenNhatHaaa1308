using QLBH_XuanHa.DALL;
using QLBH_XuanHa.MODELL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_XuanHa.BALL
{
    public class NhaCungCapBAL
    {
        NhaCungCapDAL dal = new NhaCungCapDAL();
        public List<NhaCungCapBEL> ReadNhaCungCap()
        {
            List<NhaCungCapBEL> lstCus = dal.ReadNhaCungCap();
            return lstCus;
        }

        public void NewNhaCungCap(NhaCungCapBEL cus)
        {
            dal.NewNhaCungCap(cus);
        }
        public void EditNhaCungCap(NhaCungCapBEL cus)
        {
            dal.EditNhaCungCap(cus);
        }
        public void DeleteNhaCungCap(NhaCungCapBEL cus)
        {
            dal.DeleteNhaCungCap(cus);
        }
     

      
    }
}
