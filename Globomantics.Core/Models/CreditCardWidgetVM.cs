using System;
using System.Collections.Generic;
using System.Text;

namespace Globomantics.Core.Models
{
    public class CreditCardWidgetVM
    {
        public string WidgetTitle { get; set; }
        public string WidgetSubTitle { get; set; }
        public List<Rate> Rates { get; set; }
    }
}
