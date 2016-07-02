using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using GestorFinancasWeb.Models;

namespace GestorFinancasWeb.DataAcess.Map
{
    public class MovimentoMap : EntityTypeConfiguration<Movimento>
    {
        public MovimentoMap()
        {
            ToTable("Movimentos");

            HasKey(m => m.ID);

            Property(m => m.DataLancamento).HasColumnType("Date");

            HasRequired(m => m.Categoria)
                .WithMany();
                //.Map(m => m.MapKey("CategoriaID"));
        }
    }
}