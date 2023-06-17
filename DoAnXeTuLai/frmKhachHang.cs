using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bus_ThueXeTuLai;
using ET_ThueXeTuLai;
using System.Data.SqlClient;
namespace DoAnXeTuLai

{
    public partial class frmKhachHang : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-140947PO\\SQLEXPRESS;Initial Catalog=XeTuLai;Integrated Security=True");
        BUS_KhachHang KH = new BUS_KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }
        public bool ktra_ma(string x, int index)
        {
            if (x.Length > 0)
            {
                if (dgvKH.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvKH.Rows.Count - 1; i++)
                    {
                        if (string.Compare(dgvKH.Rows[i].Cells[index].Value.ToString(), x) == 0)
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
            if(ktra_ma(txtmakh.Text , 0)&& txttenkh.Text != null && txtcccd.Text != null)
            {
                try
                {
                    ET_KhachHang et = new ET_KhachHang(txtmakh.Text, txttenkh.Text, txtcccd.Text, dtpns.Text);
                    if(KH.themKH(et) == true)
                    {
                        MessageBox.Show("thêm thành công", "thông báo");
                        dgvKH.DataSource = KH.laydsKH();
                    }
                    else
                    {
                        MessageBox.Show("thêm không thành công", "thông báo");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("lỗi " + ex);
                }
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKH.DataSource = KH.laydsKH();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text != null && txttenkh.Text != null && txtcccd.Text != null)
            {
                try
                {
                    ET_KhachHang et = new ET_KhachHang(txtmakh.Text, txttenkh.Text, txtcccd.Text, dtpns.Text);
                    if (KH.suaKH(et) == true)
                    {
                        MessageBox.Show("sửa thành công", "thông báo");
                        dgvKH.DataSource = KH.laydsKH();
                    }
                    else
                    {
                        MessageBox.Show("sửa không thành công", "thông báo");
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
            int index = dgvKH.SelectedCells[0].RowIndex;
            DialogResult h = MessageBox.Show("Bạn có muốn xóa ???", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (h == DialogResult.Yes && index != dgvKH.Rows.Count - 1)
            {
                try
                {
                    //hoi co muon xoa


                    ET_KhachHang et = new ET_KhachHang(txtmakh.Text, txttenkh.Text, txtcccd.Text, dtpns.Text);

                    if (KH.xoaKH(et) == true)
                    {
                        MessageBox.Show("xóa thành công", "thông báo");
                        dgvKH.DataSource = KH.laydsKH();
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

        private void dgvKH_Click(object sender, EventArgs e)
        {
            int dong = dgvKH.CurrentCell.RowIndex;
            txtmakh.Text = dgvKH.Rows[dong].Cells[0].Value.ToString();
            txttenkh.Text = dgvKH.Rows[dong].Cells[1].Value.ToString();
            txtcccd.Text = dgvKH.Rows[dong].Cells[3].Value.ToString();
            dtpns.Text = dgvKH.Rows[dong].Cells[2].Value.ToString();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtcccd.Text = "";
            txtmakh.Text = "";
            txttenkh.Text = "";
            txttim.Text = "nhập mã khách hàng";
            dgvKH.DataSource = KH.laydsKH();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter a = new SqlDataAdapter("select * from KhachHang where maKH like '%" + txttim.Text.Trim() + "%'", con);
            DataSet ds = new DataSet();
            a.Fill(ds, "KhachHang");
            dgvKH.DataSource = ds.Tables["KhachHang"].DefaultView;
            con.Close();
        }

        private void txttim_Click(object sender, EventArgs e)
        {
            txttim.Text = "";
        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
