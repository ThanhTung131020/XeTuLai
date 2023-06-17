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
    public class BUS_ChiNhanh
    {
        DAL_ChiNhanh dalXe = new DAL_ChiNhanh();
        public DataTable laydsCN()
        {
            return dalXe.laydsCN();
        }
        public bool themCN(ET_ChiNhanh ET)
        {
            return dalXe.themCN(ET);
        }
        public bool suaCN(ET_ChiNhanh ET)
        {
            return dalXe.suaCN(ET);
        }
        public bool xoaCN(ET_ChiNhanh ET)
        {
            return dalXe.xoaCN(ET);
        }
    }
}
