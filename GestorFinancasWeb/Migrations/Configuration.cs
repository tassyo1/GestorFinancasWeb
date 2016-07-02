namespace GestorFinancasWeb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    internal sealed class Configuration : DbMigrationsConfiguration<GestorFinancasWeb.DataAcess.Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GestorFinancasWeb.DataAcess.Contexto context)
        {
            context.Frequencias.AddOrUpdate(f => f.Descricao,
                new Frequencia { Descricao = "eventual" },
                new Frequencia { Descricao = "mensal" },
                new Frequencia { Descricao = "bimestral" },
                new Frequencia { Descricao = "trimestral" },
                new Frequencia { Descricao = "semestral" },
                new Frequencia { Descricao = "anual" });
        }
    }
}
