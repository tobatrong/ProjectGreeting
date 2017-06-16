using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectWebGreeting.Areas.Admin.Controllers
{
    public class UiController : Controller
    {
        // GET: Admin/Ui
        public ActionResult Index()
        {
            return View();
        }
    }
}