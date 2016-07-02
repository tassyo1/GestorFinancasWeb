using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestorFinancasWeb.Models;

namespace GestorFinancasWeb.Models
{
    public class Categoria
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataAgendada { get; set; }

        public char Tipo { get; set; }

        public virtual Frequencia Frequencia { get; set; }

        public int FrequenciaID { get; set; }
    }
}