using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiTest2.Models;

namespace WebApiTest2.DAL
{
    public class CurrencyRepository
    {
        List<Currency> currency;
        #region
        //public CurrencyRepository()
        //{
        //    currency = new List<Currency>();
        //    currency.Add(new Currency
        //    { Name = "Europe", ISO = "EUR", ExchangeRate = 745.99M });
        //    currency.Add(new Currency
        //    { Name = "Amerika", ISO = "USA", ExchangeRate = 524.02M });
        //    currency.Add(new Currency
        //    { Name = "Canada", ISO = "CAD", ExchangeRate = 492.2700M });
        //    currency.Add(new Currency
        //    { Name = "Norge", ISO = "NOK", ExchangeRate = 90.3400M });
        //    currency.Add(new Currency
        //    { Name = "Storbritannien", ISO = "GBP", ExchangeRate = 947.5300M });
        //    currency.Add(new Currency
        //    { Name = "Sverige", ISO = "SEK", ExchangeRate = 78.2100M });
        //}
#endregion

        public List<Currency> GetList()
        {
            currency = new List<Currency>();
            currency.Add(new Currency
            { Name = "Europe", ISO = "EUR", ExchangeRate = 745.99M });
            currency.Add(new Currency
            { Name = "Amerika", ISO = "USA", ExchangeRate = 524.02M });
            currency.Add(new Currency
            { Name = "Canada", ISO = "CAD", ExchangeRate = 492.2700M });
            currency.Add(new Currency
            { Name = "Norge", ISO = "NOK", ExchangeRate = 90.3400M });
            currency.Add(new Currency
            { Name = "Storbritannien", ISO = "GBP", ExchangeRate = 947.5300M });
            currency.Add(new Currency
            { Name = "Sverige", ISO = "SEK", ExchangeRate = 78.2100M });
            return currency;
        }

    }
}