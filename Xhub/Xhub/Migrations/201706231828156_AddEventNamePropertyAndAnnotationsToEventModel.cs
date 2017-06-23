namespace Xhub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEventNamePropertyAndAnnotationsToEventModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "EventName", c => c.String(maxLength: 255));
            AlterColumn("dbo.Events", "Description", c => c.String(maxLength: 510));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "Description", c => c.String());
            DropColumn("dbo.Events", "EventName");
        }
    }
}
