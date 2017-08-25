namespace Xhub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeLastClassToSecondClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Classes", "SecondClass", c => c.DateTime(nullable: false));
            DropColumn("dbo.Classes", "LastClass");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Classes", "LastClass", c => c.DateTime(nullable: false));
            DropColumn("dbo.Classes", "SecondClass");
        }
    }
}
