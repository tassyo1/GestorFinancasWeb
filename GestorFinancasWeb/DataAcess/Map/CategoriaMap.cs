using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using GestorFinancasWeb.Models;
namespace GestorFinancasWeb.DataAcess.Map
{
    public class CategoriaMap : EntityTypeConfiguration<Categoria>
    {
        public CategoriaMap()
        {
            ToTable("Categorias");

            HasKey(c => c.ID);

            Property(c => c.DataAgendada).HasColumnType("Date");
            Property(c => c.Tipo)
                .HasColumnType("char")
                .HasMaxLength(1);
             

            //relacionamento 1:N
            HasRequired(c => c.Frequencia) //
                .WithMany(); // frequencia pode ter muitas categorias
              //  .Map(c => c.MapKey("FrequenciaID")); // chave estrangeira em categoria

        }
    }
}