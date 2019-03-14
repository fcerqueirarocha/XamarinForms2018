using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App01_ControleXF.Modelo;

namespace App01_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();
            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(new Pessoa { Nome = "jose", Idade = "20" });
            lista.Add(new Pessoa { Nome = "pedro", Idade = "20" });
            lista.Add(new Pessoa { Nome = "roselle", Idade = "20" });
            lista.Add(new Pessoa { Nome = "paulo", Idade = "20" });
            lista.Add(new Pessoa { Nome = "isa", Idade = "20" });

            ListaPessoas.ItemsSource = lista;
		}
	}
}