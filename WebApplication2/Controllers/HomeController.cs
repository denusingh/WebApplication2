using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        Housing_DatabaseEntities db = new Housing_DatabaseEntities();
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public ActionResult Create(Product newDatatoInsert)
        {

            Product dta = new Product();
            dta.Name = newDatatoInsert.Name;
            dta.Price = newDatatoInsert.Price;
            db.Products.Add(dta);
            db.SaveChanges();
            return View();
        }
        public ActionResult Edit(int editTheData)
        {
            var newdta = db.Products.Where(x => x.ID == editTheData).First();
            return View();
        }
        public ActionResult Delete(int id)
        {
            var item = db.Products.Where(x => x.ID == id).First();
            db.Products.Remove(item);
            db.SaveChanges();
            var item2 = db.Products.ToList();
            return View("Index",item2);
        }

            public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Customerss()
        {
            return View();
        }

        public ActionResult Saless()
        {
            return View();
        }

    }
}