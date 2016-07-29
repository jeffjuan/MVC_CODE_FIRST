using MVCCodeFirstSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodeFirstSample.Controllers
{
    public class ODController : Controller
    {
        private ODService _service = null;

        public ODService Service
        {
            get
            {
                return _service ?? new ODService();
            }
        }

        public ActionResult Index()
        {
           var data = Service.GetAll();
            return View(data);
        }
    }
}