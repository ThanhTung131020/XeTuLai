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
using System.IO;
using System.Data.SqlClient;
namespace DoAnXeTuLai
{
    public partial class frmNhanVien : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-140947PO\\SQLEXPRESS;Initial Catalog=XeTuLai;Integrated Security=True");
        BUS_NhanVien nv = new BUS_NhanVien();
        BUS_ChiNhanh CN = new BUS_ChiNhanh();
        string img = "";
        public frmNhanVien()
        {
            InitializeComponent();
        }
        void LoadImage(ref string imageName)
        {
            OpenFileDialog fileName = new OpenFileDialog();
            if (fileName.ShowDialog() == DialogResult.OK)
            {
                imageName = fileName.FileName;
            }
        }
        Image bytearr(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
            return m.ToArray();
        }
        public bool ktra_ma(string x, int index)
        {
            if (x.Length > 0)
            {
                if (dgvNhanVien.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvNhanVien.Rows.Count - 1; i++)
                    {
                        if (string.Compare(dgvNhanVien.Rows[i].Cells[index].Value.ToString(), x) == 0)
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
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nv.laydsNV();
            cbbmachinhanh.DataSource = CN.laydsCN();
            cbbmachinhanh.DisplayMember = "tenCN";
            cbbmachinhanh.ValueMember = "maCN";
        }

        private void btnchonanh_Click(object sender, EventArgs e)
        {
            LoadImage(ref img);
            picanh.Image = new Bitmap(img);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            byte[] b = ImageToByteArray(picanh.Image);
            if (ktra_ma(txtmanhanvien.Text, 0) && txttennhanvien.Text != null && cbbchucvu.Text != null  && cbbmachinhanh.Text != null && picanh.Image != null && txtcccd.Text != null)
            {
                try

                {


                    ET_NhanVien et = new ET_NhanVien(txtmanhanvien.Text, txttennhanvien.Text, ImageToByteArray(picanh.Image), cbbchucvu.Text, dtpns.Text, cbbmachinhanh.SelectedValue.ToString(), txtcccd.Text);

                    if (nv.themNV(et) == true)
                    {
                        MessageBox.Show("thêm thành công", "thông báo");
                        dgvNhanVien.DataSource = nv.laydsNV();
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

            byte[] b = ImageToByteArray(picanh.Image);
            if (txtmanhanvien.Text != null && txttennhanvien.Text != null && cbbchucvu.Text != null /*&& ktrangay(dtpns.Text)*/ && cbbmachinhanh.Text != null && picanh.Image != null && txtcccd.Text != null)
            {
                try

                {


                    ET_NhanVien et = new ET_NhanVien(txtmanhanvien.Text, txttennhanvien.Text, b, cbbchucvu.Text, dtpns.Text, cbbmachinhanh.SelectedValue.ToString(), txtcccd.Text);

                    if (nv.suaNV(et) == true)
                    {
                        MessageBox.Show("sửa thành công", "thông báo");
                        dgvNhanVien.DataSource = nv.laydsNV();
                    }

                    else
                    {
                      
                        MessageBox.Show("sửa thành công", "thông báo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi " + ex);

                }
            }
        }

        private void dgvNhanVien_Click(object sender, EventArgs e) {
            //{
            try
            {
                int dong = dgvNhanVien.CurrentCell.RowIndex;
                txtmanhanvien.Text = dgvNhanVien.Rows[dong].Cells[0].Value.ToString();
                txttennhanvien.Text = dgvNhanVien.Rows[dong].Cells[1].Value.ToString();
                cbbchucvu.Text = dgvNhanVien.Rows[dong].Cells[2].Value.ToString();
                dtpns.Text = dgvNhanVien.Rows[dong].Cells[3].Value.ToString();
                txtcccd.Text = dgvNhanVien.Rows[dong].Cells[4].Value.ToString();
                byte[] b = (byte[])dgvNhanVien.Rows[dong].Cells[5].Value;
                picanh.Image = bytearr(b);
                cbbmachinhanh.Text = dgvNhanVien.Rows[dong].Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            byte[] b = ImageToByteArray(picanh.Image);
            int index = dgvNhanVien.SelectedCells[0].RowIndex;
            DialogResult h = MessageBox.Show("Bạn có muốn xóa ???", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (h == DialogResult.Yes && index != dgvNhanVien.Rows.Count - 1)
            {
                try
                {
                    //hoi co muon xoa


                    ET_NhanVien et = new ET_NhanVien(txtmanhanvien.Text);

                    if (nv.xoaNV(et) == true)
                    {
                        MessageBox.Show("xóa thành công", "thông báo");
                        dgvNhanVien.DataSource = nv.laydsNV();
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

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtcccd.Text = "";
            txtmanhanvien.Text = "";
            txttennhanvien.Text = "";
            textBox2.Text = "nhập mã nhân viên...";
            dgvNhanVien.DataSource = nv.laydsNV();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void btntimk_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter a = new SqlDataAdapter("select * from NhanVien where tenNV like '%" + textBox2.Text.Trim() + "%'", con);
            DataSet ds = new DataSet();
            a.Fill(ds, "NhanVien");
            dgvNhanVien.DataSource = ds.Tables["NhanVien"].DefaultView;
            con.Close();
        }

        private void btnsapxep_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter a = new SqlDataAdapter("select * from NhanVien ORDER BY tenNV", con);
            DataSet ds = new DataSet();
            a.Fill(ds, "NhanVien");
            dgvNhanVien.DataSource = ds.Tables["NhanVien"].DefaultView;
            con.Close();
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
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
