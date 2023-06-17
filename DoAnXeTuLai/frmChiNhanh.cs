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

namespace DoAnXeTuLai
{
    public partial class frmChiNhanh : Form
    {
        BUS_ChiNhanh busCN = new BUS_ChiNhanh();
        
        public frmChiNhanh()
        {
            InitializeComponent();
        }
        public bool ktra_ma(string x, int index)
        {
            if (x.Length > 0)
            {
                if (dgvchiNhanh.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvchiNhanh.Rows.Count - 1; i++)
                    {
                        if (string.Compare(dgvchiNhanh.Rows[i].Cells[index].Value.ToString(), x) == 0)
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
            if(ktra_ma(txtmachinhanh.Text , 0) && txttenchinhanh.Text != null && txtdiachi.Text != null)
            {
                try

                {


                    ET_ChiNhanh et = new ET_ChiNhanh(txtmachinhanh.Text, txttenchinhanh.Text, txtdiachi.Text);

                    if (busCN.themCN(et) == true)
                    {
                        MessageBox.Show("thêm thành công", "thông báo");
                        dgvchiNhanh.DataSource = busCN.laydsCN();
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

        private void frmChiNhanh_Load(object sender, EventArgs e)
        {
            dgvchiNhanh.DataSource = busCN.laydsCN();
        }

        private void dgvchiNhanh_Click(object sender, EventArgs e)
        {
            txtmachinhanh.Enabled = false;
            int dong = dgvchiNhanh.CurrentCell.RowIndex;
            txtmachinhanh.Text = dgvchiNhanh.Rows[dong].Cells[0].Value.ToString();
            txttenchinhanh.Text = dgvchiNhanh.Rows[dong].Cells[1].Value.ToString();
            txtdiachi.Text = dgvchiNhanh.Rows[dong].Cells[2].Value.ToString();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmachinhanh.Text = "";
            txtdiachi.Text = "";
            txttenchinhanh.Text = "";
            txtmachinhanh.Enabled = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmachinhanh.Text != null && txttenchinhanh.Text != null && txtdiachi.Text != null)
            {
                try

                {


                    ET_ChiNhanh et = new ET_ChiNhanh(txtmachinhanh.Text, txttenchinhanh.Text, txtdiachi.Text);

                    if (busCN.suaCN(et) == true)
                    {
                        MessageBox.Show("sửa thành công", "thông báo");
                        dgvchiNhanh.DataSource = busCN.laydsCN();
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
            int index = dgvchiNhanh.SelectedCells[0].RowIndex;
            DialogResult h = MessageBox.Show("Bạn có muốn xóa ???", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (h == DialogResult.Yes && index != dgvchiNhanh.Rows.Count - 1)
            {
                try
                {
                    //hoi co muon xoa


                    ET_ChiNhanh et = new ET_ChiNhanh(txtmachinhanh.Text, txttenchinhanh.Text, txtdiachi.Text);

                    if (busCN.xoaCN(et) == true)
                    {
                        MessageBox.Show("xóa thành công", "thông báo");
                        dgvchiNhanh.DataSource = busCN.laydsCN();
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

        private void frmChiNhanh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show("ban co muon thoat", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
