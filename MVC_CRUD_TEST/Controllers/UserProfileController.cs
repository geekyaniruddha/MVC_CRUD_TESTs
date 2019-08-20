using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC_CRUD_TEST.Controllers
{
    public class UserProfileController : Controller
    {
        // GET: UserProfile
        public ActionResult Index()
        {
            //if (Session.IsNewSession)
            //{
            //    return RedirectToAction("Index", "UserLogin");
           // }
           // else
            //{
                ViewBag.list = Session["ID"].ToString();
            //}
            return View();
        }
    }
}