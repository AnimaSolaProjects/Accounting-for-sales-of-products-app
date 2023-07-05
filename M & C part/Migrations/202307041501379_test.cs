namespace M___C_part.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GrainType = c.String(),
                        Amount = c.Double(nullable: false),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductType = c.String(),
                        Amount = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        Grain_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grains", t => t.Grain_Id)
                .Index(t => t.Grain_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LevelOfAccess = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Grain_Id", "dbo.Grains");
            DropIndex("dbo.Products", new[] { "Grain_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Products");
            DropTable("dbo.Grains");
        }
    }
}
