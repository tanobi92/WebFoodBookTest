using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFoodbook.Models
{
    public class Common
    {

    }

    public class Categories
    {
        public string Title { get; set; }
        public IEnumerable<ListCategories> ListCategorieses { get; set; }
    }

    public class ListCategories
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public string Url { get; set; }
    }
}