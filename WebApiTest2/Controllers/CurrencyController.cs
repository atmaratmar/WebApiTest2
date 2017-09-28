using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTest2.Models;
using WebApiTest2.DAL;

namespace WebApiTest2.Controllers
{
    public class CurrencyController : ApiController
    {
        
       
        // GET: api/Currency
        public IEnumerable<Currency> Get()
        {
            CurrencyRepository c = new CurrencyRepository();
            List<Currency> getcurrency = c.GetList();
            return getcurrency;
            

            
        }


        // GET: api/Currency/5
        [HttpGet]
        public decimal ConvertCurrency(string toISO, decimal value)
        {
            decimal convertedValue=0.0M;
            #region   
            //Currency c = new Currency
            //{
            //    Name = "Europe",
            //    ISO = "EUR",
            //    ExchangeRate = 745.99M  

            //};
#endregion
            CurrencyRepository c = new CurrencyRepository();
            List<Currency> getcurrency = c.GetList();
            foreach (var item in getcurrency)
            {
                if (toISO == item.ISO)
                {
                    convertedValue = value / item.ExchangeRate;
                }
            }
           
            return convertedValue;

        }

        // POST: api/Currency
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Currency/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Currency/5
        public void Delete(int id)
        {
        }
    }
}
