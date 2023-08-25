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
    public class CrudBuy:SQLMConnection
    {
        public void BuyInsert()
        {
            try
            {
                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                //SqlCommand cmd = new SqlCommand();

                string QuerysInsertBuy = "insert into buy values('soda',4,12)";
                con.Open();
                cmd = new SqlCommand(QuerysInsertBuy, con);
                int rowaffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowaffected);
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void BuyUpdate()
        {
            try
            {
                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                //SqlCommand cmd = new SqlCommand();

                string QueryUpdatetBuy = "update  buy set producname='jira' where productid=13";
                con.Open();
                cmd = new SqlCommand(QueryUpdatetBuy, con);
                int rowaffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowaffected);
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void BuyDelete()
        {
            try
            {
                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                //SqlCommand cmd = new SqlCommand();

                string QueryDeleteBuy = "delete  from buy where productid=13";
                con.Open();
                cmd = new SqlCommand(QueryDeleteBuy, con);
                int rowaffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowaffected);
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void BuySelect()
        {
            try
            {

               // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
               // SqlCommand cmd = new SqlCommand();

                string QueryselectBuy = "select * from buy";
                con.Open();
                cmd = new SqlCommand(QueryselectBuy, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("ProductId=" + dr["productid"] + "ProductName=" + dr["producname"] + "producttype=" + dr["producttype"] + "ProductRS=" + dr["productrs"]);
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
