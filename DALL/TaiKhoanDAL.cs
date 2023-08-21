using QLBH_XuanHa.DALL;
using QLBH_XuanHa.MODELL;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_XuanHa
{
    internal class TaiKhoanDAL : DBConnection
    {
        public List<TaiKhoanBEL> ReadTaiKhoan()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from dangnhap ", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<TaiKhoanBEL> lstCus = new List<TaiKhoanBEL>();

            while (reader.Read())
            {
                TaiKhoanBEL cus = new TaiKhoanBEL();
                cus.Id = int.Parse(reader["id"].ToString());
                cus.Username = reader["TaiKhoan"].ToString();
                cus.Password = reader["MatKhau"].ToString();
                //cus.Email = reader["EMAIL"].ToString();
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }
    }
}
