using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    /// <summary>
    /// Criar um programa para Ler e imprimir um valor em segundos e transformar em Horas,
    /// Minutos e Segundos???
    /// </summary>
    /// 
    public class QuestaoTres : IQuestao
    {
        int Segundos;

        public QuestaoTres(int segundos)
        {
            this.Segundos = segundos;
        }

        public void ExibirResultado()
        {

            var t = TimeSpan.FromSeconds(this.Segundos);
            Console.WriteLine(String.Concat("O valor convertido é:  Horas:", t.Hours, ",  Minutos:" , t.Minutes, ", Segundos:", t.Seconds));


        }
    }
}
