namespace LearningPlatform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Role = c.Int(nullable: false),
                        Login = c.String(),
                        Password = c.String(),
                        Salt = c.String(),
                        Group_ID = c.Int(),
                        PersonalData_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Groups", t => t.Group_ID)
                .ForeignKey("dbo.UserDatas", t => t.PersonalData_ID)
                .Index(t => t.Group_ID)
                .Index(t => t.PersonalData_ID);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GroupName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Group_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Groups", t => t.Group_ID)
                .Index(t => t.Group_ID);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Answers = c.String(),
                        Test_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Tests", t => t.Test_ID)
                .Index(t => t.Test_ID);
            
            CreateTable(
                "dbo.Marks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Grade = c.Int(nullable: false),
                        Comment = c.String(),
                        Subject_ID = c.Int(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Subjects", t => t.Subject_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.Subject_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserDatas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        SecondName = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        AverageMark = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Head = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "PersonalData_ID", "dbo.UserDatas");
            DropForeignKey("dbo.Marks", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Marks", "Subject_ID", "dbo.Subjects");
            DropForeignKey("dbo.Users", "Group_ID", "dbo.Groups");
            DropForeignKey("dbo.Tests", "Group_ID", "dbo.Groups");
            DropForeignKey("dbo.Questions", "Test_ID", "dbo.Tests");
            DropIndex("dbo.Marks", new[] { "User_ID" });
            DropIndex("dbo.Marks", new[] { "Subject_ID" });
            DropIndex("dbo.Questions", new[] { "Test_ID" });
            DropIndex("dbo.Tests", new[] { "Group_ID" });
            DropIndex("dbo.Users", new[] { "PersonalData_ID" });
            DropIndex("dbo.Users", new[] { "Group_ID" });
            DropTable("dbo.Events");
            DropTable("dbo.UserDatas");
            DropTable("dbo.Subjects");
            DropTable("dbo.Marks");
            DropTable("dbo.Questions");
            DropTable("dbo.Tests");
            DropTable("dbo.Groups");
            DropTable("dbo.Users");
        }
    }
}
