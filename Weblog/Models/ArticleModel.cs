using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Weblog.Models
{
    public class ArticleModel
    {
        public ArticleModel()
        {
            Title = "динамический заголовок";
            Body = "<p> динамический текст</p>";
            Date = DateTime.Now;
            Comments = new Collection<CommentItemModel>();
        }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
        public ICollection<CommentItemModel> Comments { get; set; }
    }
}