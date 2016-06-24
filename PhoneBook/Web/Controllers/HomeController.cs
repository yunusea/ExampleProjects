using Contracts.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.ViewModel;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        //private IPhoneBookRepository _phoneBookRepository;

        //public HomeController(IPhoneBookRepository PhoneBookRepository)
        //{
        //    _phoneBookRepository = PhoneBookRepository;
        //}

        // GET: Home
        public ActionResult Index()
        {
            var list = IoC.Resolve<IPhoneBookRepository>().GetPhoneNumberList();

            var ViewModel = new HomeViewModel()
            {
                PhoneBookList = list
            };
            return View(ViewModel);
        }

        [HttpPost]
        public ActionResult PhoneNumberAdd(HomeViewModel ViewModel)
        {
            IoC.Resolve<IPhoneBookRepository>().AddPhoneNumber(ViewModel.PhoneNumber);
            return RedirectToAction("Index", "Home");
        }
    }
}