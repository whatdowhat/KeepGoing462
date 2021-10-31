using KeepGoing462.Models;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;
using System.Web.Security;

namespace KeepGoing462.Controllers
{
    public class MigrationController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index() 
        {

            //return View();
            return View("~/Views/Migration/Index.cshtml");
        }

        public ActionResult GetMessage()
        {
            Roles.CreateRole("ADMINISTRATOR");
            
            string message = "Welcome";
            return new JsonResult { Data = message, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}