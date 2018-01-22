using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicios
{
    public class Contato
    {
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public string Ramal { get; private set; }

        public Contato(string nome, string telefone, string ramal)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Ramal = ramal;
        }

        public virtual void ImprimeDados()
        {

            Console.WriteLine(string.Format("{0} possui o telefone {1} com o ramal {2}", this.Nome, this.Telefone, this.Ramal));

        }

    }
}
