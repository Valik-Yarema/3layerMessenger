using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMessenger.Enities;
using WebMessenger.Models;

namespace WebMessenger.Controllers
{
    public class HomeController : Controller
    {
        UserContext db = new UserContext();
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        public ActionResult MakeOrder(int? id)
        {
            if (id == null)
                return HttpNotFound();
            User user = db.Users.Find(id);
            if (user == null)
                return HttpNotFound();
           OrderViewModelUser orderModel = new OrderViewModelUser { UserId= user.UserId };
            return View(orderModel);
        }
        [HttpPost]
        public ActionResult MakeOrder(OrderViewModelUser orderModel)
        {
            if (ModelState.IsValid)
            {
                User user = db.Users.Find(orderModel.UserId);
                if (user== null)
                    return HttpNotFound();
            
                /*    string sum = user.Name;
                // если сегодня первое число месяца, тогда скидка в 10%
                if (DateTime.Now.Day == 1)
                    sum = sum + DateTime.Now.ToString();
                */
                Phone phone = new Phone
                {
                    PhoneId = user.UserId,
                    PhoneNumber = orderModel.Name+orderModel.Password,
                  
                };
                db.Phones.Add(phone);
                db.SaveChanges();
                return Content("<h2>Ваш телефон додано </h2>");
            }
            return View(orderModel);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}