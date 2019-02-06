using NlayerAppBLL.BusinessModels;
using NlayerAppBLL.DTO;
using NlayerAppBLL.Infrastructure;
using NlayerAppBLL.Interface;
using NLayerAppDAL.Enities;
using NLayerAppDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlayerAppBLL.Services
{
    class UserServices : IUserService
    {
        IUnitOfWork DataBase { get; set; }

        public UserServices(IUnitOfWork ouw)
        {
            DataBase = ouw;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public UserDTO GetUser(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void ShowUser(UserDTO userDto)
        {
            User user = DataBase.Users.Get(userDto.UserId);
            //validation
            if (user == null)
            {
                throw new ValidationException("User not found ! ", "");
            }
            //add example fun

            string login = new exempleBusnes().GetExempleB(user.Login);


            User users2 = new User
            {
                Login = login,
                Adress = "valik7766@gam9il.com",
                Name = "name",
                Password = "1234"
            };

            DataBase.Users.Create(users2);
       }


    }
}
