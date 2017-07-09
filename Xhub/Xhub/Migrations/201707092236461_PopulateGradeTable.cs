namespace Xhub.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class PopulateGradeTable : DbMigration
	{
		public override void Up()
		{
			Sql("SET IDENTITY_INSERT Grades ON");

			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (1, 'Kindergarten')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (2, 'First')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (3, 'Second')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (4, 'Third')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (5, 'Fourth')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (6, 'Fifth')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (7, 'Sixth')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (8, 'Seventh')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (9, 'Eigth')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (10, 'HS Freshman')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (11, 'HS Sophmore')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (12, 'HS Junior')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (13, 'HS Senior')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (14, 'None')");

			Sql("SET IDENTITY_INSERT Grades OFF");
		}

		public override void Down()
		{
			Sql("DELETE FROM Grades WHERE Id IN (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14)");
		}
	}
}
