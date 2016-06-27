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
        public ActionResult Index()
        {
            var list = IoC.Resolve<IVehicleRepository<Vehicle>>().GetVehicleList();
            return View(list);
        }

        public ActionResult AddVehicle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddVehicle(Vehicle obj)
        {
            IoC.Resolve<IVehicleRepository<Vehicle>>().AddVehicle(obj);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult DeleteVehicle(int? id)
        {
            var entity = IoC.Resolve<IVehicleRepository<Vehicle>>().GetById(id.Value);
            IoC.Resolve<IVehicleRepository<Vehicle>>().DeleteVehicle(entity);
            return RedirectToAction("Index", "Home");
        }
    }
}