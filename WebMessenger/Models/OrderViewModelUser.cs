using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebMessenger.Enities;

namespace WebMessenger.Models
{
    public class OrderViewModelUser
    {   [Key]
        public int UserId { get; set; }
        public string Password { get; set; } 
        public string Login { get; set; } 
        public string Name { get; set; } 
        public string Adress { get; set; } 
    }
}