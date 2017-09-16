namespace Xhub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeacherToClass : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Classes", "TeacherId");
            AddForeignKey("dbo.Classes", "TeacherId", "dbo.Teachers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Classes", "TeacherId", "dbo.Teachers");
            DropIndex("dbo.Classes", new[] { "TeacherId" });
        }
    }
}
