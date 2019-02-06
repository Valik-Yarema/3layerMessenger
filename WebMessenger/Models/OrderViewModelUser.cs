using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace NlayerAppDAL.Models
{
    public class OrderViewModelUser
    {   
        public int UserId { get; set; }
        public string Password { get; set; } 
        public string Login { get; set; } 
        public string Name { get; set; } 
        public string Adress { get; set; } 
    }
}