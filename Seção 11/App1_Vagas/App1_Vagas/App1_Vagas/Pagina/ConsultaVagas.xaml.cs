using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1_Vagas.Modelos;
using App1_Vagas.Banco;

namespace App1_Vagas.Pagina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConsultaVagas : ContentPage
	{
        private List<Vaga> lista;
        public ConsultaVagas ()
		{
			InitializeComponent ();
            DataBase data = new DataBase();
            lista = data.Consultar();
            ListaVagas.ItemsSource = lista;
            lblCout.Text = lista.Count().ToString();
            
        }

        private void GoCadastro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroVaga());
        }

        private void GoMinhasVagas(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MinhasVagasCadastradas());
        }

        private void MaisDetalheAction(object sender, EventArgs e)
        {
            Label lblDetalhe = (Label)sender;
            Vaga vaga = ((TapGestureRecognizer)lblDetalhe.GestureRecognizers[0]).CommandParameter as Vaga;

            Navigation.PushAsync(new DetalheVaga(vaga));
        }

        private void Pesquisar(object sender, TextChangedEventArgs e)
        {
            ListaVagas.ItemsSource = lista.Where(a => a.NomeVaga.Contains(e.NewTextValue)).ToList();
            
        }
    }
}