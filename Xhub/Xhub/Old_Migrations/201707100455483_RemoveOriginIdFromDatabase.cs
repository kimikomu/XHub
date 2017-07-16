namespace Xhub.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class RemoveOriginIdFromDatabase : DbMigration
	{
		public override void Up()
		{
			DropColumn("dbo.Students", "OriginId");
		}
		
		public override void Down()
		{
			AddColumn("dbo.Students", "OriginId", c => c.Int(nullable: false));
		}
	}
}
