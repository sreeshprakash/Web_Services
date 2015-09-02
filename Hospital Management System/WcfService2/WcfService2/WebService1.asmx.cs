using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WcfService2
{
    public class WebService1 : System.Web.Services.WebService
    {
        [System.Web.Services.WebMethod()]
        public double FahrenheitToCelsius(double Fahrenheit)
        {
            return ((Fahrenheit - 32) * 5) / 9;
        }

        [System.Web.Services.WebMethod()]
        public double CelsiusToFahrenheit(double Celsius)
        {
            return ((Celsius * 9) / 5) + 32;
        }
    }
}
