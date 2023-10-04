using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OLXCHAT3.Models
{
    public class ChatMddual: models
    {
        [Key]
        public int ChatId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int BuyOrSellId { get; set; }
        public string Chat1 { get; set; }

        //public string fristname { get; set; }
    }

    public class users
    {
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userEmail { get; set; }
        public string Password { get; set; }
        public string MobileNo { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
    public class models
    {
        public IEnumerable<OLXCHAT3.Models.ChatMddual> select { get; set; }
        public OLXCHAT3.Models.ChatMddual send { get; set; }

        //  public IEnumerable<OLXCHAT3.Models.users> userModual { get; set;}
    }


}