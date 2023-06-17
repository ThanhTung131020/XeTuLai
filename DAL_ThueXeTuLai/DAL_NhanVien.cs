using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ET_ThueXeTuLai;
using System.Data;
namespace DAL_ThueXeTuLai
{
  public  class DAL_NhanVien
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-140947PO\\SQLEXPRESS;Initial Catalog=XeTuLai;Integrated Security=True");
        public DataTable laydsNV()
        {
            DataTable dsXe = null;
            try
            {
                con.Open();
                SqlCommand CN = new SqlCommand();
                CN.CommandText = "sp_LaydsNhanVien";
                CN.CommandType = CommandType.StoredProcedure;
                CN.Connection = con;
                SqlDataAdapter dapb = new SqlDataAdapter(CN);
                dsXe = new DataTable();
                dapb.Fill(dsXe);



            }
            catch (Exception ex)
            {

                Console.WriteLine("lỗi rồi" + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dsXe;
        }
        public bool themNV(ET_NhanVien et)
        {
            bool flag = false;
            try
            {
               
                con.Open();
                SqlCommand cmdthemNhanVien = new SqlCommand("sp_ThemNhanVien", con);
                cmdthemNhanVien.CommandType = CommandType.StoredProcedure;
                SqlParameter parama = new SqlParameter("@ma", et.MaNV);
                cmdthemNhanVien.Parameters.Add(parama);
                SqlParameter paraten = new SqlParameter("@ten", et.TenNV);
                cmdthemNhanVien.Parameters.Add(paraten);
                SqlParameter parachucvu = new SqlParameter("@chucvu", et.ChucVu);
                cmdthemNhanVien.Parameters.Add(parachucvu);
                SqlParameter parans = new SqlParameter("@ngaysinh", et.NgaySinh);
                cmdthemNhanVien.Parameters.Add(parans);
                SqlParameter paracccd = new SqlParameter("@CCCD", et.CCCD);
                cmdthemNhanVien.Parameters.Add(paracccd);
                SqlParameter paraanh = new SqlParameter("@anh", et.Anh);
                cmdthemNhanVien.Parameters.Add(paraanh);
                SqlParameter paramaCN = new SqlParameter("@maCN", et.MaCN);
                cmdthemNhanVien.Parameters.Add(paramaCN);




                if (cmdthemNhanVien.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();

            }
            return flag;
        }
        public bool suaNV(ET_NhanVien et)
        {
            bool flag = false;
            try
            {

                con.Open();
                SqlCommand cmdthemNhanVien = new SqlCommand("sp_SuaNhanVien", con);
                cmdthemNhanVien.CommandType = CommandType.StoredProcedure;
                SqlParameter parama = new SqlParameter("@ma", et.MaNV);
                cmdthemNhanVien.Parameters.Add(parama);
                SqlParameter paraten = new SqlParameter("@ten", et.TenNV);
                cmdthemNhanVien.Parameters.Add(paraten);
                SqlParameter parachucvu = new SqlParameter("@chucvu", et.ChucVu);
                cmdthemNhanVien.Parameters.Add(parachucvu);
                SqlParameter parans = new SqlParameter("@ngaysinh", et.NgaySinh);
                cmdthemNhanVien.Parameters.Add(parans);
                SqlParameter paracccd = new SqlParameter("@CCCD", et.CCCD);
                cmdthemNhanVien.Parameters.Add(paracccd);
                SqlParameter paraanh = new SqlParameter("@anh", et.Anh);
                cmdthemNhanVien.Parameters.Add(paraanh);
                SqlParameter paramaCN = new SqlParameter("@maCN", et.MaCN);
                cmdthemNhanVien.Parameters.Add(paramaCN);




                if (cmdthemNhanVien.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }

            }
            catch (SqlException)
            {

            }
            finally
            {
                con.Close();

            }
            return flag;
        }
        public bool xoaNV(ET_NhanVien et)
        {
            bool flag = false;
            try
            {

                con.Open();
                SqlCommand cmdxoaNV = new SqlCommand("sp_XoaNhanVien", con);
                cmdxoaNV.CommandType = CommandType.StoredProcedure;
                SqlParameter parama = new SqlParameter("@ma", et.MaNV);
                cmdxoaNV.Parameters.Add(parama);





                if (cmdxoaNV.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }

            }
            catch (Exception )
            {

            }
            finally
            {
                con.Close();

            }
            return flag;
        }
    }
}
