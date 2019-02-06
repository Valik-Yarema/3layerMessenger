using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMessenger.Models
{
    public class MessagesRecipientViewModel
    {
        public int MesRecId { get; set; }
        public int PhonesId { get; set; }
        public int MessageId { get; set; }

        public DateTime? DateCreate { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateEnd { get; set; }
        public int PeriodCount { get; set; }
    }
}