using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMessenger.Models
{
    public class UserViewModel
    {
        public int UserId { get; set; }

        public string Password { get; set; }

        public string Login { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }
    }
}