using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(App2_SOAP.iOS.Service.ServiceSoap))]
namespace App2_SOAP.iOS.Service
{
    public class ServiceSoap : IServiceSoap
    {
        public string Somar(int num1, int num2)
        {
            var serv = new com.dneonline.www.Calculator();
            var resultado = serv.Add(num1, num2);

            return "resulta WS SOAP" + resultado;
        }
    }
}