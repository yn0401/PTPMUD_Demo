using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Assignment2_DangNgocYenNhi_2190994_DTO;

namespace DAL
{
    public class PerfumeDAO
    {
        //methods
        public bool insertPerfume(DTO_Perfume per)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=YenNhi/SQLEXPRESS;User Id=sa; Password=1; Database=Perfume";
            //insert / update /delete
            SqlCommand sqlCommand = new SqlCommand(string.Format("insert [dbo].[PRODUCT] values ('{0}', {1}, '{2}','{3}','{4}','{5}','{6}','{7}','{8}')", per.IdPerfume, per.NamePerfume, per.Brand, per.Origin, per.Price, per.Status, per.DateIn, per.DateOut));
            try
            {
                con.Open();
                sqlCommand.Connection = con;
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool updatePerfume(DTO_Perfume perf)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=YenNhi/SQLEXPRESS;User Id=sa; Password=1; Database=Perfume";
            //insert, update, delete

            SqlCommand sqlCommand = new SqlCommand(string.Format("Update [dbo].[Product] set " +
                "p_name='{0}' , brand='{1}' , price='{2}', p_status='{3}', date_in='{4}', date_produce='{5}' where p_id={6} ",
                perf.NamePerfume, perf.Brand, perf.Price, perf.Status, perf.DateIn, perf.DateOut, perf.IdPerfume));
            try
            {
                con.Open();
                sqlCommand.Connection = con;
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool deletePerfume(int IdPerfume)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=YenNhi/SQLEXPRESS;User Id=sa; Password=1; Database=Perfume";
            //insert, update, delete

            SqlCommand sqlCommand = new SqlCommand(string.Format("Delete [dbo].[Product] where p_id = {0}", IdPerfume));
            try
            {
                con.Open();
                sqlCommand.Connection = con;
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public DataSet getAllPerfume()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=YenNhi\\SQLEXPRESS;User Id=sa; Password=1; database=Perfume";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Product", con);
            try
            {
                con.Open();
                adapter.Fill(ds);
                con.Close();
            }
            catch (Exception ex)
            {
                return null;
            }
            return ds;
        }
    }
}