namespace Xhub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropGradeTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "GradeId", "dbo.Grades");
            DropIndex("dbo.Students", new[] { "GradeId" });
            AddColumn("dbo.Students", "Grade", c => c.Int(nullable: false));
            DropColumn("dbo.Students", "GradeId");
            DropTable("dbo.Grades");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GradeLevel = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "GradeId", c => c.Int(nullable: false));
            DropColumn("dbo.Students", "Grade");
            CreateIndex("dbo.Students", "GradeId");
            AddForeignKey("dbo.Students", "GradeId", "dbo.Grades", "Id", cascadeDelete: true);
        }
    }
}
