using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayerAppBLL.BusinessModels
{
    public class exempleBusnes
    {
        private string value="Exemple404";
        public string Value { get { return value; } }
        public string GetExempleB(string sum)
        {
                      
            return sum+DateTime.Now.Day.ToString(); 
        }
    }
}
