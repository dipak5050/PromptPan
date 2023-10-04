using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using OLXCHAT3.Models;
using chatdb;


namespace OLXCHAT3.Models
{
    public class DBContext
    {
        string cs = ConfigurationManager.ConnectionStrings["OLXDB"].ConnectionString;
        public List<ChatMddual> GetChatMdduals()
        {
            List<ChatMddual> chatList = new List<ChatMddual>();
            
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("ChatSelect", con);
            //string q= "select chat.ChatId,chat.UserId,chat.ProductId,chat.BuyOrSellId,chat.chat1,Users.firstName" +
            //    " from chat inner join Users on Users.userId = chat.UserId";
            //SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                users u = new users();
                ChatMddual c = new ChatMddual();
                c.ChatId = Convert.ToInt32(dr.GetValue(0).ToString());
                c.UserId = Convert.ToInt32(dr.GetValue(1).ToString());
                c.ProductId = Convert.ToInt32(dr.GetValue(2).ToString());
                c.BuyOrSellId = Convert.ToInt32(dr.GetValue(3).ToString());
                c.Chat1 = dr.GetValue(4).ToString();
                

                chatList.Add(c);
                
            }
            con.Close();

            return chatList;
            
        }
        public List<users> GetUsersmodual()
        {
            List<users> userlist = new List<users>();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("ChatSelect", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                users u = new users();
                u.userId = Convert.ToInt32(dr.GetValue(0).ToString());
                u.firstName = (dr.GetValue(1).ToString());
                u.lastName = (dr.GetValue(2).ToString());
                u.userEmail = (dr.GetValue(3).ToString());
                u.Password = (dr.GetValue(4).ToString());
                u.MobileNo = (dr.GetValue(5).ToString());
                u.Gender = (dr.GetValue(6).ToString());
                u.Address = (dr.GetValue(7).ToString());
                u.City = (dr.GetValue(8).ToString());
                userlist.Add(u);
            }
            con.Close();

            return userlist;
        }
        //public bool insertChat(ChatMddual chaat)
        //{
        //    //string msg= string.Empty;
        //    string cs = ConfigurationManager.ConnectionStrings["OLXDB"].ConnectionString;
        //    SqlConnection con = new SqlConnection(cs);
        //    // SqlCommand cmd = new SqlCommand("insert into chat values(@UserId,@ProductId,BuyOrSellId,@Chat)", con);
        //    SqlCommand cmd = new SqlCommand("insert into chat values(@UserId,@ProductId,@BuyOrSellId,@chat)", con);
        //    //cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@UserId", chaat.UserId);
        //    cmd.Parameters.AddWithValue("@ProductId", chaat.ProductId);
        //    cmd.Parameters.AddWithValue("@BuyOrSellId", chaat.BuyOrSellId);
        //    cmd.Parameters.AddWithValue("@chat", chaat.Chat);
        //    con.Open();
        //    int i= cmd.ExecuteNonQuery();
        //    con.Close();
        //    //msg = "data inserted ";     
        //    if(i>0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public bool insertChat(ChatMddual chat)
        {
            if (chat == null)
            {
                throw new ArgumentNullException("chat", "The chat object is null.");
            }

            string cs = ConfigurationManager.ConnectionStrings["OLXDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(cs))
            {
                throw new ConfigurationErrorsException("Connection string 'OLXDB' not found in configuration.");
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO chat VALUES (@UserId, @ProductId, @BuyOrSellId, @chat)", con);
                    cmd.Parameters.AddWithValue("@UserId", chat.UserId);
                    cmd.Parameters.AddWithValue("@ProductId", chat.ProductId);
                    cmd.Parameters.AddWithValue("@BuyOrSellId", chat.BuyOrSellId);
                    cmd.Parameters.AddWithValue("@chat", chat.Chat1);

                  //  SqlCommand cmd = new SqlCommand("INSERT INTO chat (chat1) VALUES (@chat)", con);
                    //cmd.Parameters.AddWithValue("@chat", chat.Chat1);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }
        public bool insertChatViaSend(ChatMddual chat)
        {
            if (chat == null)
            {
                throw new ArgumentNullException("chat", "The chat object is null.");
            }

            string cs = ConfigurationManager.ConnectionStrings["OLXDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(cs))
            {
                throw new ConfigurationErrorsException("Connection string 'OLXDB' not found in configuration.");
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO chat (chat1) VALUES (@chat)", con);
                    cmd.Parameters.AddWithValue("@chat", chat.Chat1);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }
        //public int inesertchat(ChatMddual chaat)
        //{
        //    using (var context = new OLX_DBEntities())
        //    {
        //        chat c = new chat()
        //        {
        //            UserId = chaat.UserId,
        //            ProductId=chaat.ProductId,
        //            BuyOrSellId=chaat.BuyOrSellId,
        //            chat1=chaat.Chat1   

        //        };
        //        context.chats.Add(c);
        //        context.SaveChanges();
        //        return c.ChatId;
        //    }
        //}
    }
}