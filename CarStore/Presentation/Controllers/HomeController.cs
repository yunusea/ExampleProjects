using Business;
using Contracts.Repository;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        CarStoreBusiness business = new CarStoreBusiness();
        public ActionResult Index()
        {
            var list = business.GetList();
            return View(list);
        }

        public ActionResult AddVehicle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddVehicle(Vehicle obj)
        {
            business.AddVehicle(obj);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult DeleteVehicle(int? id)
        {
            business.DeleteVehicle(id.Value);
            return RedirectToAction("Index", "Home");
        }
    }
}