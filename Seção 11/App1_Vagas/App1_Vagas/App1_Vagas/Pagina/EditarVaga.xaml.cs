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
	public partial class EditarVaga : ContentPage
	{
        private Vaga vaga { get; set; }

		public EditarVaga (Vaga vaga = null)
		{
			InitializeComponent ();
            if (vaga != null)
            {
                this.vaga = vaga;
                VagaNome.Text = this.vaga.NomeVaga;
                Empreza.Text = this.vaga.Empresa;
                Quantidade.Text = this.vaga.Quantidade.ToString();
                Cidade.Text = this.vaga.Cidade;
                Salario.Text = this.vaga.Salario.ToString();
                Descricao.Text = this.vaga.Descricao;
                TipoContratacao.IsToggled = this.vaga.TipoContratacao == "CLT" ? false : true;
                Telefone.Text = this.vaga.Telefone;
                Email.Text = this.vaga.Email;
            }
		}

        private void GoSalvar(object sender, EventArgs e)
        {
            //obter os dados da tela
            //TODO - Obter datdo da tela
            this.vaga.NomeVaga = VagaNome.Text;
            this.vaga.Quantidade = short.Parse(Quantidade.Text);
            this.vaga.Empresa = Empreza.Text;
            this.vaga.Cidade = Cidade.Text;
            this.vaga.Salario = double.Parse(Salario.Text);
            this.vaga.Descricao = Descricao.Text;
            this.vaga.TipoContratacao = TipoContratacao.IsToggled ? "PJ" : "CLT";
            this.vaga.Telefone = Telefone.Text;
            this.vaga.Email = Email.Text;
            //actualizar no banco
            DataBase data = new DataBase();
            data.Atualizacao(vaga);
            //redirecionar para minhasr vagas
            App.Current.MainPage = new NavigationPage(new MinhasVagasCadastradas());
        }
    }
}