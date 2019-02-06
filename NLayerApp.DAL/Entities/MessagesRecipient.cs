using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NLayerApp.DAL.Enities
{
    public class MessagesRecipient
    {
        [Key]
        public int MesRecId { get; set; }
        public int? PhonesId { get; set; }
        public int? MessageId { get; set; }

        public DateTime DateCreate { get; set; }
        [Required]
        public DateTime DateStart { get; set; }
        [Required]
        public DateTime DateEnd { get; set; }
        public int PeriodCount { get; set; }


        [ForeignKey("PhonesId")]
        public Phone Phone { get; set; }
        [ForeignKey("MessageId")]
        public Message Message { get; set; }

        public MessagesRecipient()
        {
            DateCreate = DateTime.Now.Date;
            DateStart = DateTime.Now.Date;// need default ??? 
        }
    }
}