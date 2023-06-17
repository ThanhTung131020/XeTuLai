using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_ThueXeTuLai
{
    public class ET_ChiNhanh
    {
        private string _maCN;
        private string _tenCN;
        private string _DiaChi;

        public string MaCN
        {
            get
            {
                return _maCN;
            }

            set
            {
                _maCN = value;
            }
        }

        public string TenCN
        {
            get
            {
                return _tenCN;
            }

            set
            {
                _tenCN = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }

            set
            {
                _DiaChi = value;
            }
        }

        public ET_ChiNhanh()
        {
            _maCN = "";
            _tenCN = "";
            _DiaChi = "";
            
        }
        public ET_ChiNhanh(string ma , string ten , string diachi)
        {
            _maCN = ma;
            _tenCN  = ten;
            _DiaChi = diachi;
        }

    }
}
