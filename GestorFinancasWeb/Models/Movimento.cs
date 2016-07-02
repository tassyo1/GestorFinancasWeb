using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestorFinancasWeb.Models
{
    public class Movimento
    {
        public int ID { get; set; }
        public DateTime DataLancamento { get; set; }
        public decimal SaldoAtual { get; set; }
        public virtual Categoria Categoria { get; set; }
        public int CategoriaID { get; set; }
    }
}