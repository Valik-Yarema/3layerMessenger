using NlayerAppBLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NlayerAppBLL.Interface;
using WebMessenger.Models;
using AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace WebMessenger.Controllers
{
    public class HomeController : Controller
    {
        IUserService userService;
        public HomeController(IUserService serv)
        {
            userService = serv;
        }
      //  UserContext db = new UserContext();
       

        public ActionResult Index(int? id)
        {
            IEnumerable<UserDTO> userDtos = userService.GetUsers();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PhoneDTO, PhoneViewModel>()).CreateMapper();
            var user = mapper.Map<IEnumerable<UserDTO>, List<UserViewModel>>(userDtos);

            return View(user);
        }
      
        public ActionResult MakeUser(int? id)
        {
            
                try
                {
                    UserDTO user = userService.GetUser(id);
                    var userV = new UserViewModel { UserId = user.UserId };
                    return View(userV);
                }
                catch(ValidationException ex)
                {
                    return Content(ex.Message);
                }
                
        }
        [HttpPost]
        public ActionResult MakeUser(UserViewModel order)
        {
            try
            {
                var orderDto = new UserDTO { UserId = order.UserId, Adress = order.Adress, Login = order.Login,Name=order.Name,Password=order.Password };
            //    userService.MakeUser(orderDto);
                return Content("<h2>Ваш заказ успешно оформлен</h2>");
            }
            catch (ValidationException ex)
            {
               // ModelState.AddModelError(ex.Property, ex.Message);
            }
            return View(order);
        }
        protected override void Dispose(bool disposing)
        {
            userService.Dispose();
            base.Dispose(disposing);
        }
    }
}