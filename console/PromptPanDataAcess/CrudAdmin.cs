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
    public class CrudAdmin:SQLMConnection
    {
        public void AdminSelect()
        {
            try
            {
               // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
               // SqlCommand cmd = new SqlCommand();

                string Queryselectadmin = "select * from admin";
                con.Open();
                cmd = new SqlCommand(Queryselectadmin, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("id=" + dr["Adminid"] + "namw=" + dr["Adminname"] + "gallo=" + dr["Gallo"] + "CreatedOn=" + dr["createdon"]);
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void AdimnInsert()
        {
            try
            {
                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                //SqlCommand cmd = new SqlCommand();

                string QuerysInsertadmin = "insert into admin values('admin1',50000,GETDATE())";

                con.Open();
                cmd = new SqlCommand(QuerysInsertadmin, con);
                int rowaffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowaffected);
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
        public void AdminUpate()
        {

            try
            {
                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                //SqlCommand cmd = new SqlCommand();

                string QueryUpdatetBuy = "update admin set Gallo=50000 where Adminid=1";
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
        public void AdminDelete()
        {
            try
            {
                //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                //SqlCommand cmd = new SqlCommand();

                string QueryDeleteadmin = "delete  from admin where Adminid=4";
                con.Open();
                cmd = new SqlCommand(QueryDeleteadmin, con);
                int rowaffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowaffected);
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

