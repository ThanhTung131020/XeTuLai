using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_ThueXeTuLai
{
 public   class ET_KhachHang
    {
        private string _maKH;
        private string _tenKH;
        private string _CCCD;
        private string _NgaySinh;

        public string MaKH
        {
            get
            {
                return _maKH;
            }

            set
            {
                _maKH = value;
            }
        }

        public string TenKH
        {
            get
            {
                return _tenKH;
            }

            set
            {
                _tenKH = value;
            }
        }

        public string CCCD
        {
            get
            {
                return _CCCD;
            }

            set
            {
                _CCCD = value;
            }
        }

        public string NgaySinh
        {
            get
            {
                return _NgaySinh;
            }

            set
            {
                _NgaySinh = value;
            }
        }

        public ET_KhachHang()
        {
           
        }
        public ET_KhachHang(string makh , string tenkh , string cccd , string ngaysinh)
        {
            _maKH = makh;
            _tenKH = tenkh;
            _CCCD = cccd;
            _NgaySinh = ngaysinh;
        }
    }
}
