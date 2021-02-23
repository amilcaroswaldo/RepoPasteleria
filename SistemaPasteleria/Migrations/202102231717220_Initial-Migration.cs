namespace SistemaPasteleria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Catalogoes",
                c => new
                    {
                        IdCatalogo = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdCatalogo);
            
            CreateTable(
                "public.Materials",
                c => new
                    {
                        IdMaterial = c.Int(nullable: false, identity: true),
                        IdCatalogo = c.Int(nullable: false),
                        CantidadInicial = c.Double(nullable: false),
                        Precio = c.Double(nullable: false),
                        PrecioGramo = c.Double(nullable: false),
                        CantidadDisponible = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.IdMaterial)
                .ForeignKey("public.Catalogoes", t => t.IdCatalogo, cascadeDelete: true)
                .Index(t => t.IdCatalogo);
            
            CreateTable(
                "public.ListaMaterials",
                c => new
                    {
                        IdListaMaterial = c.Int(nullable: false, identity: true),
                        IdReceta = c.Int(nullable: false),
                        IdCatalogo = c.Int(nullable: false),
                        Cantidad = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.IdListaMaterial)
                .ForeignKey("public.Catalogoes", t => t.IdCatalogo, cascadeDelete: true)
                .ForeignKey("public.Recetas", t => t.IdReceta, cascadeDelete: true)
                .Index(t => t.IdReceta)
                .Index(t => t.IdCatalogo);
            
            CreateTable(
                "public.Recetas",
                c => new
                    {
                        IdReceta = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        Precio = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.IdReceta);
            
            CreateTable(
                "public.MaterialRecetas",
                c => new
                    {
                        IdMaterialReceta = c.Int(nullable: false, identity: true),
                        IdListaMaterial = c.Int(nullable: false),
                        IdMaterial = c.Int(nullable: false),
                        Cantidad = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.IdMaterialReceta)
                .ForeignKey("public.ListaMaterials", t => t.IdListaMaterial, cascadeDelete: true)
                .ForeignKey("public.Materials", t => t.IdMaterial, cascadeDelete: true)
                .Index(t => t.IdListaMaterial)
                .Index(t => t.IdMaterial);
            
            CreateTable(
                "public.Ventas",
                c => new
                    {
                        IdVenta = c.Int(nullable: false, identity: true),
                        IdReceta = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Cantidad = c.Double(nullable: false),
                        PrecioUnitario = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.IdVenta)
                .ForeignKey("public.Recetas", t => t.IdReceta, cascadeDelete: true)
                .Index(t => t.IdReceta);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.Ventas", "IdReceta", "public.Recetas");
            DropForeignKey("public.MaterialRecetas", "IdMaterial", "public.Materials");
            DropForeignKey("public.MaterialRecetas", "IdListaMaterial", "public.ListaMaterials");
            DropForeignKey("public.ListaMaterials", "IdReceta", "public.Recetas");
            DropForeignKey("public.ListaMaterials", "IdCatalogo", "public.Catalogoes");
            DropForeignKey("public.Materials", "IdCatalogo", "public.Catalogoes");
            DropIndex("public.Ventas", new[] { "IdReceta" });
            DropIndex("public.MaterialRecetas", new[] { "IdMaterial" });
            DropIndex("public.MaterialRecetas", new[] { "IdListaMaterial" });
            DropIndex("public.ListaMaterials", new[] { "IdCatalogo" });
            DropIndex("public.ListaMaterials", new[] { "IdReceta" });
            DropIndex("public.Materials", new[] { "IdCatalogo" });
            DropTable("public.Ventas");
            DropTable("public.MaterialRecetas");
            DropTable("public.Recetas");
            DropTable("public.ListaMaterials");
            DropTable("public.Materials");
            DropTable("public.Catalogoes");
        }
    }
}
