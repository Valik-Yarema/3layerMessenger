﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayerAppBLL.DTO
{
   public class MessageDTO
    {
        public int MessageId { get; set; }

        public int UserId { get; set; }
      
        public string MessageText { get; set; }
    }
}
