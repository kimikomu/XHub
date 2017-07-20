namespace Xhub.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class RemoveExtraEvents : DbMigration
	{
		public override void Up()
		{
			Sql("DELETE FROM EventTypes WHERE Id IN (10, 11, 12, 13, 14)");
		}
		
		public override void Down()
		{
			Sql("INSERT INTO EventTypes (Id, Type) VALUES (10, 'Danger Room Event')");
			Sql("INSERT INTO EventTypes (Id, Type) VALUES (11, 'Dance')");
			Sql("INSERT INTO EventTypes (Id, Type) VALUES (12, 'X-men Training')");
			Sql("INSERT INTO EventTypes (Id, Type) VALUES (13, 'Drill')");
			Sql("INSERT INTO EventTypes (Id, Type) VALUES (14, 'Other')");
		}
	}
}
