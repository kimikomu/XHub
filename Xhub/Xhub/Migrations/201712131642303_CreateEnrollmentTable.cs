namespace Xhub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CreateEnrollmentTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Enrollments",
                    c => new
                    {
                        ClassId = c.Int(nullable: false),
                        EnrolleeId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.ClassId, t.EnrolleeId })
                .ForeignKey("dbo.AspNetUsers", t => t.EnrolleeId, cascadeDelete: false)
                .ForeignKey("dbo.Classes", t => t.ClassId)
                .Index(t => t.ClassId)
                .Index(t => t.EnrolleeId);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "ClassId", "dbo.Classes");
            DropForeignKey("dbo.Enrollments", "EnrolleeId", "dbo.AspNetUsers");
            DropIndex("dbo.Enrollments", new[] { "EnrolleeId" });
            DropIndex("dbo.Enrollments", new[] { "ClassId" });
            DropTable("dbo.Enrollments");
        }
    }
}
