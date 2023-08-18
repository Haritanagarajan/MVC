using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        //ProductList
        static IList<ProductDetails> Listproduct = new List<ProductDetails>
        {
            new ProductDetails() {Id = 101 , Prodname = "Laysssss" ,ProPrice = 1900},
            new ProductDetails() {Id = 102 ,  Prodname = "Biscustss" ,ProPrice = 1200}

        };


        // GET: Product
        //display product details
        public ActionResult Index()
        {
            return View(Listproduct);
        }

        //create crud
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Prodname,Proprice")]ProductDetails pp)
        {
            if(ModelState.IsValid)
            {
                Listproduct.Add(pp);
                return RedirectToAction("Index");
            }
            return View();
        }

        //edit crud
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var edit1 = Listproduct.Where(x => x.Id == Id).FirstOrDefault();
            return View(edit1);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductDetails p)
        {
            var edit2 = Listproduct.Where(s=>s.Id==p.Id).FirstOrDefault();
            Listproduct.Remove(edit2);
            Listproduct.Add(p);
            return RedirectToAction("Index");
        }
        //update crud using Delete
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var del = Listproduct.Where(x=> x.Id ==Id).FirstOrDefault();
            Listproduct.Remove(del);
            return RedirectToAction("Index");
        }
        //Details in crud
        [HttpGet]
        public ActionResult Details(int Id)
        {
            var details = Listproduct.Where(d=> d.Id == Id).FirstOrDefault();
            return View(details);
        }
    }
}