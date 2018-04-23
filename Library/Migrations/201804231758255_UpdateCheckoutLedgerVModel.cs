namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCheckoutLedgerVModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Checkouts", "BookId", "dbo.Books");
            DropIndex("dbo.Checkouts", new[] { "BookId" });
            DropTable("dbo.Checkouts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Checkouts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TimeStamp = c.DateTime(nullable: false),
                        Email = c.String(),
                        BookId = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.Checkouts", "BookId");
            AddForeignKey("dbo.Checkouts", "BookId", "dbo.Books", "ID");
        }
    }
}
