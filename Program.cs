using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {


            IList<IQuestao> questoes = new List<IQuestao>();
            questoes.Add(new QuestaoUmV1());
            questoes.Add(new QuestaoDois("PRbuTS"));
            questoes.Add(new QuestaoTres(8700));
            questoes.Add(new QuestaoQuatro());
            questoes.Add(new QuestaoCinco());

            foreach (IQuestao q in questoes)
            {
                q.ExibirResultado();
                LinhaSeparadora();
            }

                                    
            Console.ReadKey();

        }

        public static void LinhaSeparadora()
        {
            Console.WriteLine("");
        }

    }
}
