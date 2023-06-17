using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET_ThueXeTuLai;
using DAL_ThueXeTuLai;
using System.Data;
namespace Bus_ThueXeTuLai
{
   public class BUS_NhanVien
    {
        DAL_NhanVien NV = new DAL_NhanVien();
        public DataTable laydsNV()
        {
            return NV.laydsNV();
        }
        public bool themNV(ET_NhanVien ET)
        {
            return NV.themNV(ET);
        }
        public bool suaNV(ET_NhanVien ET)
        {
            return NV.suaNV(ET);
        }
        public bool xoaNV(ET_NhanVien ET)
        {
            return NV.xoaNV(ET);
        }
    }
}
