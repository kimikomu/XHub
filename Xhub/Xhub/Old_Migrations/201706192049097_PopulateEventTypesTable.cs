namespace Xhub.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class PopulateEventTypesTable : DbMigration
	{
		public override void Up()
		{
			Sql("INSERT INTO EventTypes (Id, Name) VALUES (1, 'Class')");
			Sql("INSERT INTO EventTypes (Id, Name) VALUES (2, 'Elective')");
			Sql("INSERT INTO EventTypes (Id, Name) VALUES (3, 'OnGoing')");
			Sql("INSERT INTO EventTypes (Id, Name) VALUES (4, 'StandAlone')");
		}
		
		public override void Down()
		{
			Sql("DELETE FROM EventTypes WHERE Id IN (1, 2, 3, 4)");
		}
	}
}
