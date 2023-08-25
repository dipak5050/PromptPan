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
    public class CrudTotal:SQLMConnection
    {
        public void Inserttoal()
        {
            try
            {
                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                //string QueryInsertProductName = "total1";
                //SqlCommand cmd = new SqlCommand(QueryInsertProductName, con);
                //con.Open();
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@BillId", System.Data.SqlDbType.Int).Value = 0;
                //cmd.Parameters.Add("@CustomerId", System.Data.SqlDbType.Int).Value = 1;
                //cmd.Parameters.Add("@ProductTypeId", System.Data.SqlDbType.Int).Value = 2;
                //cmd.Parameters.Add("@ProductNameId", System.Data.SqlDbType.Int).Value = 12;
                //cmd.Parameters.Add("@Quantity", System.Data.SqlDbType.Int).Value = 50;
                //cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "i";

                //cmd.ExecuteNonQuery();
                //con.Close();

               // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
               //SqlCommand cmd = new SqlCommand();
                string InsertTotalQuery = "insert into total values(1,3,12,5)";
                con.Open();
                cmd = new SqlCommand(InsertTotalQuery, con);
                int rowaffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowaffected);
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void UpdateTotal()
        {
            try
            {

                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                //string UpdateTotal = "total1";
                //SqlCommand cmd = new SqlCommand(UpdateTotal, con);
                //con.Open();
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@BillId", System.Data.SqlDbType.Int).Value = 11;
                //cmd.Parameters.Add("@CustomerId", System.Data.SqlDbType.Int).Value = 4;
                //cmd.Parameters.Add("@ProductTypeId", System.Data.SqlDbType.Int).Value = 2;
                //cmd.Parameters.Add("@ProductNameId", System.Data.SqlDbType.Int).Value = 12;
                //cmd.Parameters.Add("@Quantity", System.Data.SqlDbType.Int).Value = 50;
                //cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "u";

                //cmd.ExecuteNonQuery();
                //con.Close();


               // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
               // SqlCommand cmd = new SqlCommand();
                string UpdateTotalQuery = "update total set Cid=1 where BillNo=3";
                con.Open();
                cmd = new SqlCommand(UpdateTotalQuery, con);
                int rowaffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowaffected);
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void deleteTotal()
        {
            try
            {
                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultconnection"].ToString());

                //string DeleteTotalV = "total1";
                //SqlCommand cmd = new SqlCommand(DeleteTotalV, con);
                //con.Open();
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@CustomerId", System.Data.SqlDbType.Int).Value = 4;
                //cmd.Parameters.Add("@ProductTypeId", System.Data.SqlDbType.Int).Value = 2;
                //cmd.Parameters.Add("@ProductNameId", System.Data.SqlDbType.Int).Value = 12;
                //cmd.Parameters.Add("@Quantity", System.Data.SqlDbType.Int).Value = 50;
                //cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "d";
                //cmd.Parameters.Add("@BillId", System.Data.SqlDbType.Int).Value = 20;


                //cmd.ExecuteNonQuery();
                //con.Close();


               // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
               // SqlCommand cmd = new SqlCommand();
                string DeleteQuery = "delete from total where BillNo=1";
                con.Open();
                cmd = new SqlCommand(DeleteQuery, con);
                int rowaffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowaffected);
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void selectTotal()
        {
            try
            {
                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

                //string SelcetTotalV = "total1";
                //SqlCommand cmd = new SqlCommand(SelcetTotalV, con);
                //con.Open();
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@CustomerId", System.Data.SqlDbType.Int).Value = 4;
                //cmd.Parameters.Add("@ProductTypeId", System.Data.SqlDbType.Int).Value = 2;
                //cmd.Parameters.Add("@ProductNameId", System.Data.SqlDbType.Int).Value = 12;
                //cmd.Parameters.Add("@Quantity", System.Data.SqlDbType.Int).Value = 50;
                //cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "s";
                //cmd.Parameters.Add("@BillId", System.Data.SqlDbType.Int).Value = 20;


                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                //SqlCommand cmd = new SqlCommand();
                string SelectQuery = "select * from total";
                con.Open();
                cmd = new SqlCommand(SelectQuery, con);

                SqlDataReader dr = cmd.ExecuteReader();
                Console.WriteLine("BillNo=" + dr["BillNo"] + "ClidentId=" + dr["Cid"] +
                "ProductTypeID=" + dr["PTid"] + "ProductNameID=" + dr["PNid"] + "Quntity=" + dr["Quantity"] +
                "CretedOn=" + dr["CretedOn"]);
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}

