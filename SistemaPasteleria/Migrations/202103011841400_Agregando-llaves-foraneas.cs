namespace SistemaPasteleria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Agregandollavesforaneas : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("public.Material", "Unidad_IdUnidad", "public.Unidad");
            DropForeignKey("public.ListaMaterial", "Unidad_IdUnidad", "public.Unidad");
            DropIndex("public.Material", new[] { "Unidad_IdUnidad" });
            DropIndex("public.ListaMaterial", new[] { "Unidad_IdUnidad" });
            RenameColumn(table: "public.Material", name: "Unidad_IdUnidad", newName: "IdUnidad");
            RenameColumn(table: "public.ListaMaterial", name: "Unidad_IdUnidad", newName: "IdUnidad");
            AlterColumn("public.Material", "IdUnidad", c => c.Int(nullable: false));
            AlterColumn("public.ListaMaterial", "IdUnidad", c => c.Int(nullable: false));
            CreateIndex("public.Material", "IdUnidad");
            CreateIndex("public.ListaMaterial", "IdUnidad");
            AddForeignKey("public.Material", "IdUnidad", "public.Unidad", "IdUnidad", cascadeDelete: true);
            AddForeignKey("public.ListaMaterial", "IdUnidad", "public.Unidad", "IdUnidad", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("public.ListaMaterial", "IdUnidad", "public.Unidad");
            DropForeignKey("public.Material", "IdUnidad", "public.Unidad");
            DropIndex("public.ListaMaterial", new[] { "IdUnidad" });
            DropIndex("public.Material", new[] { "IdUnidad" });
            AlterColumn("public.ListaMaterial", "IdUnidad", c => c.Int());
            AlterColumn("public.Material", "IdUnidad", c => c.Int());
            RenameColumn(table: "public.ListaMaterial", name: "IdUnidad", newName: "Unidad_IdUnidad");
            RenameColumn(table: "public.Material", name: "IdUnidad", newName: "Unidad_IdUnidad");
            CreateIndex("public.ListaMaterial", "Unidad_IdUnidad");
            CreateIndex("public.Material", "Unidad_IdUnidad");
            AddForeignKey("public.ListaMaterial", "Unidad_IdUnidad", "public.Unidad", "IdUnidad");
            AddForeignKey("public.Material", "Unidad_IdUnidad", "public.Unidad", "IdUnidad");
        }
    }
}
