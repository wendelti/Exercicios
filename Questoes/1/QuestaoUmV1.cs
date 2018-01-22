using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    public class QuestaoUmV1 : QuestaoUm, IQuestao
    {
        public QuestaoUmV1()
        {
            InicializaValores();
        }

        // Como no exercicio não restringia o uso de outras variaveis, fiz uso desta variavel temporaria.
        public void ExibirResultado()
        {
            int c; 
            c = a;
            a = b;
            b = c;

            Console.WriteLine(String.Concat("Valor de a: ", a));
            Console.WriteLine(String.Concat("Valor de b: ", b));
        }

    }
}
