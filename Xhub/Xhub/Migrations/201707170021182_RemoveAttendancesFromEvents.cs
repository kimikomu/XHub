namespace Xhub.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class RemoveAttendancesFromEvents : DbMigration
	{
		public override void Up()
		{
			DropForeignKey("dbo.Attendances", "Event_Id", "dbo.Events");
			DropIndex("dbo.Attendances", new[] { "Event_Id" });
			DropColumn("dbo.Attendances", "Event_Id");
		}
		
		public override void Down()
		{
			AddColumn("dbo.Attendances", "Event_Id", c => c.Int());
			CreateIndex("dbo.Attendances", "Event_Id");
			AddForeignKey("dbo.Attendances", "Event_Id", "dbo.Events", "Id");
		}
	}
}
