using System;
using System.Collections.Generic;
using System.Text;
using App1_Mimica.Model;

namespace App1_Mimica.Armazenamento
{
    public class Armazenamento
    {
        public static jogo Jogo { get; set; }
        public static short RodadaAtual { get; set; }

        public static string[][] Palavras =
        {
            //facil ponuação 1
            new string[]{"olho", "lingua", "chinelo", "milho"},
            //medio pontuação 3
            new string[]{"capinteiro", "Amarelo", "Limão", "Abelha"},
            //dificio pontuação 5
            new string[]{"Cisterna", "Lanterna", "Batman vs Superman", "Paralelepipedo"},

        };
    }
}
