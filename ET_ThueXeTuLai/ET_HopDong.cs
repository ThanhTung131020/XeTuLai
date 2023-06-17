using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_ThueXeTuLai
{
  public  class ET_HopDong
    {
        private string _maHD;
        private string _maNV;
        private string _maKH;
        private string _maXe;
        private string _Ngaythue;
        private string _ngayTra;
        private string _tienThue;

        public string MaHD
        {
            get
            {
                return _maHD;
            }

            set
            {
                _maHD = value;
            }
        }

        public string MaNV
        {
            get
            {
                return _maNV;
            }

            set
            {
                _maNV = value;
            }
        }

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

        public string MaXe
        {
            get
            {
                return _maXe;
            }

            set
            {
                _maXe = value;
            }
        }

        public string Ngaythue
        {
            get
            {
                return _Ngaythue;
            }

            set
            {
                _Ngaythue = value;
            }
        }

        public string NgayTra
        {
            get
            {
                return _ngayTra;
            }

            set
            {
                _ngayTra = value;
            }
        }

        public string TienThue
        {
            get
            {
                return _tienThue;
            }

            set
            {
                _tienThue = value;
            }
        }

        public ET_HopDong()
        {
           
               
        }
        public ET_HopDong(string mahd , string manv , string makh , string maxe , string ngaythue , string ngaytra, string tienthue)
        {
            _maHD = mahd;
            _maXe = maxe;
            _maNV = manv;
            _maKH = makh;
            _ngayTra = ngaytra;
            _Ngaythue = ngaythue;
            _tienThue = tienthue;


        }

    }
}
