using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    /// <summary>
    /// A) Construa a classe Contato, implementando seus métodos(Dica: utilize
    /// console.writeline() para imprimir na tela)
    /// B)Implemente a classe Cliente.Importante: o método ImprimeDados() deve imprimir
    /// todos os dados do cliente
    /// </summary>
    /// 
    public class QuestaoQuatro : IQuestao
    {
        public QuestaoQuatro()
        {

        }

        public void ExibirResultado()
        {

            Cliente c = new Cliente("Wendel", "51 848796", "62", "999999999");
            c.ImprimeDados();

        }
    }
}
