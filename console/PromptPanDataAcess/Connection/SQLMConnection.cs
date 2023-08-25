using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace PromptPan.Connection
{
    public class SQLMConnection
    {
           internal SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
       
           internal SqlCommand cmd = new SqlCommand();
    }
}
