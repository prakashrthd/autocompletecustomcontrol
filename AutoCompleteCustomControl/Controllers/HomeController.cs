using AutoCompleteCustomControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoCompleteCustomControl.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var patient = new Patient { PatientId = 1, PatientName = "Prakash"};
            return View(patient);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AutoComplete()
        {
            var patient = new Patient { PatientId = 1, PatientName = "Prakash" };
            return View(patient);
        }

        public ActionResult GetPatients(string searchHint)
        {
            return Json(Patient.GetPatients(searchHint), JsonRequestBehavior.AllowGet);
        }
        // GET: /AutoComplete/
        public ActionResult GetLabs(string searchHint)
        {
            return Json(Lab.GetLabs(searchHint), JsonRequestBehavior.AllowGet);
        }
        // GET: /AutoComplete/
        public ActionResult GetGeneralItems(string searchHint)
        {
            return Json(Patient.GetPatients(searchHint), JsonRequestBehavior.AllowGet);
        }
    }
}