using Globomantics.Core.Models;
using Globomantics.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Globomantics.Components
{
    public class CreditCardRatesViewComponent : ViewComponent
    {
        private readonly IRateService rateService;

        public CreditCardRatesViewComponent(IRateService rateService)
        {
            this.rateService = rateService;
        }

        public async Task<IViewComponentResult> InvokeAsyc(
            string title, string subTitle)
        {
            var ratesVM = new CreditCardWidgetVM()
            {
                Rates = rateService.GetCreditCardRates(),
                WidgetTitle = title,
                WidgetSubTitle = subTitle
            };

            return View(ratesVM);
        }
        
    }

}
