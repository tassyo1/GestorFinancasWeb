using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GestorFinancasWeb.Models;

namespace GestorFinancasWeb.DataAcess
{
    public class Contexto : DbContext
    {
        public Contexto() : base(@"Data Source=TASSYO-PC\SQLEXPRESS;Initial Catalog=GestorFinancas;Integrated Security=True")
        {
            
        }

        public DbSet<Frequencia> Frequencias { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}