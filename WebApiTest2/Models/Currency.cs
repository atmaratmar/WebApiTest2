using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiTest2.Models
{
    public class Currency
    {
        public decimal ExchangeRate { get; set; }
        public string ISO { get; set; }
        public string Name { get; set; }
    }
}