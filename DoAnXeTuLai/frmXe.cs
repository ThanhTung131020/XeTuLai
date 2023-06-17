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
    public partial class frmXe : Form
    {
        public frmXe()
        {
            InitializeComponent();
        }
        BUS_Xe xe = new BUS_Xe();
        private void frmXe_Load(object sender, EventArgs e)
        {
            dgvxe.DataSource = xe.laydsXe();
        }
        public bool ktra_ma(string x, int index)
        {
            if (x.Length > 0)
            {
                if (dgvxe.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvxe.Rows.Count - 1; i++)
                    {
                        if (string.Compare(dgvxe.Rows[i].Cells[index].Value.ToString(), x) == 0)
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
        public bool ktrangay(string dt)
        {
            if (dt.Length > 0)
            {
                //ktra ngày nhập có hợp lệ hay không
                DateTime d = Convert.ToDateTime(dt);
                if (DateTime.Compare(d, DateTime.Now) < 0)
                {
                    return true;
                }
            }
            MessageBox.Show("nhập lại ngày");
            return false;

        }
        private void btnthemm_Click(object sender, EventArgs e)
        {
            if (ktra_ma(txtmaxe.Text, 0) && txttenxe.Text != null && ktrangay(dtpnamsx.Text) && txtdongco.Text != null && txtchongoi.Text != null && txtgiathue.Text != null)
            {


                try

                {


                    ET_Xe et = new ET_Xe(txtmaxe.Text, txttenxe.Text, dtpnamsx.Text, txtchongoi.Text, txtgiathue.Text, txtdongco.Text);

                    if (xe.themxe(et) == true)
                    {
                        MessageBox.Show("thêm thành công", "thông báo");
                        dgvxe.DataSource = xe.laydsXe();
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmaxe.Text != null && txttenxe.Text != null && ktrangay(dtpnamsx.Text) && txtdongco.Text != null && txtchongoi.Text != null && txtgiathue.Text != null)
            {
                try

                {


                    ET_Xe et = new ET_Xe(txtmaxe.Text, txttenxe.Text, dtpnamsx.Text, txtchongoi.Text, txtgiathue.Text, txtdongco.Text);

                    if (xe.suaxe(et) == true)
                    {
                        MessageBox.Show("sửa thành công", "thông báo");
                        dgvxe.DataSource = xe.laydsXe();
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

        private void dgvxe_Click(object sender, EventArgs e)
        {
            txtmaxe.Enabled = false;
            int dong = dgvxe.CurrentCell.RowIndex;
            txtmaxe.Text = dgvxe.Rows[dong].Cells[0].Value.ToString();
            txttenxe.Text = dgvxe.Rows[dong].Cells[1].Value.ToString();
            dtpnamsx.Text = dgvxe.Rows[dong].Cells[2].Value.ToString();
            txtdongco.Text = dgvxe.Rows[dong].Cells[3].Value.ToString();
            txtchongoi.Text = dgvxe.Rows[dong].Cells[4].Value.ToString();
            txtgiathue.Text = dgvxe.Rows[dong].Cells[5].Value.ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int index = dgvxe.SelectedCells[0].RowIndex;
            DialogResult h = MessageBox.Show("Bạn có muốn xóa ???", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (h == DialogResult.Yes && index != dgvxe.Rows.Count - 1)
            {
                try
                {
                    //hoi co muon xoa


                    ET_Xe et = new ET_Xe(txtmaxe.Text, txttenxe.Text, dtpnamsx.Text, txtchongoi.Text, txtgiathue.Text, txtdongco.Text);

                    if (xe.xoaxe(et) == true)
                    {
                        MessageBox.Show("xóa thành công", "thông báo");
                        dgvxe.DataSource = xe.laydsXe();
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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmXe_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmaxe.Text = "";
            txttenxe.Text = "";
            txtchongoi.Text = "";
            txtdongco.Text = "";
            txtgiathue.Text = "";
            txtmaxe.Enabled = true;
        }
    }
}
