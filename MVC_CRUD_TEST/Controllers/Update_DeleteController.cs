using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CRUD_TEST.Models;
namespace MVC_CRUD_TEST.Controllers
{
    public class Update_DeleteController : Controller
    {
        Ani_dbEntities ob = new Ani_dbEntities();
        // GET: Update_Delete
        public ActionResult Index()
        {
            ViewBag.list = ob.StudentDetails.ToList();
            return View();
        }
        public JsonResult GetUser(string ide)
        {
            var q = ob.StudentDetails.Where(M => M.ID == ide).FirstOrDefault();
            return Json(q, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Index(Homemodel hm)
        {
            var q = ob.StudentDetails.Where(M => M.ID == hm.studentdetails.ID).FirstOrDefault();
            q.Name = hm.studentdetails.Name;
            q.Roll = hm.studentdetails.Roll;
            q.Stream = hm.studentdetails.Stream;
            q.City = hm.studentdetails.City;
            q.Gender = hm.studentdetails.Gender;
            ob.SaveChanges();
            ViewBag.list = ob.StudentDetails.ToList();
            return View();
        }
        public JsonResult DelUser(string ide)
        {
            var q = ob.StudentDetails.Where(M => M.ID == ide).FirstOrDefault();
            ob.StudentDetails.Remove(q);
            ob.SaveChanges();
            return Json("success", JsonRequestBehavior.AllowGet);
        }
    }
}