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
    public class BUS_Xe
    {
        DAL_Xe dalXe = new DAL_Xe();
        public DataTable laydsXe()
        {
            return dalXe.laydsXe();
        }
        public bool themxe(ET_Xe ET)
        {
            return dalXe.themXe(ET);
        }
        public bool suaxe(ET_Xe ET)
        {
            return dalXe.suaXe(ET);
        }
        public bool xoaxe(ET_Xe ET)
        {
            return dalXe.xoaXe(ET);
        }
    }
}
