using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Weblog.Controllers
{
    [RoutePrefix ("Post")]
    public class PostController : Controller
    {
        // GET: Comment
        [Route("Resent")]
        public ActionResult Resent()
        {
            var model = new Models.ResentDateModel();
            return View(model);
        }
    }
}