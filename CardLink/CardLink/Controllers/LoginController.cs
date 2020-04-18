using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CardLink_Project.Models;

namespace CardLink_Project.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            var login = new User() { UserName = "Chris", Password = "asd123" };
            return View();
        }
    }
}