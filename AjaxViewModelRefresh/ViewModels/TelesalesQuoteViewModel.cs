using AjaxViewModelRefresh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxViewModelRefresh.ViewModels
{
    public class TelesalesQuoteViewModel
    {
        public Customer Customer { get; set; }

        public bool DualFuel { get; set; }

        public String SupplierName { get; set; } 

        public String TariffName { get; set; }
    }
}