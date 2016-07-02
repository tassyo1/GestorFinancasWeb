namespace GestorFinancasWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriaMapeamento : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100, unicode: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataAgendada = c.DateTime(nullable: false, storeType: "date"),
                        Tipo = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        FrequenciaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Frequencias", t => t.FrequenciaID)
                .Index(t => t.FrequenciaID);
            
            CreateTable(
                "dbo.Frequencias",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Movimentos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DataLancamento = c.DateTime(nullable: false, storeType: "date"),
                        SaldoAtual = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategoriaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categorias", t => t.CategoriaID)
                .Index(t => t.CategoriaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movimentos", "CategoriaID", "dbo.Categorias");
            DropForeignKey("dbo.Categorias", "FrequenciaID", "dbo.Frequencias");
            DropIndex("dbo.Movimentos", new[] { "CategoriaID" });
            DropIndex("dbo.Categorias", new[] { "FrequenciaID" });
            DropTable("dbo.Movimentos");
            DropTable("dbo.Frequencias");
            DropTable("dbo.Categorias");
        }
    }
}
