using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{

    /// <summary>
    /// Dada a string abaixo, desenvolva um algoritmo que inverta as letras para que o
    /// resultado final seja “STubRP&;
    /// </summary>
    /// 

    public class QuestaoDois : IQuestao
    {
        string Texto;
        public QuestaoDois(string texto)
        {
            this.Texto = texto;
        }

        public void ExibirResultado() {

            string textoInvertido = new string( this.Texto.ToCharArray().Reverse().ToArray() );
            Console.WriteLine(string.Concat("Texto Original: ", this.Texto));
            Console.WriteLine(string.Concat("Texto Invertido: ", textoInvertido));
        }

    }
}
