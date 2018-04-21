namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedDateTimetonullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "DueBackDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "DueBackDate", c => c.DateTime(nullable: false));
        }
    }
}
