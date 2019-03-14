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
	public partial class TimePikerPage : ContentPage
	{
		public TimePikerPage ()
		{
			InitializeComponent ();

		}

        private void TimePicker_Unfocused(object sender, FocusEventArgs e)
        {
            lbltime.Text = tmHora.Time.ToString();
        }
    }
}