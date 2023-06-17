using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bus_ThueXeTuLai;
using ET_ThueXeTuLai;
namespace DoAnXeTuLai
{
    public partial class frmHopDong : Form
    {
        BUS_HopDong HD = new BUS_HopDong();
        BUS_NhanVien NV = new BUS_NhanVien();
        BUS_KhachHang Kh = new BUS_KhachHang();
        BUS_Xe Xe = new BUS_Xe();
        SqlCommand lenh = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-140947PO\\SQLEXPRESS;Initial Catalog=XeTuLai;Integrated Security=True");
        public frmHopDong()
        {
            InitializeComponent();
        }

        private void cbbmaxe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = @"select GiaThue from Xe where tenXe = '" + cbbmaxe.Text.Trim() + "' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lblgia.Text = dt.Rows[0]["GiaThue"].ToString().Trim();
            }
        }
        private void txtsongaythue_TextChanged(object sender, EventArgs e)
        {
            if (txtsongaythue.Text != null)
                try
                {

                    int sotien = Convert.ToInt32(lblgia.Text);
                    int ngay = dtpngaytra.Value.DayOfYear - dtpngaythue.Value.DayOfYear;
                    int i = sotien * ngay;
                    txttienthue.Text = i.ToString();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi" + ex);
                }


        }
      
      


        private void frmHopDong_Load(object sender, EventArgs e)
        {
            dgvhopdong.DataSource = HD.laydsKH();
            cbbmanv.DataSource = NV.laydsNV();
            cbbmanv.ValueMember = "maNV";
            cbbmanv.DisplayMember = "tenNV";
            cbbmakh.DataSource = Kh.laydsKH();
            cbbmakh.ValueMember = "maKh";
            cbbmakh.DisplayMember = "tenKH";
            cbbmaxe.DataSource = Xe.laydsXe();
            cbbmaxe.ValueMember = "maXe";
            cbbmaxe.DisplayMember = "tenXe";

        }

        private void txtsongaythue_TextChanged_1(object sender, EventArgs e)
        {
            if (txtsongaythue.Text != null)
                try
                {

                    int sotien = Convert.ToInt32(lblgia.Text);
                    int ngay = dtpngaytra.Value.DayOfYear - dtpngaythue.Value.DayOfYear;
                    int i = sotien * ngay;
                    txttienthue.Text = i.ToString();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi" + ex);
                }
        }

        private void dtpngaytra_ValueChanged_1(object sender, EventArgs e)
        {
            int ngay = dtpngaytra.Value.DayOfYear - dtpngaythue.Value.DayOfYear;
            txtsongaythue.Text = ngay.ToString();
        }
        public bool ktra_ma(string x, int index)
        {
            if (x.Length > 0)
            {
                if (dgvhopdong.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvhopdong.Rows.Count - 1; i++)
                    {
                        if (string.Compare(dgvhopdong.Rows[i].Cells[index].Value.ToString(), x) == 0)
                        {
                            MessageBox.Show("Trùng mã");
                            return false;
                        }
                    }
                    return true;
                }
                return true;
            }
            return false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (ktra_ma(txtmahd.Text, 0) && dtpngaytra.Value > dtpngaythue.Value && txtsongaythue.Text != null)
            {
                try
                {
                    ET_HopDong et = new ET_HopDong(txtmahd.Text, cbbmanv.SelectedValue.ToString(), cbbmakh.SelectedValue.ToString(), cbbmaxe.SelectedValue.ToString(), dtpngaythue.Text, dtpngaytra.Text, txttienthue.Text);
                    if(HD.themKH(et) == true)
                    {
                        MessageBox.Show("thêm thành công ", "thông báo");
                        dgvhopdong.DataSource = HD.laydsKH();
                    }
                    else
                    {
                        MessageBox.Show("thêm không thành công ", "thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi " + ex);

                }
            }
            }

        private void dgvhopdong_Click(object sender, EventArgs e)
        {
            int dong = dgvhopdong.CurrentCell.RowIndex;
            txtmahd.Text = dgvhopdong.Rows[dong].Cells[0].Value.ToString();
            cbbmanv.Text = dgvhopdong.Rows[dong].Cells[1].Value.ToString();
            cbbmakh.Text = dgvhopdong.Rows[dong].Cells[2].Value.ToString();
            cbbmaxe.Text = dgvhopdong.Rows[dong].Cells[3].Value.ToString();
            dtpngaythue.Text = dgvhopdong.Rows[dong].Cells[4].Value.ToString();
            dtpngaytra.Text = dgvhopdong.Rows[dong].Cells[5].Value.ToString();
            txttienthue.Text = dgvhopdong.Rows[dong].Cells[6].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmahd.Text != null && dtpngaytra.Value > dtpngaythue.Value && txtsongaythue.Text != null)
            {
                try
                {
                    ET_HopDong et = new ET_HopDong(txtmahd.Text, cbbmanv.SelectedValue.ToString(), cbbmakh.SelectedValue.ToString(), cbbmaxe.SelectedValue.ToString(), dtpngaythue.Text, dtpngaytra.Text, txttienthue.Text);
                    if (HD.suaKH(et) == true)
                    {
                        MessageBox.Show("sửa thành công ", "thông báo");
                        dgvhopdong.DataSource = HD.laydsKH();
                    }
                    else
                    {
                        MessageBox.Show("sửa không thành công ", "thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi " + ex);

                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int index = dgvhopdong.SelectedCells[0].RowIndex;
            DialogResult h = MessageBox.Show("Bạn có muốn xóa ???", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (h == DialogResult.Yes && index != dgvhopdong.Rows.Count - 1)
            {
                try
                {
                    //hoi co muon xoa


                    ET_HopDong et = new ET_HopDong(txtmahd.Text, cbbmanv.SelectedValue.ToString(), cbbmakh.SelectedValue.ToString(), cbbmaxe.SelectedValue.ToString(), dtpngaythue.Text, dtpngaytra.Text, txttienthue.Text);

                    if (HD.xoaKH(et) == true)
                    {
                        MessageBox.Show("xóa thành công", "thông báo");
                        dgvhopdong.DataSource = HD.laydsKH();
                    }

                    else
                    {
                        MessageBox.Show("xóa không thành công", "thông báo");
                    }


                    //thuc thi

                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi rồi" + ex.Message);
                }

            }
        }

        private void btnsapxep_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter a = new SqlDataAdapter("select * from HopDong ORDER BY NgayThue", con);
            DataSet ds = new DataSet();
            a.Fill(ds, "HopDong");
            dgvhopdong.DataSource = ds.Tables["HopDong"].DefaultView;
            con.Close();
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.Show();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txttim.Text = "nhập mã hợp đồng...";
            txtmahd.Text = "";
            dgvhopdong.DataSource = HD.laydsKH();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter a = new SqlDataAdapter("select * from HopDong where maHD  like '%" + txttim.Text.Trim() + "%'", con);
            DataSet ds = new DataSet();
            a.Fill(ds, "HopDong");
            dgvhopdong.DataSource = ds.Tables["HopDong"].DefaultView;
            con.Close();
        }

        private void txttim_Click(object sender, EventArgs e)
        {
            txttim.Text = "";
        }

        private void frmHopDong_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show("bán có muốn thoát không ", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (txtmahd.Text != null)
            {
                lenh.CommandText = "SELECT HopDong.maHD, HopDong.maNV, HopDong.maKH, HopDong.maXe, HopDong.NgayThue, HopDong.NgayTra, HopDong.TongTienThue, KhachHang.tenKH, KhachHang.NgaySinh, KhachHang.CCCD, NhanVien.tenNV, NhanVien.maNV AS Expr1, NhanVien.ChucVu, Xe.tenXe, Xe.namSX, Xe.SoChoNgoi FROM HopDong INNER JOIN KhachHang ON HopDong.maKH = KhachHang.maKH INNER JOIN NhanVien ON HopDong.maNV = NhanVien.maNV INNER JOIN Xe ON HopDong.maXe = Xe.maXe where HopDong.maHD like @maHD";
                lenh.Parameters.Clear();
                lenh.Parameters.AddWithValue("@maHD", txtmahd.Text);
                lenh.Connection = con;
                da.SelectCommand = lenh;
                DataTable dt = new DataTable();
                da.Fill(dt);
                rpHD inds = new rpHD();
                inds.SetDataSource(dt);
                frmInHopDong f = new frmInHopDong();
                f.crystalReportViewer1.ReportSource = inds;
                f.Show();
            }
            else
            {
                MessageBox.Show("bạn phải chọn mã hợp đồng", "thông báo");

            }
        }
    }
}
