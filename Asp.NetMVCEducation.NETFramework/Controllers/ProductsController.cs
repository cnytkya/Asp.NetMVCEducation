using Asp.NetMVCEducation.NETFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.NetMVCEducation.NETFramework.Controllers
{
    public class ProductsController : Controller
    {
        
        DatabaseContext context = new DatabaseContext();
        // GET: Products
        public ActionResult Index(int? id)
        {
            if (id != null)
            {
                return View(context.Products.Where(product => product.CategoryId == id).ToList()); // ürünlerden kategori ıd si adres çubuğundan gönderilen id ye eşit olanları bul ve ekrana gönder
            }
            return View(context.Products.ToList());
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            return View(context.Products.Find(id));
        }
    }
}