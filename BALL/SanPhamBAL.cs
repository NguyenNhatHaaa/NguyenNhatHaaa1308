using QLBH_XuanHa.DALL;
using QLBH_XuanHa.MODELL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_XuanHa.BALL
{
    public class SanPhamBAL
    {
        SanPhamDAL dal = new SanPhamDAL();
        public List<SanPhamBEL> ReadSanPham()
        {
            List<SanPhamBEL> lstCus = dal.ReadSanPham();
            return lstCus;
        }
        public List<SanPhamBEL> Timkiem(SanPhamBEL c)
        {
            List<SanPhamBEL> lstCus = dal.timkiem(c);
            return lstCus;
        }

        public void AddSanPham(SanPhamBEL cus)
        {
            dal.AddSanPham(cus);
        }
        public void DeleteSanPham(SanPhamBEL cus)
        {
            dal.DeleteSanPham(cus);
        }
        public void EditSanPham(SanPhamBEL cus)
        {
            dal.EditSanPham(cus);
        }


    }
}
