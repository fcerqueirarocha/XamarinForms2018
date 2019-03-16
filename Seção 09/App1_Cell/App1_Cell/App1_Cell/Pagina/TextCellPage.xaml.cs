using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1_Cell.Modelo;

namespace App1_Cell.Pagina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TextCellPage : ContentPage
	{
		public TextCellPage ()
		{
			InitializeComponent ();

            List<Funcionario> listaFunc = new List<Funcionario>();
            listaFunc.Add(new Funcionario() { Nome = "jose", Cargo = "motorista" });
            listaFunc.Add(new Funcionario() { Nome = "pedro", Cargo = "presidente" });
            listaFunc.Add(new Funcionario() { Nome = "mario", Cargo = "gerente de vendas" });
            listaFunc.Add(new Funcionario() { Nome = "antonio", Cargo = "promotora" });
            listaFunc.Add(new Funcionario() { Nome = "maria", Cargo = "diretora" });

            ListaFuncionario.ItemsSource = listaFunc;
		}
	}
}