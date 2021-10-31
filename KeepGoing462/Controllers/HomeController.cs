using KeepGoing462.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace KeepGoing462.Controllers
{
    public class HomeController : Controller
    {
        //private MVC5Entities _db = new MVC5Entities();
        //private SchoolContext db = new SchoolContext();
        private ApplicationDbContext _db = new ApplicationDbContext();
        public ActionResult Index()
        {
           var data = (from s in _db.Users select s).ToList();
            ViewBag.users = data;
            ViewBag.Count = data.Count;
            ViewBag.title = "MVC5 - Hello World";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            
            return View();
        }
        [Authorize(Roles = "ADMIN")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}