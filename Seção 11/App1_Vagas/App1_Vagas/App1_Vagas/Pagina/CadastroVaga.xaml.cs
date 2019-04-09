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
	public partial class CadastroVaga : ContentPage
	{
		public CadastroVaga ()
		{
			InitializeComponent ();

           
		}

        private void GoSalvar(object sender, EventArgs e)
        {
            //TODO - Obter datdo da tela
            Vaga vaga = new Vaga();
            vaga.NomeVaga = VagaNome.Text;
            vaga.Quantidade = short.Parse(Quantidade.Text);
            vaga.Empresa = Empreza.Text;
            vaga.Cidade = Cidade.Text;
            vaga.Salario = double.Parse(Salario.Text);
            vaga.Descricao = Descricao.Text;
            vaga.TipoContratacao = TipoContratacao.IsToggled ? "PJ" : "CLT";
            vaga.Telefone = Telefone.Text;
            vaga.Email = Email.Text;

            DataBase dataBase = new DataBase();
            dataBase.Cadastro(vaga);

            App.Current.MainPage = new NavigationPage(new ConsultaVagas());
            //Navigation.PopAsync(); //retorna para tela anterior
        }
    }
}