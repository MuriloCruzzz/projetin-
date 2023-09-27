using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2023.models
{
    public class SangriaCaixa
    {
        public int Id { get; set; }
        public DateTime DataSangria { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
    }
}
