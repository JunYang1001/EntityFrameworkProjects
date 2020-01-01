namespace CodeFirstExistingDatabaseSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class w : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "w", c => c.Int(nullable: false));
          
        }
        
        public override void Down()
        {
            AddColumn("dbo.Blogs", "testProperty", c => c.Int(nullable: false));
            DropColumn("dbo.Blogs", "w");
        }
    }
}
