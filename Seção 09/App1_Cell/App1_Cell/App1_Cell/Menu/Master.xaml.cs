using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1_Cell.Pagina;

namespace App1_Cell.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void GoTextCell(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TextCellPage());
            IsPresented = false;
        }
        private void GoImageCell(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ImageCellPage());
            IsPresented = false;
        }
        private void GoEntryCell(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new EntryCellPage());
            IsPresented = false;
        }
         private void GoSwitchCell(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SwitchCellPage());
            IsPresented = false;
        }
        private void GoViewCell(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ViewCellPage());
            IsPresented = false;
        }
        private void GoListview(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ListViewPage());
            IsPresented = false;
        }
        private void GoListviewButton(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ListViewButtonPage());
            IsPresented = false;
        }

    }
}