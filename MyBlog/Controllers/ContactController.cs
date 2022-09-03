using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();
        public ActionResult Index()
        {
            var contactvalues = cm.GetList();
            return View(contactvalues);
        }
        public ActionResult GetContactDetails(int? id)
        {
            if (!id.HasValue)
            {
                return RedirectToAction("Index");
            }
            var contactvalues = cm.GetByID(id.Value);
            return View(contactvalues);
        }
        
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }



    }
}