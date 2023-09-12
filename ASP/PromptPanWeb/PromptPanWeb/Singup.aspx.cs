using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using PromptPan.Connection;

namespace PromptPanWeb
{
    public partial class Singup : System.Web.UI.Page
    {
        internal SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
        internal SqlCommand cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO customer (Cumstomer,CustomerPass,CreatedOn) VALUES (@Customer, @CustomerPass, GETDATE())";

            cmd = new SqlCommand("insert into customer values Cumstomer='" + txtCustNew.Text + "' and CustomerPass='" + txtPassNew.Text + "'getdate()", con);
            
            cmd = new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("@Customer", txtCustNew.Text);
            cmd.Parameters.AddWithValue("@CustomerPass", txtPassNew.Text);
            
          
            if (txtCustNew.Text=="" && txtPassNew.Text=="")
            {
                lblwar.Text = "Insert any values";      
            }
            else
            {

                lblwar.Text = "Insert succesfull";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("Login.aspx");

            }
        }
    }
}