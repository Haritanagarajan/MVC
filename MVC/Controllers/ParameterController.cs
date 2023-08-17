using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC.Controllers
{
    public class ParameterController : Controller
    {

        static IList<Details> trainee = new List<Details>
        {
            new Details() {Id = 101 , Name = "Harita" , Role = "Trainee"},
            new Details() {Id = 101 , Name = "Trainee" ,Role = "Trainee"}

        };
        static IList<Details> trainer = new List<Details>
        {
          new Details() {Id = 101 , Name = "Trainer" , Role = "Trainer" }
        };
        // GET: Parameter

        //question 1 parameterized 
        public ActionResult Index(int? id)
        {
            if (id == 1)
            {
                return View(trainee);
            }
            else if (id == 2)
            {
                return View(trainer);
            }
            else
            {
                return Content("NO DETAILS :(");
            }
        }
        //question 2 json data
        public JsonResult jsonExample()
        {
            var jsonresult = Json(trainee, "application/json ", System.Text.Encoding.UTF8, JsonRequestBehavior.AllowGet);
            jsonresult.MaxJsonLength = int.MaxValue;
            return jsonresult;
        }

        //question 3 Files
        public FileResult FileExample()
        {
            return File(Url.Content("~/File/FileContent.docx"), "text/plain");
        }

        //question 4 javascriptresult

        public JavaScriptResult Jsexample()
        {
            int birthYear = 2000;
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;
            var agecalculator = "alert('Age Calculator example');";
            return new JavaScriptResult() { Script = agecalculator };
        }

        public ActionResult Js1()
        {
      
            return View();
        }

       
    }
}