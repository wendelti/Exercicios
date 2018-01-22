using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Exercicios
{
    public class Cliente : Contato
    {
        public string CPF { get; private set; }
        public Cliente(string nome, string telefone, string ramal, string cpf) : base(nome, telefone, ramal)
        {
            this.CPF = cpf;
        }

        public override void ImprimeDados()
        {

            Console.WriteLine(string.Format("{0} possui o telefone {1} com o ramal {2} com o cpf {3}", this.Nome, this.Telefone, this.Ramal, this.CPF));
        }

        public DataTable SelecionaDadosCliente()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(""))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand() { CommandText = "SelecionaCliente", Connection = con,
                                                    CommandType = CommandType.StoredProcedure };
                using (SqlDataReader dtReader = cmd.ExecuteReader())
                {
                    dt.Load(dtReader);
                }
                con.Close();
            }


            return dt;
        }

    }
}
