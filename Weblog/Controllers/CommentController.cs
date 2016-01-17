using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Weblog.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        public ActionResult Resent()
        {
            var model = new Models.ResentDateModel();
            return View(model);
        }
    }
}