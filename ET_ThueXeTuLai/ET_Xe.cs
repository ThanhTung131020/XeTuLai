using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_ThueXeTuLai
{
  public  class ET_Xe
    {
        private string _maXe;
        private string _tenXe;
        private string _namSX;
        private string _dongCo;
        private string _soChoNgoi;
        private string _GiaThue;

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

        public string TenXe
        {
            get
            {
                return _tenXe;
            }

            set
            {
                _tenXe = value;
            }
        }

        public string NamSX
        {
            get
            {
                return _namSX;
            }

            set
            {
                _namSX = value;
            }
        }

        public string DongCo
        {
            get
            {
                return _dongCo;
            }

            set
            {
                _dongCo = value;
            }
        }

        public string SoChoNgoi
        {
            get
            {
                return _soChoNgoi;
            }

            set
            {
                _soChoNgoi = value;
            }
        }

        public string GiaThue
        {
            get
            {
                return _GiaThue;
            }

            set
            {
                _GiaThue = value;
            }
        }
        public ET_Xe()
        {
            _maXe = "";
            _tenXe = "";
            _namSX = "";
            _soChoNgoi = "";
            _GiaThue = "";
            _dongCo = "";
        }
        public ET_Xe(string ma , string ten , string nam , string sochongoi , string gia , string dongco)
        {
            _maXe = ma;
            _tenXe = ten;
            _namSX = nam;
            _soChoNgoi = sochongoi;
            _GiaThue = gia;
            _dongCo = dongco;
        }
    }
}
