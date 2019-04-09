﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using App1_Vagas.Banco;
using Xamarin.Forms;
using System.IO;
using App1_Vagas.iOS.Banco;

[assembly:Dependency(typeof(Caminho))]
namespace App1_Vagas.iOS.Banco
{
    public class Caminho : Icaminho
    {
        public string ObeterCaminho(string NomeArquivoBanco)
        {
            string caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string caminhoBiblioteca = Path.Combine(caminhoDaPasta, "..", "Library"); // os .. servem para voltar um nivel de pasta e na sequencia concatenar a pasta library
            string caminhoBanco = Path.Combine(caminhoBiblioteca, NomeArquivoBanco);
            return caminhoBanco;
        }
    }
}