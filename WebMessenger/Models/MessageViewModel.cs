using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMessenger.Models
{
    public class MessageViewModel
    {
        public int MessageId { get; set; }

        public int UserId { get; set; }

        public string MessageText { get; set; }
    }
}