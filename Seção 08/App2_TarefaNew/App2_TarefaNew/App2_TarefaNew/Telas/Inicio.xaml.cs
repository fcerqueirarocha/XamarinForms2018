using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2_TarefaNew.Modelos;
using System.Globalization;

namespace App2_TarefaNew.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Inicio : ContentPage
	{
		public Inicio ()
		{
			InitializeComponent ();

            //tradução de linguagem 
            CultureInfo culture = new CultureInfo("pt-BR");
            string data = DateTime.Now.ToString("dddd, dd {0} MMMM {0} yyyy", culture);

            DataHoje.Text = string.Format(data, "de");
            CarregarTarefa();
		}
        private void ActionGoCadastro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cadastro());
        }

        public void LinhaStackLayout(Tarefa tarefa, int indice)
        {//metodo para criar linhas

            //+++++++++++++++++++++++++
            // INICIO imagem DELETE
            //+++++++++++++++++++++++++
            Image Delete = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("Delete.png") };
            if (Device.RuntimePlatform == Device.UWP)
                Delete.Source = ImageSource.FromFile("Resources/Delete.png");

            //INICIO *******COLOCANDO O CLICK NA IMAGEM QUE É TRATADO COMO GESTO
            TapGestureRecognizer DeleteTap = new TapGestureRecognizer();
            //usando delegate
            DeleteTap.Tapped += delegate
            {
                new GerenciadorTarefa().Remover(indice);
                CarregarTarefa();
            };
            //fim delegate
            Delete.GestureRecognizers.Add(DeleteTap);
            //FIM *******COLOCANDO O CLICK NA IMAGEM QUE É TRATADO COMO GESTO
            //+++++++++++++++++++++++++
            // FIM   imagem DELETE
            //+++++++++++++++++++++++++

            //+++++++++++++++++++++++++
            // INICIO imagem PRIORIDADE
            //+++++++++++++++++++++++++
            Image Prioridade = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("p" + tarefa.Prioridade +".png") };
            if (Device.RuntimePlatform == Device.UWP)
                Prioridade.Source = ImageSource.FromFile("Resources/p" + tarefa.Prioridade +".png");

            View StackCentral = null;
            if(tarefa.DataFinalizacao == null)
            {
                StackCentral = new Label() { VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.FillAndExpand, Text = tarefa.Nome };
            }
            else
            { 
                StackCentral = new StackLayout() { VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.FillAndExpand, Spacing = 0 };
                ((StackLayout)StackCentral).Children.Add(new Label() { Text = tarefa.Nome, TextColor = Color.Gray });

                ((StackLayout)StackCentral).Children.Add(new Label() { Text = "Finalizado em " + tarefa.DataFinalizacao.Value.ToString("dd/MM/yyyy - hh:mm") + "h", TextColor = Color.Gray, FontSize=10 });
            }

            //+++++++++++++++++++++++++
            // FIM   imagem PRIORIDADE
            //+++++++++++++++++++++++++
            //+++++++++++++++++++++++++
            // INICIO imagem CHECK
            //+++++++++++++++++++++++++
            Image check = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("CheckOff.png") };
            if (Device.RuntimePlatform == Device.UWP)
                check.Source = ImageSource.FromFile("Resources/CheckOff.png");

            if (tarefa.DataFinalizacao != null) //data de fim preenchida
            {
                check.Source = ImageSource.FromFile("CheckOn.png");
                if (Device.RuntimePlatform == Device.UWP)
                    check.Source = ImageSource.FromFile("Resources/CheckOn.png");
            }

            //INICIO *******COLOCANDO O CLICK NA IMAGEM QUE É TRATADO COMO GESTO
            TapGestureRecognizer CheckTap = new TapGestureRecognizer();
            //usando delegate
            CheckTap.Tapped += delegate
            {
                new GerenciadorTarefa().Finalizar(indice, tarefa);
                CarregarTarefa();
            };
            //fim delegate
            check.GestureRecognizers.Add(CheckTap);
            //FIM *******COLOCANDO O CLICK NA IMAGEM QUE É TRATADO COMO GESTO
            //+++++++++++++++++++++++++
            // FIM   imagem CHECK
            //+++++++++++++++++++++++++
            StackLayout linha = new StackLayout() { Orientation = StackOrientation.Horizontal, Spacing = 15 };
            linha.Children.Add(check);
            linha.Children.Add(StackCentral);
            linha.Children.Add(Prioridade);
            linha.Children.Add(Delete);

            SLTarefas.Children.Add(linha);
        }
        private void CarregarTarefa()
        {
            SLTarefas.Children.Clear();
            List<Tarefa> lista = new GerenciadorTarefa().Listagem();
            int i = 0;
            foreach (Tarefa tarefa in lista)
            {
                LinhaStackLayout(tarefa,i);
                i++;
            }
        }

    }
}