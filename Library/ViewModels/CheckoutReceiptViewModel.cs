using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.ViewModels
{
    public class CheckoutReceiptViewModel
    {
        public DateTime? DuebackDate{ get; set; }
        public string Message { get; set; }
    }
}