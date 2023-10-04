using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OLXCHAT3.Model
{
    public class models
    {
        public IEnumerable<OLXCHAT3.Models.ChatMddual> select { get; set; }
        public OLXCHAT3.Models.ChatMddual send { get; set; }

        //  public IEnumerable<OLXCHAT3.Models.users> userModual { get; set;}
    }
}