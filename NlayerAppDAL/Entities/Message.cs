using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NLayerAppDAL.Enities
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }

        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public string MessageText { get; set; }

        public ICollection<MessagesRecipient> MesMesColl { get; set; }
        public Message()
        {
            MesMesColl = new List<MessagesRecipient>();
        }
    }
}