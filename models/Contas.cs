using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2023.models
{
     public class Contas
    {
        public int Id_conta { get; set; }
        public string Nome_conta { get; set; }
        public string TipoConta_conta { get; set; }
        public decimal SaldoInicial_conta { get; set; }
        public string Descricao_conta { get; set; }

        public Contas(int idConta, string nomeConta, string tipo, decimal saldoIni, string desc)
        {
            Id_conta = idConta;
            Nome_conta = nomeConta;
            TipoConta_conta = tipo;
            SaldoInicial_conta = saldoIni;
            Descricao_conta = desc;
        }


        public Contas(string nomeConta, string tipo, decimal saldoIni, string desc)
        {
           
            Nome_conta = nomeConta;
            TipoConta_conta = tipo;
            SaldoInicial_conta = saldoIni;
            Descricao_conta = desc;
        }

    }
}
