using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto2023.models
{
    class Despesas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int ContaBancariaId { get; set; }
        public Contas ContaBancaria { get; set; }
        public int CentroDeCustoId { get; set; } // Adicionado campo CentroDeCustoId
        public Centro_Custo CentroDeCusto { get; set; } // Adicionado relacionamento com CentroDeCusto
        public string Descricao { get; set; }
    }
}
