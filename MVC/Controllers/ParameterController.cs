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
        //trainee view
        public ActionResult TraineeView()
        {
            return View(trainee);
        }
        //trainer view
        public ActionResult TrainerView()
        {
            return View(trainer);
        }
        //details of trainee
        static IList<Details> trainee = new List<Details>
        {
            new Details() {Id = 101 , Name = "Harita" , Role = "Trainee"},
            new Details() {Id = 101 , Name = "Trainee" ,Role = "Trainee"}

        };
        //details of trainer
        static IList<Details1> trainer = new List<Details1>
        {
          new Details1() {Id = 101 , Name = "Thangam Mam" , Role = "Trainer" },
          new Details1() {Id = 102 , Name = "Pallavi Mam" , Role = "Trainer" }

        };

        // GET: Parameter

        //question 1 parameterized 
        public ActionResult Index(int? id)
        {
            if (id == 1)
            {
                return RedirectToAction("TraineeView","Parameter");
            }
            else if (id == 2)
            {
                return RedirectToAction("TrainerView", "Parameter");
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

        public ActionResult AgeView(AgeCalculation ag)
        {
           
                return View("AgeView", ag);
           
        }

       
    }
}