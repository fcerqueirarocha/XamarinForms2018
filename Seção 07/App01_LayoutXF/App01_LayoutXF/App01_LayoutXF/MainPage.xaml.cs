using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App01_LayoutXF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoPaginaStack(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Stack.StackPage());
        }
        private void GoPaginaGrid(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Grid.GridPage());
        }
        private void GoPaginaAbsolute(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Absolute.AbsolutePage());
        }
        private void GoPaginaRelative(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Relative.RelativePage());
        }
        private void GoPaginaScroll(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Scroll.ScrollPage());
        }
    }
}
