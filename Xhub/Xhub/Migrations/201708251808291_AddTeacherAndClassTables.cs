namespace Xhub.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class AddTeacherAndClassTables : DbMigration
	{
		public override void Up()
		{
			CreateTable(
				"dbo.Classes",
				c => new
					{
						Id = c.Int(nullable: false, identity: true),
						ClassName = c.String(nullable: false, maxLength: 255),
						TeacherId = c.Int(nullable: false),
						FirstClass = c.DateTime(nullable: false),
						LastClass = c.DateTime(nullable: false),
						LengthInMinutes = c.Int(nullable: false),
						ClassLocation = c.String(nullable: false, maxLength: 255),
						ClassDescription = c.String(maxLength: 500),
					})
				.PrimaryKey(t => t.Id);
			
			CreateTable(
				"dbo.Teachers",
				c => new
					{
						Id = c.Int(nullable: false, identity: true),
						TeacherFirstName = c.String(maxLength: 255),
						TeacherLastName = c.String(maxLength: 255),
						TeacherAlias = c.String(maxLength: 255),
					})
				.PrimaryKey(t => t.Id);
			
		}
		
		public override void Down()
		{
			DropTable("dbo.Teachers");
			DropTable("dbo.Classes");
		}
	}
}
