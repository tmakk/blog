using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weblog.Models
{
    public class CommentItemModel
    { public CommentItemModel()
        {
            UserName = "динамич имя";
            Body = "Динам Ком";
            Date = DateTime.Now;
        }
        public string UserName { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
    }
}