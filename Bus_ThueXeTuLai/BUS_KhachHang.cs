using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ET_ThueXeTuLai;
using DAL_ThueXeTuLai;
namespace Bus_ThueXeTuLai
{
  public  class BUS_KhachHang
    {
       DAL_KhachHang dalXe = new DAL_KhachHang();
        public DataTable laydsKH()
        {
            return dalXe.laydsKH();
        }
        public bool themKH(ET_KhachHang ET)
        {
            return dalXe.themKH(ET);
        }
        public bool suaKH(ET_KhachHang ET)
        {
            return dalXe.suaKH(ET);
        }
        public bool xoaKH(ET_KhachHang ET)
        {
            return dalXe.xoaKH(ET);
        }
    }
}
