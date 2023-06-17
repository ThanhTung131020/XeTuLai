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
  public  class DAL_KhachHang
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-140947PO\\SQLEXPRESS;Initial Catalog=XeTuLai;Integrated Security=True");
        public DataTable laydsKH()
        {
            DataTable dsNV = null;
            try
            {
                con.Open();
                SqlCommand CN = new SqlCommand();
                CN.CommandText = "sp_LaydsKH";
                CN.CommandType = CommandType.StoredProcedure;
                CN.Connection = con;
                SqlDataAdapter dapb = new SqlDataAdapter(CN);
                dsNV = new DataTable();
                dapb.Fill(dsNV);



            }
            catch (SqlException)
            {


            }
            finally
            {
                con.Close();
            }
            return dsNV;
        }
        public bool themKH(ET_KhachHang et)
        {
            bool flag = false;
            try
            {
                con.Open();
                SqlCommand cmdThemChiNhanh = new SqlCommand("sp_ThemKhachHang", con);
                cmdThemChiNhanh.CommandType = CommandType.StoredProcedure;
                SqlParameter parama = new SqlParameter("@ma", et.MaKH);
                cmdThemChiNhanh.Parameters.Add(parama);
                SqlParameter paraten = new SqlParameter("@ten", et.TenKH);
                cmdThemChiNhanh.Parameters.Add(paraten);
                SqlParameter parans = new SqlParameter("@NS", et.NgaySinh);
                cmdThemChiNhanh.Parameters.Add(parans);
                SqlParameter paradiachi = new SqlParameter("@CCCD", et.CCCD);
                cmdThemChiNhanh.Parameters.Add(paradiachi);


                if (cmdThemChiNhanh.ExecuteNonQuery() > 0)
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
        public bool suaKH(ET_KhachHang et)
        {
            bool flag = false;
            try
            {
                con.Open();
                SqlCommand cmdThemChiNhanh = new SqlCommand("sp_SuaKhachHang", con);
                cmdThemChiNhanh.CommandType = CommandType.StoredProcedure;
                SqlParameter parama = new SqlParameter("@ma", et.MaKH);
                cmdThemChiNhanh.Parameters.Add(parama);
                SqlParameter paraten = new SqlParameter("@ten", et.TenKH);
                cmdThemChiNhanh.Parameters.Add(paraten);
                SqlParameter parans = new SqlParameter("@NS", et.NgaySinh);
                cmdThemChiNhanh.Parameters.Add(parans);
                SqlParameter paradiachi = new SqlParameter("@CCCD", et.CCCD);
                cmdThemChiNhanh.Parameters.Add(paradiachi);


                if (cmdThemChiNhanh.ExecuteNonQuery() > 0)
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
        public bool xoaKH(ET_KhachHang et)
        {
            bool flag = false;
            try
            {

                con.Open();
                SqlCommand cmdxoaTA = new SqlCommand("sp_XoaKhachHang", con);
                cmdxoaTA.CommandType = CommandType.StoredProcedure;
                SqlParameter parama = new SqlParameter("@ma", et.MaKH);
                cmdxoaTA.Parameters.Add(parama);





                if (cmdxoaTA.ExecuteNonQuery() > 0)
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
    }
}
