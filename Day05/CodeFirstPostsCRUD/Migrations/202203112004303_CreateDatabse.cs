namespace CodeFirstPostsCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        Email = c.String(maxLength: 50),
                        Password = c.String(maxLength: 50),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Body = c.String(nullable: false, maxLength: 250),
                        PostDateTime = c.DateTime(nullable: false),
                        AutorId = c.Int(nullable: false),
                        BlogId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Authors", t => t.AutorId, cascadeDelete: true)
                .ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: true)
                .Index(t => t.AutorId)
                .Index(t => t.BlogId);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Describtion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PostImages",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ImagePath = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Posts", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PostImages", "Id", "dbo.Posts");
            DropForeignKey("dbo.Posts", "BlogId", "dbo.Blogs");
            DropForeignKey("dbo.Posts", "AutorId", "dbo.Authors");
            DropIndex("dbo.PostImages", new[] { "Id" });
            DropIndex("dbo.Posts", new[] { "BlogId" });
            DropIndex("dbo.Posts", new[] { "AutorId" });
            DropTable("dbo.PostImages");
            DropTable("dbo.Blogs");
            DropTable("dbo.Posts");
            DropTable("dbo.Authors");
        }
    }
}
