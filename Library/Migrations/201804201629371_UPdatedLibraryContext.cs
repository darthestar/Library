namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UPdatedLibraryContext : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.Books", "GenreId", "dbo.Genres");
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropIndex("dbo.Books", new[] { "GenreId" });
            AlterColumn("dbo.Books", "AuthorId", c => c.Int(nullable: false));
            AlterColumn("dbo.Books", "GenreId", c => c.Int(nullable: false));
            CreateIndex("dbo.Books", "AuthorId");
            CreateIndex("dbo.Books", "GenreId");
            AddForeignKey("dbo.Books", "AuthorId", "dbo.Authors", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Books", "GenreId", "dbo.Genres", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "GenreId" });
            DropIndex("dbo.Books", new[] { "AuthorId" });
            AlterColumn("dbo.Books", "GenreId", c => c.Int());
            AlterColumn("dbo.Books", "AuthorId", c => c.Int());
            CreateIndex("dbo.Books", "GenreId");
            CreateIndex("dbo.Books", "AuthorId");
            AddForeignKey("dbo.Books", "GenreId", "dbo.Genres", "ID");
            AddForeignKey("dbo.Books", "AuthorId", "dbo.Authors", "ID");
        }
    }
}
