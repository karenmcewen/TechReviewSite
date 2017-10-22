namespace TechReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class moreChangesToDatabaseValues : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "Content", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "Content", c => c.String());
        }
    }
}
