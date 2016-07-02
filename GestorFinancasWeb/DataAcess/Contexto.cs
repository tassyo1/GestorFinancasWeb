using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GestorFinancasWeb.Models;
using GestorFinancasWeb.DataAcess.Map;

namespace GestorFinancasWeb.DataAcess
{
    public class Contexto : DbContext
    {
        public Contexto() : base("Contexto")
        {
            
        }
    
        public DbSet<Frequencia> Frequencias { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Movimento> Movimentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new FrequenciaMap());
            modelBuilder.Configurations.Add(new MovimentoMap());                
        }
    }
}