using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using PromptPan.Connection;

namespace PromptPan
{
   public class CrudCustomer:SQLMConnection
    {
        public void insertcustomer()
        {
            try
            {
               // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                
                string query = "insert into customer values('bang',GETDATE())";
                //SqlCommand cmd = new SqlCommand(query, con);
                cmd = new SqlCommand(query, con);
                con.Open();
                int rowaffected = cmd.ExecuteNonQuery();
                con.Close();

                //string QueryInsertCustomer = "managecustomer";
                //con.Open();
                //cmd = new SqlCommand(QueryInsertCustomer, con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@CustomerId ", System.Data.SqlDbType.Int).Value = 0;
                //cmd.Parameters.Add("@CustomerName", System.Data.SqlDbType.VarChar).Value = "Added By SP";
                //cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "i";
                //int rowaffected = cmd.ExecuteNonQuery();
                //Console.WriteLine(rowaffected);
                //con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void selectcustomer()
        {
            try
            {


               // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                //SqlCommand cmd = new SqlCommand();
                string query = "select top 1 Cumstomer from customer";
                cmd = new SqlCommand(query, con);
                con.Open();
                string CustomerName = Convert.ToString(cmd.ExecuteScalar());
                Console.WriteLine(CustomerName);
                con.Close();

                //string QuerySelectCustomer = "managecustomer";
                //con.Open();
                //cmd = new SqlCommand(QuerySelectCustomer, con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@CustomerId ", System.Data.SqlDbType.Int).Value = 0;
                //cmd.Parameters.Add("@CustomerName", System.Data.SqlDbType.VarChar).Value = "Added By SP";
                //cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "s";
                //int rowaffected = cmd.ExecuteNonQuery();
                //Console.WriteLine(rowaffected);
                //con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void updatecustomer()
        {
            try
            {
                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
              //  SqlCommand cmd = new SqlCommand();
                string UpdateQuery = "update customer set Cumstomer='champak' where Cid=5";
                con.Open();
                cmd = new SqlCommand(UpdateQuery, con);
                int rowaffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowaffected);
                con.Close();

                //string QueryUpdateCustomer = "managecustomer";
                //con.Open();
                //cmd = new SqlCommand(QueryUpdateCustomer, con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@CustomerId ", System.Data.SqlDbType.Int).Value = 5;
                //cmd.Parameters.Add("@CustomerName", System.Data.SqlDbType.VarChar).Value = "Added By SP";
                //cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "u";
                //int rowaffected = cmd.ExecuteNonQuery();
                //Console.WriteLine(rowaffected);
                //con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void deletecutomer()
        {
            try
            {
               // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
              //  SqlCommand cmd = new SqlCommand();
                string DeleteQuery = "delete from customer where Cid>=7";
                con.Open();
                cmd = new SqlCommand(DeleteQuery, con);
                int rowaffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowaffected);
                con.Close();

                //string QueryInsertCustomer = "managecustomer";
                //con.Open();
                //cmd = new SqlCommand(QueryDeleteCustomer, con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@CustomerId ", System.Data.SqlDbType.Int).Value = 7;
                //cmd.Parameters.Add("@CustomerName", System.Data.SqlDbType.VarChar).Value = "Added By SP";
                //cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "d";
                //int rowaffected = cmd.ExecuteNonQuery();
                //Console.WriteLine(rowaffected);
                //con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
