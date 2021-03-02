namespace SistemaPasteleria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Agregandotablaunidad : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Unidad",
                c => new
                    {
                        IdUnidad = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IdUnidad);
            
            AddColumn("public.Material", "Unidad_IdUnidad", c => c.Int());
            AddColumn("public.ListaMaterial", "Unidad_IdUnidad", c => c.Int());
            CreateIndex("public.Material", "Unidad_IdUnidad");
            CreateIndex("public.ListaMaterial", "Unidad_IdUnidad");
            AddForeignKey("public.Material", "Unidad_IdUnidad", "public.Unidad", "IdUnidad");
            AddForeignKey("public.ListaMaterial", "Unidad_IdUnidad", "public.Unidad", "IdUnidad");
        }
        
        public override void Down()
        {
            DropForeignKey("public.ListaMaterial", "Unidad_IdUnidad", "public.Unidad");
            DropForeignKey("public.Material", "Unidad_IdUnidad", "public.Unidad");
            DropIndex("public.ListaMaterial", new[] { "Unidad_IdUnidad" });
            DropIndex("public.Material", new[] { "Unidad_IdUnidad" });
            DropColumn("public.ListaMaterial", "Unidad_IdUnidad");
            DropColumn("public.Material", "Unidad_IdUnidad");
            DropTable("public.Unidad");
        }
    }
}
