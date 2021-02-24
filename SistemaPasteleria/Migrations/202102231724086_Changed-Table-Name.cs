namespace SistemaPasteleria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedTableName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "public.Catalogoes", newName: "Catalogo");
            RenameTable(name: "public.Materials", newName: "Material");
            RenameTable(name: "public.ListaMaterials", newName: "ListaMaterial");
            RenameTable(name: "public.Recetas", newName: "Receta");
            RenameTable(name: "public.MaterialRecetas", newName: "MaterialReceta");
            RenameTable(name: "public.Ventas", newName: "Venta");
        }
        
        public override void Down()
        {
            RenameTable(name: "public.Venta", newName: "Ventas");
            RenameTable(name: "public.MaterialReceta", newName: "MaterialRecetas");
            RenameTable(name: "public.Receta", newName: "Recetas");
            RenameTable(name: "public.ListaMaterial", newName: "ListaMaterials");
            RenameTable(name: "public.Material", newName: "Materials");
            RenameTable(name: "public.Catalogo", newName: "Catalogoes");
        }
    }
}
