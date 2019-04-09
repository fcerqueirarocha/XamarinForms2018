using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1_Vagas.Banco;
using App1_Vagas.Modelos;

namespace App1_Vagas.Pagina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MinhasVagasCadastradas : ContentPage
	{
        private List<Vaga> lista;

        public MinhasVagasCadastradas ()
		{
			InitializeComponent ();
            Atualizar();
        }

        private void Atualizar()
        {
            DataBase data = new DataBase();
            lista = data.Consultar();
            ListaVagas.ItemsSource = lista;
            lblCout.Text = lista.Count().ToString();
        }
        private void EditarAction(object sender, EventArgs e)
        {
            Label lblEditar = (Label)sender;
            Vaga vaga = ((TapGestureRecognizer)lblEditar.GestureRecognizers[0]).CommandParameter as Vaga;

            Navigation.PushAsync(new EditarVaga(vaga));

        }

        private void ExcluirAction(object sender, EventArgs e)
        {
            Label lblExcluir = (Label)sender;
            Vaga vaga = ((TapGestureRecognizer)lblExcluir.GestureRecognizers[0]).CommandParameter as Vaga;

            DataBase data = new DataBase();
            data.Exclusao(vaga);
            Atualizar();
        }
    }
}