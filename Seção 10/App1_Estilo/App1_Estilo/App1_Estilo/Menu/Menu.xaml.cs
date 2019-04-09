using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Estilo.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : MasterDetailPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}

        private void GoPagina1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new App1_Estilo.Pagina.ImplicitStylePage());
        }

        private void GoPagina2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new App1_Estilo.Pagina.ExplicitStylePage());
        }
        private void GoPagina3(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new App1_Estilo.Pagina.GlobalStylePage());
        }
        private void GoPagina4(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new App1_Estilo.Pagina.InheiritStylePage());
        }
        private void GoPagina5(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new App1_Estilo.Pagina.DynamicStylePage());
        }

    }
}