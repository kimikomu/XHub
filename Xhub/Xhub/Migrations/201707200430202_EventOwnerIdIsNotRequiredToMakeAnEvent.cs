namespace Xhub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventOwnerIdIsNotRequiredToMakeAnEvent : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "EventOwnerId", "dbo.AspNetUsers");
            DropIndex("dbo.Events", new[] { "EventOwnerId" });
            AlterColumn("dbo.Events", "EventOwnerId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Events", "EventOwnerId");
            AddForeignKey("dbo.Events", "EventOwnerId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "EventOwnerId", "dbo.AspNetUsers");
            DropIndex("dbo.Events", new[] { "EventOwnerId" });
            AlterColumn("dbo.Events", "EventOwnerId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Events", "EventOwnerId");
            AddForeignKey("dbo.Events", "EventOwnerId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
