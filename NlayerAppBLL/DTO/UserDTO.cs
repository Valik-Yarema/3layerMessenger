using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayerAppBLL.DTO
{
   public class UserDTO
    {
        public int UserId { get; set; }
       
        public string Password { get; set; }

        public string Login { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }
    }
}
