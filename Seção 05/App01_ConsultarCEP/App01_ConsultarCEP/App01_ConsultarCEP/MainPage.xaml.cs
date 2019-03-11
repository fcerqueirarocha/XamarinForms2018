using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCEP.Servico;
using App01_ConsultarCEP.Servico.Modelo;


namespace App01_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BOTAO.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            //validação

            string cep = CEP.Text.Trim();
            RESULTADO.Text = "";

            if (isValidCEP(cep))
            {
                try
                {

                    Endereco end = ViaCEPServico.BuscarEnderecoCiaCEP(cep);
                    if (end != null)
                     RESULTADO.Text = string.Format("Endereço: {2} {3} {0},{1} ", end.localidade, end.uf, end.logradouro, end.bairro);                    
                    else  DisplayAlert("ERRO", "O endereço nao foi encontrado para o cep informado", "OK"); 
                    
                }catch(Exception e)
                {
                    DisplayAlert("ERRO CRITICO", e.Message, "OK");
                }
            }
        }

        private bool isValidCEP(string cep)
        {
            bool valido = true;
            if (cep.Length != 8)
            {
                DisplayAlert("ERRO", "CEP inválido", "OK");
                valido = false;
            }
            int NovoCEP = 0;
            if (!int.TryParse(cep, out NovoCEP))
            {
                DisplayAlert("ERRO", "CEP deve ser composto apenas por números", "OK");
                valido = false;
            }
            return valido;
        }
    }

}
