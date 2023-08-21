using QLBH_XuanHa.DALL;
using QLBH_XuanHa.MODELL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_XuanHa.BALL
{
    public class HoaDonBAL
    {
        HoaDonDAL dal = new HoaDonDAL();
        public List<HoaDonBEL> ReadHoaDon()
        {
            List<HoaDonBEL> lstCus = dal.ReadHoaDon();
            return lstCus;
        }

        public void AddHoaDon(HoaDonBEL cus)
        {
            dal.AddHoaDon(cus);
        }
        public void EditHoaDon(HoaDonBEL cus)
        {
            dal.EditHoaDon(cus);
        }
        public void DeleteHoaDon(HoaDonBEL cus)
        {

        }
    }
}
