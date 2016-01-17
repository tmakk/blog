using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weblog.Models
{
    public class ResentDateModel
    {
        public ResentDateModel ()
        {
            Items = new Collection<ResentDateItemModel>();
            Items.Add(new ResentDateItemModel () );
            Items.Add(new ResentDateItemModel());
            Items.Add(new ResentDateItemModel());
        }
        public ICollection<ResentDateItemModel> Items { get; set; }
    }
} 