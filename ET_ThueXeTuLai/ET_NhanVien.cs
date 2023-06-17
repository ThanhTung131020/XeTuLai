using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ET_ThueXeTuLai
{
   public class ET_NhanVien
    {
        private string _maNV;
        private string _tenNV;
        private byte[] _Anh;
        private string _chucVu;
        private string _ngaySinh;
        private string _maCN;
        private string _CCCD;

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

        public string TenNV
        {
            get
            {
                return _tenNV;
            }

            set
            {
                _tenNV = value;
            }
        }

        public byte[] Anh
        {
            get
            {
                return _Anh;
            }

            set
            {
                _Anh = value;
            }
        }

        public string ChucVu
        {
            get
            {
                return _chucVu;
            }

            set
            {
                _chucVu = value;
            }
        }

        public string NgaySinh
        {
            get
            {
                return _ngaySinh;
            }

            set
            {
                _ngaySinh = value;
            }
        }

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

        public ET_NhanVien()
        {
           
            
        }

        public ET_NhanVien(string ma , string ten , byte[] anh , string chucvu , string ngaysinh , string macn , string cccd)
        {
            _maNV = ma;
            _tenNV = ten;
            _Anh = anh;
            _chucVu = chucvu;
            _ngaySinh = ngaysinh;
            _maCN = macn;
            _CCCD = cccd;
        }
        public ET_NhanVien(string ma)
        {
            _maNV = ma;
        }
    } 
}
