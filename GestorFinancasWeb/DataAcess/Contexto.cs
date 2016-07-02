using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GestorFinancasWeb.DataAcess
{
    public class Contexto : DbContext
    {
        public Contexto() : base(@"Data Source=TASSYO-PC\SQLEXPRESS;Initial Catalog=GestorFinancas;Integrated Security=True")
        {
            
        }

    }
}