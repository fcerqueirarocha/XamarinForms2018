using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1_Vagas.Banco;
using App1_Vagas.UWP.Banco;
using System.IO;
using Windows.Storage;
using Xamarin.Forms;

[assembly:Dependency(typeof(Caminho))]
namespace App1_Vagas.UWP.Banco
{
    public class Caminho : Icaminho
    {
        public string ObeterCaminho(string NomeArquivoBanco)
        {

            string caminhoDaPasta = ApplicationData.Current.LocalFolder.Path;
            string caminhoBanco = Path.Combine(caminhoDaPasta, NomeArquivoBanco);
            return caminhoBanco;
        }
    }
}
