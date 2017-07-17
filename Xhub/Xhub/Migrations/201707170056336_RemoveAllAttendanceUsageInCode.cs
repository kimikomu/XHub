namespace Xhub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveAllAttendanceUsageInCode : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Attendances", "Event_Id", "dbo.Events");
            DropIndex("dbo.Attendances", new[] { "Event_Id" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Attendances", "Event_Id");
            AddForeignKey("dbo.Attendances", "Event_Id", "dbo.Events", "Id");
        }
    }
}
