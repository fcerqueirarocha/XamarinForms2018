using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App3_JWTAsync.Service;
using App3_JWTAsync.Model;

namespace App3_JWTAsync
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void GetTokenAction(object sender, EventArgs e)
        {
            LblToken.Text = await JWTService.GetToken(nome.Text, password.Text);
        }

        private async void VerificarAction(object sender, EventArgs e)
        {
            LblResultado.Text = await JWTService.GetToken(nome.Text, password.Text);

        }
    }
}
