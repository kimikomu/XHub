namespace Xhub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttendancesToEvent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attendances", "Event_Id", c => c.Int());
            CreateIndex("dbo.Attendances", "Event_Id");
            AddForeignKey("dbo.Attendances", "Event_Id", "dbo.Events", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "Event_Id", "dbo.Events");
            DropIndex("dbo.Attendances", new[] { "Event_Id" });
            DropColumn("dbo.Attendances", "Event_Id");
        }
    }
}
