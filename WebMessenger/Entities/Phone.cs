using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMessenger.Enities
{
    public class Phone
    {
        [Key]
        public int PhoneId { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        
           

        public ICollection<AdInfo> PhoneColl { get; set; }
        public ICollection<MessagesRecipient> PhoneMesColl { get; set; }

        public Phone()
        {
            PhoneColl = new List<AdInfo>();
            PhoneMesColl = new List<MessagesRecipient>();
        }
    }

}