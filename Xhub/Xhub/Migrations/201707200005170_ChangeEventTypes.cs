namespace Xhub.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class ChangeEventTypes : DbMigration
	{
		public override void Up()
		{
			Sql("UPDATE EventTypes SET Type = 'Class Requirement' WHERE Id = 1");
			Sql("UPDATE EventTypes SET Type = 'X-tra Credit' WHERE Id = 2");
			Sql("UPDATE EventTypes SET Type = 'Club Event' WHERE Id = 3");
			Sql("UPDATE EventTypes SET Type = 'Sport Event' WHERE Id = 4");
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
