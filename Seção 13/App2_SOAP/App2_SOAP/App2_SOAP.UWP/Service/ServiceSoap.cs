using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(App2_SOAP.UWP.Service.ServiceSoap))]
namespace App2_SOAP.UWP.Service
{
    public class ServiceSoap : IServiceSoap
    {
        public string Somar(int num1, int num2)
        {
            var serv = new ServicoWS.CalculatorSoapClient();
            var resultado = serv.AddAsync(num1, num2).GetAwaiter().GetResult();

            return "resulta WS SOAP: " + resultado;
        }
    }
}
