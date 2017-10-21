namespace TechReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdTimesACharm : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "PublishDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "PublishDate", c => c.DateTime(nullable: false));
        }
    }
}
