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
   public class DAL_ChiNhanh
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-140947PO\\SQLEXPRESS;Initial Catalog=XeTuLai;Integrated Security=True");
        public DataTable laydsCN()
        {
            DataTable dsNV = null;
            try
            {
                con.Open();
                SqlCommand CN = new SqlCommand();
                CN.CommandText = "sp_LaydsChiNhanh";
                CN.CommandType = CommandType.StoredProcedure;
                CN.Connection = con;
                SqlDataAdapter dapb = new SqlDataAdapter(CN);
                dsNV = new DataTable();
                dapb.Fill(dsNV);



            }
            catch (SqlException )
            {

               
            }
            finally
            {
                con.Close();
            }
            return dsNV;
        }
        public bool themCN(ET_ChiNhanh et)
        {
            bool flag = false;
            try
            {
                con.Open();
                SqlCommand cmdThemChiNhanh = new SqlCommand("sp_ThemChiNhanh", con);
                cmdThemChiNhanh.CommandType = CommandType.StoredProcedure;
                cmdThemChiNhanh.CommandType = CommandType.StoredProcedure;
                SqlParameter parama = new SqlParameter("@ma", et.MaCN);
                cmdThemChiNhanh.Parameters.Add(parama);
                SqlParameter paraten = new SqlParameter("@ten", et.TenCN);
                cmdThemChiNhanh.Parameters.Add(paraten);
                SqlParameter paradiachi = new SqlParameter("@diachi", et.DiaChi);
                cmdThemChiNhanh.Parameters.Add(paradiachi);




                if (cmdThemChiNhanh.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }

            }
            catch (SqlException )
            {

            }
            finally
            {
                con.Close();

            }
            return flag;
        }
        public bool suaCN(ET_ChiNhanh et)
        {
            bool flag = false;
            try
            {
                con.Open();
                SqlCommand cmdThemChiNhanh = new SqlCommand("sp_SuaChiNhanh", con);
                cmdThemChiNhanh.CommandType = CommandType.StoredProcedure;
                cmdThemChiNhanh.CommandType = CommandType.StoredProcedure;
                SqlParameter parama = new SqlParameter("@ma", et.MaCN);
                cmdThemChiNhanh.Parameters.Add(parama);
                SqlParameter paraten = new SqlParameter("@ten", et.TenCN);
                cmdThemChiNhanh.Parameters.Add(paraten);
                SqlParameter paradiachi = new SqlParameter("@diachi", et.DiaChi);
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
        public bool xoaCN(ET_ChiNhanh et)
        {
            bool flag = false;
            try
            {

                con.Open();
                SqlCommand cmdxoaTA = new SqlCommand("sp_XoaChiNhanh", con);
                cmdxoaTA.CommandType = CommandType.StoredProcedure;
                SqlParameter parama = new SqlParameter("@ma", et.MaCN);
                cmdxoaTA.Parameters.Add(parama);





                if (cmdxoaTA.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }

            }
            catch (SqlException )
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
