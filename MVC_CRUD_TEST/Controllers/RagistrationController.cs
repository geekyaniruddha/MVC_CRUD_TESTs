using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CRUD_TEST.Models;
namespace MVC_CRUD_TEST.Controllers
{
    public class RagistrationController : Controller
    {
        Ani_dbEntities ob = new Ani_dbEntities();
        //[Route("Ragistration")]
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult SaveData(string Nm, string Email, string Pswd, string Phno)
        {
            ob.UserRagistration.Add(new UserRagistration { Name = Nm, Email = Email, Password = Pswd, Phone = Phno });
            ob.SaveChanges();
            return Json("Success", JsonRequestBehavior.AllowGet);
        }
    }
}