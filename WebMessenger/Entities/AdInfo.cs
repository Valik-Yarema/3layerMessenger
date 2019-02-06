using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebMessenger.Enities
{
    public class AdInfo
    {
        [Key]
        public int AdInfoId { get; set; }

        public int? PhonesId { get; set; }
        [ForeignKey("PhonesId")]
        public Phone Phone { get; set; }

        public string AddfInfo { get; set; }

    }
}