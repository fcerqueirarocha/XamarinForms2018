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
	public partial class ImageCellPage : ContentPage
	{
		public ImageCellPage ()
		{
			InitializeComponent ();

            List<Funcionario> listaFunc = new List<Funcionario>();
            listaFunc.Add(new Funcionario() { Foto= "https://i1.rgstatic.net/ii/profile.image/500939821334528-1496444768635_Q64/Francisco_Holanda4.jpg", Nome = "jose", Cargo = "motorista" });
            listaFunc.Add(new Funcionario() { Foto = "https://i1.rgstatic.net/ii/profile.image/500939821334528-1496444768635_Q64/Francisco_Holanda4.jpg", Nome = "pedro", Cargo = "presidente" });
            listaFunc.Add(new Funcionario() { Foto = "https://i1.rgstatic.net/ii/profile.image/500939821334528-1496444768635_Q64/Francisco_Holanda4.jpg", Nome = "mario", Cargo = "gerente de vendas" });
            listaFunc.Add(new Funcionario() { Foto = "https://i1.rgstatic.net/ii/profile.image/500939821334528-1496444768635_Q64/Francisco_Holanda4.jpg", Nome = "antonio", Cargo = "promotora" });
            listaFunc.Add(new Funcionario() { Foto = "https://www.contabeis.com.br/Arquivar/_resources/newsimages/740b273f95e5e5f969e24c893915e96b.jpg", Nome = "maria", Cargo = "diretora" });

            ListaFuncionarioImage.ItemsSource = listaFunc;
        }
	}
}