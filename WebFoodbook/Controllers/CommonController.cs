using System;
using System.Collections.Generic;
using System.Linq;
//using System.Net.Mime.MediaTypeNames;
using System.Web;
using System.Web.Mvc;
using WebFoodbook.Models;

namespace WebFoodbook.Controllers
{
    public class CommonController : Controller
    {
        
        // GET: Common
        public ActionResult ListCategories()
        {
            //List<String> listCategories = new List<String>
            //{
            //    "/Images/restaurant/1.jpg",
            //    "/Images/restaurant/2.jpg",
            //    "/Images/restaurant/3.jpg",
            //    "/Images/restaurant/4.jpg",
            //    "/Images/restaurant/5.jpg",
            //    "/Images/restaurant/6.jpg"
            //};
            List<SelectListItem> listCategories = new List<SelectListItem>();
            listCategories.Add(new SelectListItem { Text="Hải sản|123", Value = "/Images/restaurant/1.jpg" });
            listCategories.Add(new SelectListItem { Text = "Buffets|93", Value = "/Images/restaurant/2.jpg" });
            listCategories.Add(new SelectListItem { Text = "Nhà hàng|321", Value = "/Images/restaurant/3.jpg" });
            listCategories.Add(new SelectListItem { Text = "Lẩu|45", Value = "/Images/restaurant/4.jpg" });
            listCategories.Add(new SelectListItem { Text = "Quán nước|82", Value = "/Images/restaurant/5.jpg" });
            listCategories.Add(new SelectListItem { Text = "Chè|31", Value = "/Images/restaurant/6.jpg" });
            ViewBag.Title = "Categories";
            ViewBag.ListCategories = listCategories;
            //ViewBag.List = list2.ToList();
            return View();
        }
    }
}