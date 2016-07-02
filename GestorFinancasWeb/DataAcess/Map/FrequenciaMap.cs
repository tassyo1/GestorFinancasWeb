using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using GestorFinancasWeb.Models;

namespace GestorFinancasWeb.DataAcess.Map
{
    public class FrequenciaMap : EntityTypeConfiguration<Frequencia>
    {
        public FrequenciaMap()
        {
            ToTable("Frequencias");

            HasKey(f => f.ID);

            Property(f => f.Descricao).IsRequired();

            
        }
    }
}