namespace Xhub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStudentAndGradeTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GradeLevel = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Alias = c.String(nullable: false, maxLength: 100),
                        Ability = c.String(nullable: false, maxLength: 255),
                        GradeId = c.Int(nullable: false),
                        Origin = c.Int(nullable: false),
                        OriginId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grades", t => t.GradeId, cascadeDelete: true)
                .Index(t => t.GradeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "GradeId", "dbo.Grades");
            DropIndex("dbo.Students", new[] { "GradeId" });
            DropTable("dbo.Students");
            DropTable("dbo.Grades");
        }
    }
}
