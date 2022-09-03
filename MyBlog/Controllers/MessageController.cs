using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        public ActionResult InBox()
        {
            return View();
        }
    }
}