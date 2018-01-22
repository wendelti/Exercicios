using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    public class QuestaoUmV2 : QuestaoUm, IQuestao
    {          

        public QuestaoUmV2()
        {
            InicializaValores();
        }
 
        // Neste caso não fiz uso de uma variavel auxiliar, mas sim de expressoes matematicas
        public void ExibirResultado()
        {
            // Neste caso, como os números são fixos, não precisaria do try, mas da um nervoso dividir por variaveis sem o try
            // Também seria possível realizar o teste na variavel.
            try
            {
                a = a * b;
                b = a / b;
                a = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nenhum dos valores pode ser ZERO!");
            }
            catch (Exception e)
            {
                Console.WriteLine(String.Concat("Erro: ", e.Message));
            }

            Console.WriteLine(String.Concat("Valor de a: ", a));
            Console.WriteLine(String.Concat("Valor de b: ", b));
        }
    }
}
