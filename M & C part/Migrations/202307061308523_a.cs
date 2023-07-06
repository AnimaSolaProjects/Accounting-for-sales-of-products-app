namespace M___C_part.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Grain_Id", "dbo.Grains");
            DropIndex("dbo.Products", new[] { "Grain_Id" });
            DropColumn("dbo.Products", "Grain_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Grain_Id", c => c.Int());
            CreateIndex("dbo.Products", "Grain_Id");
            AddForeignKey("dbo.Products", "Grain_Id", "dbo.Grains", "Id");
        }
    }
}
