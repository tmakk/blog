using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Weblog.Models;
//using Weblog.Models.Binders;
//using Weblog.Repository;


namespace Weblog.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult AddComment(AddCommentsModel model)
        {
            return RedirectToAction("index", "Home");
        }

        // GET: Home
        public ActionResult Index()
        {
            var model = new ArticleModel();
           
            return View(model);
        }
    }
}