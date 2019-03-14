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
	public partial class DatePikerPage : ContentPage
	{
		public DatePikerPage ()
		{
			InitializeComponent ();
		}
        private void ActionDateSelected(object sender, DateChangedEventArgs args)
        {
            lblResultado.Text = "data anterior " + args.OldDate.ToString("dd/MM/yyyy") + " - data nova " + args.NewDate.ToString("dd/MM/yyyy");
        }

    }
}