namespace Xhub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyPropertiesToEvent : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Events", name: "EventOwner_Id", newName: "EventOwnerId");
            RenameColumn(table: "dbo.Events", name: "EventType_Id", newName: "EventTypeId");
            RenameIndex(table: "dbo.Events", name: "IX_EventOwner_Id", newName: "IX_EventOwnerId");
            RenameIndex(table: "dbo.Events", name: "IX_EventType_Id", newName: "IX_EventTypeId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Events", name: "IX_EventTypeId", newName: "IX_EventType_Id");
            RenameIndex(table: "dbo.Events", name: "IX_EventOwnerId", newName: "IX_EventOwner_Id");
            RenameColumn(table: "dbo.Events", name: "EventTypeId", newName: "EventType_Id");
            RenameColumn(table: "dbo.Events", name: "EventOwnerId", newName: "EventOwner_Id");
        }
    }
}
