using QLBH_XuanHa.DALL;
using QLBH_XuanHa.MODELL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_XuanHa.BALL
{
    public class TaiKhoanBAL
    {
        TaiKhoanDAL dal = new TaiKhoanDAL();
        public List<TaiKhoanBEL> ReadTaiKhoan()
        {
            List<TaiKhoanBEL> lstCus = dal.ReadTaiKhoan();
            return lstCus;
        }
    }
}
