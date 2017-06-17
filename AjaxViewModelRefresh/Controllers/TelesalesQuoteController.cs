using AjaxViewModelRefresh.Models;
using AjaxViewModelRefresh.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxViewModelRefresh.Controllers
{
    public class TelesalesQuoteController : Controller
    {
        // GET: TelesalesQuote
        public ActionResult TelesalesQuote()
        {
            TelesalesQuoteViewModel vm = new TelesalesQuoteViewModel()
            {
                Customer = new Customer()
            };

            vm.Customer.Id = 101;
            vm.Customer.FirstName = "Boris";
            vm.Customer.Surname = "Johnson";

            return View(vm);
        }

        public ActionResult UpdateViewModel (TelesalesQuoteViewModel vm)
        {
            vm.DualFuel = true;
            vm.SupplierName = "British Gas";
            vm.TariffName = "Standard";
            return PartialView("TariffTable", vm);
        }
    }
}