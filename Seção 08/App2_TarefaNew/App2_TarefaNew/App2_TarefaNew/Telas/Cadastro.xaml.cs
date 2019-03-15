using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2_TarefaNew.Modelos;

namespace App2_TarefaNew.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cadastro : ContentPage
	{
        private byte Prioridade { get; set; }
		public Cadastro ()
		{
			InitializeComponent ();
		}

        public void PrioridadeSelectAction(object sender, EventArgs e)
        {
            var Stacks = SLPrioridades.Children;
            foreach(var Linha in Stacks)
            {
                Label LblPrioridade = ((Label)((StackLayout)Linha).Children[1]);
                LblPrioridade.TextColor = Color.Gray;
            }
            ((Label)((StackLayout)sender).Children[1]).TextColor = Color.Black;
            FileImageSource Source = ((Image)((StackLayout)sender).Children[0]).Source as FileImageSource;
            
            String Prioridade = Source.File.Substring((Source.File.Length - 5), 1);
            this.Prioridade = byte.Parse(Prioridade);
        }

        private void SalvarTarefa(object sender, EventArgs e)
        {
            bool ErroNome = (String.IsNullOrWhiteSpace(TxtNome.Text)) ? true : false;
            bool ErroPrio = (this.Prioridade > 0) ? false : true;

            if ((ErroNome) | (ErroPrio))
                DisplayAlert("ERRO","Faltando informações para cadastro!", "OK");
            else
            {
                Tarefa tarefa = new Tarefa();
                tarefa.Nome = TxtNome.Text;
                tarefa.Prioridade = this.Prioridade;

                new GerenciadorTarefa().Salvar(tarefa);
                TxtNome.Text = "";
                App.Current.MainPage = new NavigationPage(new Inicio());
            }

            
        }
    }
}