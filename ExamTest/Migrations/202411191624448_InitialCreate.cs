namespace ExamTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        IdTest = c.Int(nullable: false, identity: true),
                        SysDate = c.DateTime(nullable: false),
                        TestName = c.String(),
                        Question = c.String(),
                        Answer = c.String(),
                    })
                .PrimaryKey(t => t.IdTest);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tests");
        }
    }
}
