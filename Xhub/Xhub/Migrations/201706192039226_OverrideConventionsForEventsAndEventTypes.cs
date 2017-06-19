namespace Xhub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsForEventsAndEventTypes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "EventOwner_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Events", "EventType_Id", "dbo.EventTypes");
            DropIndex("dbo.Events", new[] { "EventOwner_Id" });
            DropIndex("dbo.Events", new[] { "EventType_Id" });
            AlterColumn("dbo.Events", "EventLocation", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Events", "EventOwner_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Events", "EventType_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.EventTypes", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Events", "EventOwner_Id");
            CreateIndex("dbo.Events", "EventType_Id");
            AddForeignKey("dbo.Events", "EventOwner_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Events", "EventType_Id", "dbo.EventTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "EventType_Id", "dbo.EventTypes");
            DropForeignKey("dbo.Events", "EventOwner_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Events", new[] { "EventType_Id" });
            DropIndex("dbo.Events", new[] { "EventOwner_Id" });
            AlterColumn("dbo.EventTypes", "Name", c => c.String());
            AlterColumn("dbo.Events", "EventType_Id", c => c.Byte());
            AlterColumn("dbo.Events", "EventOwner_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Events", "EventLocation", c => c.String());
            CreateIndex("dbo.Events", "EventType_Id");
            CreateIndex("dbo.Events", "EventOwner_Id");
            AddForeignKey("dbo.Events", "EventType_Id", "dbo.EventTypes", "Id");
            AddForeignKey("dbo.Events", "EventOwner_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
