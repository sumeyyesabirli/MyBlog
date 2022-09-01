﻿using BusinessLayer.Concrete;
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
        [HttpGet]
        public ActionResult GetContactDetails(int id)
        {

            var contactvalues = cm.GetByID(id);
            return View(contactvalues);

        }
        [HttpPost]
        public ActionResult GetContactDetails()
        {

            return RedirectToAction("Index");

        }


    }
}