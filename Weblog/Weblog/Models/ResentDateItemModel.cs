using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weblog.Models
{
    public class ResentDateItemModel
    {
        public ResentDateItemModel()
        {
            text = "text";
            URL = "http://yandex.ru";
            Date = DateTime.Now.AddDays(-1);

        }
        public string text { get; set; }
        public string URL { get; set; }
        public DateTime Date { get; set; }
    }
}