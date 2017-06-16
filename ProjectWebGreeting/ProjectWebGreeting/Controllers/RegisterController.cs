using ProjectWebGreeting.Models;
using ProjectWebGreeting.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectWebGreeting.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            AccountViewModel acc = new AccountViewModel();
            acc.account = new Account();
            return View("Index",acc);
        }
        public ActionResult submit(AccountViewModel acc)
        {
            
            return RedirectToAction("Index","ContactUs");
        }
    }
}