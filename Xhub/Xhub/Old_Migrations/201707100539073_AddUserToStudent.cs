namespace Xhub.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class AddUserToStudent : DbMigration
	{
		public override void Up()
		{
			RenameColumn(table: "dbo.Students", name: "UserId_Id", newName: "StudentUserId");
			RenameIndex(table: "dbo.Students", name: "IX_UserId_Id", newName: "IX_StudentUserId");
		}
		
		public override void Down()
		{
			RenameIndex(table: "dbo.Students", name: "IX_StudentUserId", newName: "IX_UserId_Id");
			RenameColumn(table: "dbo.Students", name: "StudentUserId", newName: "UserId_Id");
		}
	}
}
