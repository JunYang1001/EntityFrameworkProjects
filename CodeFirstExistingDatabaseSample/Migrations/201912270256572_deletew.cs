namespace CodeFirstExistingDatabaseSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletew : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Blogs", "w");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Blogs", "w", c => c.Int(nullable: false));
        }
    }
}
