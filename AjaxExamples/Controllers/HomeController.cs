using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using AjaxExamples.AKservice;


namespace AjaxExamples.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        AKservice.IAKservice bilFac = new AKserviceClient();

        public ActionResult Index()
        {
            List<AKservice.Bil> modelBil = bilFac.HentAlleBiler().ToList();

            return View(modelBil);
        }

        public ActionResult OpretBil()
        {
            AKservice.Bil b = new Bil();
            b.Model = "Zafira";
            b.Beskrivelse = "tekst";
            b.Pris = 123;
            b.ProducentID = 40;

            bilFac.OpretBil(b);

            return View();
        }
    }
}