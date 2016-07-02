using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GestorFinancasWeb.Models;
using GestorFinancasWeb.DataAcess.Map;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GestorFinancasWeb.DataAcess
{
    public class Contexto : DbContext
    {
        public Contexto() : base("Contexto")
        {
            
        }
    
        public IDbSet<Frequencia> Frequencias { get; set; }
        public IDbSet<Categoria> Categorias { get; set; }
        public IDbSet<Movimento> Movimentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));
            
            modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new FrequenciaMap());
            modelBuilder.Configurations.Add(new MovimentoMap());                
        }
    }
}