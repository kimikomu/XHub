namespace Xhub.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class PopulateEventTypesTableTypesColumn : DbMigration
	{
		public override void Up()
		{
			Sql("UPDATE EventTypes SET Type = 'Class' WHERE Id = 1");
			Sql("UPDATE EventTypes SET Type = 'Elective' WHERE Id = 2");
			Sql("UPDATE EventTypes SET Type = 'OnGoing' WHERE Id = 3");
			Sql("UPDATE EventTypes SET Type = 'StandAlone' WHERE Id = 4");
		}

		public override void Down()
		{
			Sql("DELETE FROM EventTypes WHERE Type = 'Class'");
			Sql("DELETE FROM EventTypes WHERE Type = 'Elective'");
			Sql("DELETE FROM EventTypes WHERE Type = 'OnGoing'");
			Sql("DELETE FROM EventTypes WHERE Type = 'StandAlone'");
		}
	}
}
