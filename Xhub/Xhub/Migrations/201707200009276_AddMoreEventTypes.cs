namespace Xhub.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class AddMoreEventTypes : DbMigration
	{
		public override void Up()
		{
			Sql("INSERT INTO EventTypes (Id, Type) VALUES (5, 'Just For Fun')");
			Sql("INSERT INTO EventTypes (Id, Type) VALUES (6, 'Field Trip')");
			Sql("INSERT INTO EventTypes (Id, Type) VALUES (7, 'Competition')");
			Sql("INSERT INTO EventTypes (Id, Type) VALUES (8, 'Community Service')");
			Sql("INSERT INTO EventTypes (Id, Type) VALUES (9, 'School Assembly')");
			Sql("INSERT INTO EventTypes (Id, Type) VALUES (10, 'Danger Room Event')");
			Sql("INSERT INTO EventTypes (Id, Type) VALUES (11, 'Dance')");
			Sql("INSERT INTO EventTypes (Id, Type) VALUES (12, 'X-men Training')");
			Sql("INSERT INTO EventTypes (Id, Type) VALUES (13, 'Drill')");
			Sql("INSERT INTO EventTypes (Id, Type) VALUES (14, 'Other')");
		}
		
		public override void Down()
		{
			Sql("DELETE FROM EventTypes WHERE Id IN (5, 6, 7, 8, 9, 10, 11, 12, 13, 14)");
		}
	}
}
