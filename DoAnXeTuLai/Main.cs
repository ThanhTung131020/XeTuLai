using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnXeTuLai
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnqlyNV_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.ShowDialog();
        }

        private void btnqlyxe_Click(object sender, EventArgs e)
        {
            frmXe f = new frmXe();
            f.ShowDialog();
        }

        private void btnqlychinhanh_Click(object sender, EventArgs e)
        {
            frmChiNhanh f = new frmChiNhanh();
            f.ShowDialog();
        }

        private void btnqlykhachhang_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();
        }

        private void btnqlyhopdong_Click(object sender, EventArgs e)
        {
            frmHopDong f = new frmHopDong();
            f.ShowDialog();
        }
    }
}
