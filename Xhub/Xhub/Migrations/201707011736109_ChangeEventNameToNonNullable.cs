namespace Xhub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeEventNameToNonNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "EventName", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "EventName", c => c.String(maxLength: 255));
        }
    }
}
