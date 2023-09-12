using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PromptPan.Connection;
using PromptPan;
using System.Data.SqlClient;
using System.Configuration;

namespace PromptPanWeb
{

    public partial class Login : System.Web.UI.Page
    {
        internal SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
        internal SqlCommand cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            //PromptPan.CrudCustomer promptpancust = new PromptPan.CrudCustomer();
            //promptpancust.insertcustomer();

            string cumstomer = txtclient.Text;
            string customerpass = txtpass.Text;

            CrudCustomer customer = new CrudCustomer();

            bool cust = customer.Authenticateuser(cumstomer, customerpass, out string validationmessage);
           // bool exist = dAusers.Authenticateuser(useremail, userpass, out string validationmessage);
            if (cust)
            {
                Session["usersname"] = cumstomer;
                Response.Redirect("about.aspx");
            }
            else
            {
                lblwarning.Text = validationmessage;
            }


        }
    }
}