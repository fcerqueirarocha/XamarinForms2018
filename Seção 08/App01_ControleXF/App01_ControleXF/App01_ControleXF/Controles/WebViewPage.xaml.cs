using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebViewPage : ContentPage
	{
		public WebViewPage ()
		{
			InitializeComponent ();
		}

        
        private void goPagina(object sender, EventArgs e)
        {
            Navegador.Source = Enderecosit.Text;
        }
        private void goProximo(object sender, EventArgs e)
        {
            if (Navegador.CanGoForward)
            {
                Navegador.GoForward();
            }
        }

        private void goVoltar(object sender, EventArgs e)
        {
            if (Navegador.CanGoBack) Navegador.GoBack();
        }
        private void ActionCarregando(object sender, EventArgs e)
        {
            lblStatus.Text = "carrgando";
        }
        private void ActionCarregado(object sender, EventArgs e)
        {
            lblStatus.Text = "carrgado";
        }

        
            
    }
}