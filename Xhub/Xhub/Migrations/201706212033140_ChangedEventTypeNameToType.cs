namespace Xhub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedEventTypeNameToType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EventTypes", "Type", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.EventTypes", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EventTypes", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.EventTypes", "Type");
        }
    }
}
