using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CRUD_TEST.Models;
namespace MVC_CRUD_TEST.Controllers
{
    public class UserLoginController : Controller
    {
        Ani_dbEntities ob = new Ani_dbEntities();
        // GET: UserLogin
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string MailId, string Pswd)
        {
            var q = ob.UserRagistration.Where(M => M.Email == MailId & M.Password == Pswd).FirstOrDefault();
            if (q != null)
            {
                Session["ID"] = q.Email;
                return RedirectToAction("Index", "UserProfile");
            }
            else
            {
                ViewBag.msg = "Invalid Login Credentials!!";
            }
            return View();  
        }
        public ActionResult Logout()
        {

                Session.Abandon();
                return RedirectToAction("Index", "UserLogin");

        }

    }
}