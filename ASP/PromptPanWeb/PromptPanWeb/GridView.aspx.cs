using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PromptPan;

namespace PromptPanWeb
{
    public partial class GridView : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            //con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            //cmd.Connection = con;
            //cmd.CommandText = "select * from ProductType";
            //con.Open();
            //RepeatInformation.DataSource = cmd.ExecuteReader();
            //RepeatInformation.DataBind();
            //con.Close();

            CrudProductType pt = new CrudProductType();


            RepeatInformation.DataSource = pt.Producttypegrid();

            RepeatInformation.DataBind();

        }

        protected void RepeatInformation_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}
