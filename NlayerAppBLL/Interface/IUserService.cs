using NlayerAppBLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayerAppBLL.Interface
{
    public interface IUserService
    {
            void ShowUser(UserDTO userDto);
            UserDTO GetUser(int? id);
            IEnumerable<UserDTO> GetUsers();
            void Dispose();
        
    }
}
