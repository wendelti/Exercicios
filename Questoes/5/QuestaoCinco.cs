using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{

    /// <summary>
    /// C#: Assinale a alternativa correta:
    //    a) int texto = int(Request.QueryString[“inteiro”]);
    //    b) string inteiro = ToString(int.Parse(“texto”));
    //    c) int texto = inteiro.ToInt;
    //    d) decimal = int.Parse(Request.QueryString[“inteiro”]);
    //    e) int texto = int.Parse(inteiro.ToString());
    //    Nenhuma delas parece correta.Primeiro pelo fato de o nome das variáveis, que
    //    são incoerentes com seu tipo. Segundo porque, caso o objetivo seja o aparente,
    //    obter o valor inteiro de uma variável , nenhuma das opções acimas esta livre de
    //    Exception, desconsiderando as opções ‘C’ e ’D’, que nem compilariam.Dentre
    //    estas, somente a opção ‘E’ parece ser ExceptionFree, considerando que ‘inteiro’
    //    seja realmente uma variável do tipo int. Porém, neste caso, a atribuição pode ser
    //    feita diretamente, fazendo desnecessário a conversão do número para String e
    //    depois novamente para int.
    //    Minha sugestão seria a seguinte:
    //    int inteiro;
    //    bool converteu = int.TryParse(Request.QueryString[“inteiro”], out inteiro);
    ///
    /// </summary>
    /// 

    public class QuestaoCinco : IQuestao
    {

        public QuestaoCinco()
        {
        }

        public void ExibirResultado()
        {

            int inteiro;
            bool converteu = int.TryParse("", out inteiro);
            Console.WriteLine("Resultado da Conversao de '': {0}", inteiro);

        }

    }
}
