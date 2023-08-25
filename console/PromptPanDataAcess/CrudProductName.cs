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
    public class CrudProductName:SQLMConnection
    {
        public void InsertProductName()
        {
            try
            {
                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                //string QueryInsertProductName = "productNamepro";
                //SqlCommand cmd = new SqlCommand(QueryInsertProductName, con);
                //con.Open();
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@ProductNameId", System.Data.SqlDbType.Int).Value = 0;
                //cmd.Parameters.Add("@ProductName", System.Data.SqlDbType.VarChar).Value = "icecream";
                //cmd.Parameters.Add("@ProductID", System.Data.SqlDbType.Int).Value = 2;
                //cmd.Parameters.Add("@ProductRS", System.Data.SqlDbType.Float).Value = 12;
                //cmd.Parameters.Add("@ProductStock", System.Data.SqlDbType.Int).Value = 50;
                //cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "i";

                //cmd.ExecuteNonQuery();
                //con.Close();


               // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
              //  SqlCommand cmd = new SqlCommand();
                string InsertProductTypeQuery = "insert into ProductName values('icecream',2,12,50)";
                con.Open();
                cmd = new SqlCommand(InsertProductTypeQuery, con);
                int rowaffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowaffected);
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void UpdateProductName()
        {
            try
            {
                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                //string UpdateProductName = "productNamepro";
                //SqlCommand cmd = new SqlCommand(UpdateProductName, con);
                //con.Open();
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@ProductNameId", System.Data.SqlDbType.Int).Value = 14;
                //cmd.Parameters.Add("@ProductName", System.Data.SqlDbType.VarChar).Value = "gulfi";
                //cmd.Parameters.Add("@ProductID", System.Data.SqlDbType.Int).Value = 2;
                //cmd.Parameters.Add("@ProductRS", System.Data.SqlDbType.Float).Value = 12;
                //cmd.Parameters.Add("@ProductStock", System.Data.SqlDbType.Int).Value = 500;
                //cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "u";

                //cmd.ExecuteNonQuery();
                //con.Close();

                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                //SqlCommand cmd = new SqlCommand();
                string UpdateProductTypeQuery = "update ProductName set PName='gulfi' where pid = 31";
                con.Open();
                cmd = new SqlCommand(UpdateProductTypeQuery, con);
                int rowaffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowaffected);
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void deleteProductName()
        {
            try
            {
                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                //SqlCommand cmd = new SqlCommand();
                string DeleteProductTypeQuery = "delete from ProductName where PNid=23";
                con.Open();
                cmd = new SqlCommand(DeleteProductTypeQuery, con);
                int rowaffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowaffected);
                con.Close();

                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                //string DeleteProductName = "productNamepro";
                //SqlCommand cmd = new SqlCommand(DeleteProductName, con);
                //con.Open();
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@ProductNameId", System.Data.SqlDbType.Int).Value = 14;
                //cmd.Parameters.Add("@ProductName", System.Data.SqlDbType.VarChar).Value = "gulfi";
                //cmd.Parameters.Add("@ProductID", System.Data.SqlDbType.Int).Value = 2;
                //cmd.Parameters.Add("@ProductRS", System.Data.SqlDbType.Float).Value = 12;
                //cmd.Parameters.Add("@ProductStock", System.Data.SqlDbType.Int).Value = 500;
                //cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "u";

                //cmd.ExecuteNonQuery();
                //con.Close();


            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public void selectProductName()
        {
            try
            {
                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                //SqlCommand cmd = new SqlCommand();

                string SelectProductTypeQuery = "select * from ProductName";
                con.Open();
                cmd = new SqlCommand(SelectProductTypeQuery, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("ProductNameId=" + dr["PNid"] + "ProductNam=" + dr["PName"] +
                        "ProductTypeId=" + dr["PTid"] + "ProductRs=" + dr["PRS"] + "stock=" + dr["Stock"] +
                        "CretedOn=" + dr["CreatedOn"]);


                    //Console.WriteLine("ProductNameId="  +dr["PNid"]+  "ProductNam="   +dr["PName"]+
                    //    "ProductTypeId="  +dr["PTid"]+  "ProductRs="  +dr["PRS"]+  "stock="  +dr["Stock"]+  
                    //    "CretedOn="  +dr["CreatedOn"]);
                    con.Close();
                }


                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                //string SelectProductName = "productNamepro";
                //SqlCommand cmd = new SqlCommand(SelectProductName, con);
                //con.Open();
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //
                //cmd.Parameters.Add("@ProductNameId", System.Data.SqlDbType.Int).Value = 14;
                //cmd.Parameters.Add("@ProductName", System.Data.SqlDbType.VarChar).Value = "gulfi";
                //cmd.Parameters.Add("@ProductID", System.Data.SqlDbType.Int).Value = 2;
                //cmd.Parameters.Add("@ProductRS", System.Data.SqlDbType.Float).Value = 12;
                //cmd.Parameters.Add("@ProductStock", System.Data.SqlDbType.Int).Value = 500;
                //cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "s";

                //cmd.ExecuteNonQuery();
                //con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}