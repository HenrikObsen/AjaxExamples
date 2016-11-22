using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoMZ;

namespace AjaxExamples.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        IndholdFac inf = new IndholdFac();
        public ActionResult HentInformation()
        {
            return View("Index", inf.Get(2));
        }

        public ActionResult Index(int id)
        {
            return View(inf.Get(id));
        }
        public string FormaterSide(string overskrift, string tekst)
        {
            return "<h1>" + overskrift + "</h1>" + tekst;
        }

        public string HentDato()
        {
            return DateTime.Now.ToLongDateString();
        }
        public ActionResult HentSide(int id)
        {
            return Json(inf.Get(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult HentSider()
        {
            return Json(inf.GetAll(), JsonRequestBehavior.AllowGet);
        }


        public ActionResult NySide(Indhold indhold)
        {
            int ID = inf.Insert(indhold);
            return Json(inf.Get(ID), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Slet()
        {
            return View(inf.GetAll());
        }

        public void SletResult(int id)
        {
            inf.Delete(id);
        }


    }
}