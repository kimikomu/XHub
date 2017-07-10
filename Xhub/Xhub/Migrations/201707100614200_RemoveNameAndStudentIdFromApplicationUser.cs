namespace Xhub.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class RemoveNameAndStudentIdFromApplicationUser : DbMigration
	{
		public override void Up()
		{
			DropColumn("dbo.AspNetUsers", "Name");
			DropColumn("dbo.AspNetUsers", "StudentId");
		}
		
		public override void Down()
		{
			AddColumn("dbo.AspNetUsers", "StudentId", c => c.Int(nullable: false));
			AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false, maxLength: 100));
		}
	}
}
