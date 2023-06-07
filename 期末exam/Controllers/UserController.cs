using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 期末exam.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index(string name,float? num)
        {
            var result = "";
            if (num is 1 )
            {
                result ="do";
            }
            else if (num is 2)
            {
                result = "re";
            }
            else if (num is 3)
            {
                result = "mi";
            }
            else if (num is 4)
            {
                result = "fa";
            }
            else if (num is 5)
            {
                result = "so";
            }
            else if (num is 6)
            {
                result = "la";
            }
            if (num is 7)
            {
                result = "xi";
            }


            ViewBag.Name = name;    
                ViewBag.Num = num;  


            return View();
        }
        public ActionResult Music()
        {
            return View();
        }

    }
}