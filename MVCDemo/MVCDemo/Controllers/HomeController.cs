using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "Hello from Index";
        //}

        //public string Index(string id)
        //{
        //    return "The value of Id = " + id;
        //    //http://localhost/MVCDemo/Home/Index/10
        //}

        //public string Index(string id, string name)
        //{
        //    return "The value of Id = " + id + " and Name = " + name;
        //    http://localhost/MVCDemo/home/index/10?name=Pragim
        //}

        //query string
        //public string Index(string id)
        //{
        //    return "The value of Id = " + id + " and Name = " + Request.QueryString["name"];
        //}

        public ActionResult Index()
        {
            ViewBag.Countries = new List<string>()
            {
                "India",
                "Pakistan",
                "Bangaladesh",
                "Sri Lanka"
            };

            return View();
        }
    }
}