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
  
   public class DAL_Xe
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-140947PO\\SQLEXPRESS;Initial Catalog=XeTuLai;Integrated Security=True");
         public DataTable laydsXe()
        {
            DataTable dsXe = null;
            try
            {
                con.Open();
                SqlCommand CN = new SqlCommand();
                CN.CommandText = "sp_layDsXe";
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
        public bool themXe(ET_Xe et)
        {
            bool flag = false;
            try
            {
                con.Open();
                SqlCommand cmdthemxe = new SqlCommand("sp_themXe", con);
                cmdthemxe.CommandType = CommandType.StoredProcedure;
                SqlParameter parama = new SqlParameter("@ma", et.MaXe);
                cmdthemxe.Parameters.Add(parama);
                SqlParameter paraTen = new SqlParameter("@ten", et.TenXe);
                cmdthemxe.Parameters.Add(paraTen);
                SqlParameter paranamsx = new SqlParameter("@namsx", et.NamSX);
                cmdthemxe.Parameters.Add(paranamsx);
                SqlParameter paradongco = new SqlParameter("@dongco", et.DongCo);
                cmdthemxe.Parameters.Add(paradongco);
                SqlParameter parasochongoi = new SqlParameter("@sochongoi", et.SoChoNgoi);
                cmdthemxe.Parameters.Add(parasochongoi);
                SqlParameter paragiathue = new SqlParameter("@gia", et.GiaThue);
                cmdthemxe.Parameters.Add(paragiathue);




                if (cmdthemxe.ExecuteNonQuery() > 0)
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
        public bool suaXe(ET_Xe et)
        {
            bool flag = false;
            try
            {
                con.Open();
                SqlCommand cmdthemxe = new SqlCommand("sp_SuaXe", con);
                cmdthemxe.CommandType = CommandType.StoredProcedure;
                SqlParameter parama = new SqlParameter("@ma", et.MaXe);
                cmdthemxe.Parameters.Add(parama);
                SqlParameter paraTen = new SqlParameter("@ten", et.TenXe);
                cmdthemxe.Parameters.Add(paraTen);
                SqlParameter paranamsx = new SqlParameter("@namsx", et.NamSX);
                cmdthemxe.Parameters.Add(paranamsx);
                SqlParameter paradongco = new SqlParameter("@dongco", et.DongCo);
                cmdthemxe.Parameters.Add(paradongco);
                SqlParameter parasochongoi = new SqlParameter("@sochongoi", et.SoChoNgoi);
                cmdthemxe.Parameters.Add(parasochongoi);
                SqlParameter paragiathue = new SqlParameter("@gia", et.GiaThue);
                cmdthemxe.Parameters.Add(paragiathue);




                if (cmdthemxe.ExecuteNonQuery() > 0)
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
        public bool xoaXe(ET_Xe et)
        {
            bool flag = false;
            try
            {
               
                con.Open();
                SqlCommand cmdxoaTA = new SqlCommand("sp_XoaXe", con);
                cmdxoaTA.CommandType = CommandType.StoredProcedure;
                SqlParameter parama = new SqlParameter("@ma", et.MaXe);
                cmdxoaTA.Parameters.Add(parama);





                if (cmdxoaTA.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }

            }
            catch (Exception)
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
