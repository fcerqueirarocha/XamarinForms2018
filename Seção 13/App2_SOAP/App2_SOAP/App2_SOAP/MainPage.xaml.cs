using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2_SOAP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void EnviarSoap(object sender, EventArgs e)
        {
            var Num1T = Num1.Text;
            var Num2T = Num2.Text;

            TxtResultado.Text = DependencyService.Get<IServiceSoap>().Somar(int.Parse(Num1T), int.Parse(Num2T));

        }
    }
}
