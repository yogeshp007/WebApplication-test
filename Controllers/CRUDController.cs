using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CRUDController : Controller
    {
        // GET: CRUD
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.msg = "no data";
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection fc)
        {
            string fname = fc["firstname"];
            string lname = fc[1];

            ViewBag.msg = "My fullname is " + fname + " " + lname;


            return View();
        }
    }
}