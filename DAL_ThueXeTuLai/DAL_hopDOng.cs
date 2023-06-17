using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ET_ThueXeTuLai;
namespace DAL_ThueXeTuLai
{
   public class DAL_hopDOng
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-140947PO\\SQLEXPRESS;Initial Catalog=XeTuLai;Integrated Security=True");
        public DataTable laydsHD()
        {
            DataTable dsNV = null;
            try
            {
                con.Open();
                SqlCommand CN = new SqlCommand();
                CN.CommandText = "sp_LaydsHopDong";
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
        public bool themHD(ET_HopDong et)
        {
            bool flag = false;
            try
            {
                con.Open();
                SqlCommand cmdThemChiNhanh = new SqlCommand("sp_themHopDong", con);
                cmdThemChiNhanh.CommandType = CommandType.StoredProcedure;
                SqlParameter parama = new SqlParameter("@ma", et.MaHD);
                cmdThemChiNhanh.Parameters.Add(parama);
                SqlParameter paranv = new SqlParameter("@manv", et.MaNV);
                cmdThemChiNhanh.Parameters.Add(paranv);
                SqlParameter paraKH = new SqlParameter("@makh", et.MaKH);
                cmdThemChiNhanh.Parameters.Add(paraKH);
                SqlParameter parax = new SqlParameter("@maxe", et.MaXe);
                cmdThemChiNhanh.Parameters.Add(parax);
                SqlParameter paraNT = new SqlParameter("@ngaythue", et.Ngaythue);
                cmdThemChiNhanh.Parameters.Add(paraNT);
                SqlParameter paraNtra = new SqlParameter("@ngaytra", et.NgayTra);
                cmdThemChiNhanh.Parameters.Add(paraNtra);
                SqlParameter paratien = new SqlParameter("@tongtienthue", et.TienThue);
                cmdThemChiNhanh.Parameters.Add(paratien);



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
        public bool suaHD(ET_HopDong et)
        {
            bool flag = false;
            try
            {
                con.Open();
                SqlCommand cmdThemChiNhanh = new SqlCommand("sp_suaHopDong", con);
                cmdThemChiNhanh.CommandType = CommandType.StoredProcedure;
                SqlParameter parama = new SqlParameter("@ma", et.MaHD);
                cmdThemChiNhanh.Parameters.Add(parama);
                SqlParameter paranv = new SqlParameter("@manv", et.MaNV);
                cmdThemChiNhanh.Parameters.Add(paranv);
                SqlParameter paraKH = new SqlParameter("@makh", et.MaKH);
                cmdThemChiNhanh.Parameters.Add(paraKH);
                SqlParameter parax = new SqlParameter("@maxe", et.MaXe);
                cmdThemChiNhanh.Parameters.Add(parax);
                SqlParameter paraNT = new SqlParameter("@ngaythue", et.Ngaythue);
                cmdThemChiNhanh.Parameters.Add(paraNT);
                SqlParameter paraNtra = new SqlParameter("@ngaytra", et.NgayTra);
                cmdThemChiNhanh.Parameters.Add(paraNtra);
                SqlParameter paratien = new SqlParameter("@tongtienthue", et.TienThue);
                cmdThemChiNhanh.Parameters.Add(paratien);



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
        public bool xoaHD(ET_HopDong et)
        {
            bool flag = false;
            try
            {
                con.Open();
                SqlCommand cmdxoaNV = new SqlCommand("sp_xoaHD", con);
                cmdxoaNV.CommandType = CommandType.StoredProcedure;
                SqlParameter parama = new SqlParameter("@ma", et.MaHD);
                cmdxoaNV.Parameters.Add(parama);



                if (cmdxoaNV.ExecuteNonQuery() > 0)
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
