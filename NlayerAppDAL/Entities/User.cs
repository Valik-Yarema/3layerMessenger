using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NLayerAppDAL.Enities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Password { get; set; }


        [Required]
        public string Login { get; set; }
      
        public string Name { get; set; }

        [Required]
        public string Adress { get; set; }
       

        public ICollection<Message> UsersColl { get; set; }
        public User()
        {
            UsersColl = new List<Message>();
        }
    }
}
