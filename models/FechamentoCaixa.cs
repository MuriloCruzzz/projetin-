using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2023.models
{
    public class FechamentoCaixa
    {
        public int Id { get; set; }
        public DateTime DataFechamento { get; set; }
        public decimal SaldoInicial { get; set; }
        public List<Transacao> Transacoes { get; set; }
        public decimal SaldoFinal { get; set; }
    }
}
