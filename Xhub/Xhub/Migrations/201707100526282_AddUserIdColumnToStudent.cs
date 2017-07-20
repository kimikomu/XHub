namespace Xhub.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class AddUserIdColumnToStudent : DbMigration
	{
		public override void Up()
		{
			AddColumn("dbo.Students", "UserId_Id", c => c.String(maxLength: 128));
			CreateIndex("dbo.Students", "UserId_Id");
			AddForeignKey("dbo.Students", "UserId_Id", "dbo.AspNetUsers", "Id");
		}
		
		public override void Down()
		{
			DropForeignKey("dbo.Students", "UserId_Id", "dbo.AspNetUsers");
			DropIndex("dbo.Students", new[] { "UserId_Id" });
			DropColumn("dbo.Students", "UserId_Id");
		}
	}
}
