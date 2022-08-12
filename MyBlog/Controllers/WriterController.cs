using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var WriterValues = wm.GetList();
            return View(WriterValues);
        }
    }
}