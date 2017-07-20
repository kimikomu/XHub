namespace Xhub.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class DeleteGrades : DbMigration
	{
		public override void Up()
		{
			Sql("DELETE FROM Grades WHERE Id IN (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15)");
		}
		
		public override void Down()
		{
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (1, 'First')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (2, 'Second')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (3, 'Third')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (4, 'Fourth')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (5, 'Fifth')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (6, 'Sixth')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (7, 'Seventh')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (8, 'Eigth')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (9, 'HS Freshman')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (10, 'HS Sophmore')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (11, 'HS Junior')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (12, 'HS Senior')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (13, 'None')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (14, 'None')");
			Sql("INSERT INTO Grades (Id, GradeLevel) VALUES (15, 'Kindergarten')");
		}
	}
}
