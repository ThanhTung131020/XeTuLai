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
public    class BUS_HopDong
    {
        DAL_hopDOng HD = new DAL_hopDOng();
        public DataTable laydsKH()
        {
            return HD.laydsHD();
        }
        public bool themKH(ET_HopDong ET)
        {
            return HD.themHD(ET);
        }
        public bool suaKH(ET_HopDong ET)
        {
            return HD.suaHD(ET);
        }
        public bool xoaKH(ET_HopDong ET)
        {
            return HD.xoaHD(ET);
        }
    }
}
