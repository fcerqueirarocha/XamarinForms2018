using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void GoActivityPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage( new Controles.ActivityIndicatorPage());
            IsPresented = false;
        }
        private void GoProgressBarPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.ProgressBarPage());
            IsPresented = false;
        }
        private void GoBoxViewPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.BoxViewPage());
            IsPresented = false;
        }
        private void GoLabePage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.LabelPage());
            IsPresented = false;
        }
        private void GoButtonPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.ButtonPage());
            IsPresented = false;
        }
        private void GoEntryEditorPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.EntryEditorPage());
            IsPresented = false;
        }
        private void GoDatePikerPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.DatePikerPage());
            IsPresented = false;
        }
        private void GoTimePikerPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.TimePikerPage());
            IsPresented = false;
        }
        private void GoPikerPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.PikerPage());
            IsPresented = false;
        }

        private void SearchBarPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.SearchBarPage());
            IsPresented = false;
        }
        private void SliderStepperPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.SliderStepperPage());
            IsPresented = false;
        }
        private void SwitchPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.SwitchPage());
            IsPresented = false;
        }
         private void ImagePage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.ImagePage());
            IsPresented = false;
        }
          private void ListViewPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.ListViewPage());
            IsPresented = false;
        }
        private void TableViewPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.TableViewPage());
            IsPresented = false;
        } private void WebViewPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Controles.WebViewPage());
            IsPresented = false;
        }

    }
}