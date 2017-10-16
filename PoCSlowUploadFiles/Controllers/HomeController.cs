using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PoCSlowUploadFiles.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        //[Route("uploadimage")]
        public ActionResult UploadImage()
        {
            HttpPostedFile image = System.Web.HttpContext.Current.Request.Files["HelpSectionImages"];
            var itemId = System.Web.HttpContext.Current.Request.Form["itemId"];

            var tempImage = new
            {
                name = "name",
                url = "urlImageTemp"
            };

            return Json(tempImage);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}