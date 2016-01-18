using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Weblog.Controllers
{ [RoutePrefix("Comment")]
    public class CommentController : Controller
    {
        // GET: Comment
        [Route("Resent")]
        public ActionResult Resent()
        {
            var model = new Models.ResentDateModel();
            return View(model);
        }
       // [Route("ById/{id}")]
    //    public ContentResult ByID(int id)
      //  {
       //     return ContentResult () { Content="This is comm #"+ id};
     //   }
    }

}