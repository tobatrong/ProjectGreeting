using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectWebGreeting.Models;
using ProjectWebGreeting.ViewModels;

namespace ProjectWebGreeting.Controllers
{
    public class AboutUsController : Controller
    {
        // GET: AboutUs
        public ActionResult Index()
        {
            AccountViewModel acc = new AccountViewModel();
            acc.account = new Account();
            return View("Index",acc);
        }
    }
}