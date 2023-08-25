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
    public class CrudProductType:SQLMConnection
    {
        public void InsertProductType()
        {
            try
            {
               // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
               // SqlCommand cmd = new SqlCommand();

                string QueryInsertProductType = "productTypepro";
                con.Open();
                cmd = new SqlCommand(QueryInsertProductType, con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@ProductTypeId", System.Data.SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@ProductTypeName", System.Data.SqlDbType.VarChar).Value = "Added By SP";
                cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "i";
                int rowaffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowaffected);
                con.Close();

                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                //SqlCommand cmd = new SqlCommand();
                //string insertQuery = "insert into ProductType values('card',GETDATE());";
                //con.Open();
                //cmd = new SqlCommand(DeleteQuery, con);
                //int rowaffected = cmd.ExecuteNonQuery();
                //Console.WriteLine(rowaffected);
                //con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
        public void selectProductType()
        {
            try
            {
                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                //SqlCommand cmd = new SqlCommand();

                string QueryslectproductType = "select * from ProductType";
                con.Open();
                cmd = new SqlCommand(QueryslectproductType, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("ProductTypeId=" + dr["PTid"] + "ProductType=" + dr["PType"] + "CreatedOn" + dr["CreatedOn"]);
                }
                con.Close();

                // string Queryslectproduct = "productTypepro";
                // con.Open();

                // cmd = new SqlCommand(Queryslectproduct, con);
                ////cmd.CommandType = System.Data.CommandType.StoredProcedure;
                // cmd.Parameters.Add("@ProductTypeId",System.Data.SqlDbType.Int).Value = 7;
                // cmd.Parameters.Add("@ProductTypeName", System.Data.SqlDbType.VarChar).Value = "Added By SP";
                // cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "s";
                // //cmd.ExecuteNonQuery();
                // cmd.ExecuteNonQuery();
                //// Console.WriteLine(select);
                // con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void UpdateProductType()
        {
            try
            {
                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                //SqlCommand cmd = new SqlCommand();


                //string UpdateProductType = "productTypepro";
                //con.Open();
                //cmd = new SqlCommand(UpdateProductType, con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@ProductTypeId", System.Data.SqlDbType.Int).Value = 6;
                //cmd.Parameters.Add("@ProductTypeName", System.Data.SqlDbType.VarChar).Value = "hi";
                //cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = 'u';
                //int rowaffected = cmd.ExecuteNonQuery();
                //Console.WriteLine(rowaffected);
                //con.Close();

              //  SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultconnection"].ToString());
              // SqlCommand cmd = new SqlCommand();
                string updateproducttype = "update producttype set ptype='update' where ptid=6";
                con.Open();
                cmd = new SqlCommand(updateproducttype, con);
                int rowaffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowaffected);
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
        public void DeleteProductType()
        {
            try
            {
                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                string DeleteProductType = "delete from ProductType where PTid>=7";
                //SqlCommand cmd = new SqlCommand(DeleteProductType, con);
                cmd = new SqlCommand(DeleteProductType, con);
                con.Open();
                int rowaffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowaffected);
                con.Close();

                //string DeleteProductType = "productTypepro";
                //con.Open();
                //cmd = new SqlCommand(DeleteProductType, con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@ProductTypeId", System.Data.SqlDbType.Int).Value = 6;
                //cmd.Parameters.Add("@ProductTypeName", System.Data.SqlDbType.VarChar).Value = "hi";
                //cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = 'd';
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

