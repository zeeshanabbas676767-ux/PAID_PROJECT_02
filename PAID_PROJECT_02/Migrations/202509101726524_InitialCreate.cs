namespace PAID_PROJECT_02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sch_Attendance",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(),
                        ClassId = c.Int(),
                        AttendanceDate = c.DateTime(storeType: "date"),
                        Status = c.String(maxLength: 50),
                        Deleted = c.Boolean(),
                        Active = c.Boolean(),
                        CreatedDate = c.DateTime(),
                        UpdatedDate = c.DateTime(),
                        Sch_Classes_Id = c.Int(),
                        Sch_Students_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sch_Classes", t => t.Sch_Classes_Id)
                .ForeignKey("dbo.Sch_Students", t => t.Sch_Students_Id)
                .Index(t => t.Sch_Classes_Id)
                .Index(t => t.Sch_Students_Id);
            
            CreateTable(
                "dbo.Sch_Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(),
                        StudentId = c.Int(),
                        EnrollmentDate = c.DateTime(storeType: "date"),
                        Status = c.String(maxLength: 50),
                        CreatedDate = c.DateTime(),
                        UpdatedDate = c.DateTime(),
                        Sch_Courses_Id = c.Int(),
                        Sch_Students_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sch_Courses", t => t.Sch_Courses_Id)
                .ForeignKey("dbo.Sch_Students", t => t.Sch_Students_Id)
                .Index(t => t.Sch_Courses_Id)
                .Index(t => t.Sch_Students_Id);
            
            CreateTable(
                "dbo.Sch_Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentId = c.Int(),
                        CourseName = c.String(maxLength: 50),
                        Code = c.String(maxLength: 50),
                        Description = c.String(),
                        Credits = c.Int(),
                        Active = c.Boolean(),
                        Deleted = c.Boolean(),
                        CreatedBy = c.Int(),
                        CreatedDate = c.DateTime(),
                        UpdatedBy = c.Int(),
                        UpdatedDate = c.DateTime(),
                        Sch_Departments_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sch_Departments", t => t.Sch_Departments_Id)
                .Index(t => t.Sch_Departments_Id);
            
            CreateTable(
                "dbo.Sch_Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 50),
                        DepartmentName = c.String(maxLength: 50),
                        Description = c.String(),
                        Deleted = c.Boolean(nullable: false),
                        Active = c.Boolean(nullable: false),
                        RecordTimeStamp = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sch_Textbooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(),
                        Title = c.String(maxLength: 50),
                        Code = c.String(maxLength: 50),
                        Description = c.String(),
                        ISBN = c.String(maxLength: 50),
                        Price = c.Decimal(precision: 18, scale: 2),
                        Deleted = c.Boolean(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        Sch_Courses_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sch_Courses", t => t.Sch_Courses_Id)
                .Index(t => t.Sch_Courses_Id);
            
            CreateTable(
                "dbo.Sch_Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Student_Id = c.String(maxLength: 50),
                        Student_Name = c.String(maxLength: 50),
                        Address = c.String(),
                        City = c.String(maxLength: 10),
                        Country = c.String(maxLength: 10),
                        Email = c.String(maxLength: 100),
                        Phone = c.String(maxLength: 20),
                        Mobile = c.String(maxLength: 20),
                        Enrollment_Date = c.DateTime(nullable: false, storeType: "date"),
                        Active = c.Boolean(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, storeType: "date"),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sch_Inventory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ResourceId = c.Int(),
                        ResourceName = c.String(maxLength: 50),
                        InStock = c.Boolean(),
                        Quantity = c.Int(),
                        Rack = c.String(maxLength: 50),
                        Shelf = c.String(maxLength: 50),
                        Condition = c.String(maxLength: 50),
                        Deleted = c.Boolean(),
                        Active = c.Boolean(),
                        CreatedDate = c.DateTime(),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sch_Classes", "Sch_Students_Id", "dbo.Sch_Students");
            DropForeignKey("dbo.Sch_Attendance", "Sch_Students_Id", "dbo.Sch_Students");
            DropForeignKey("dbo.Sch_Textbooks", "Sch_Courses_Id", "dbo.Sch_Courses");
            DropForeignKey("dbo.Sch_Courses", "Sch_Departments_Id", "dbo.Sch_Departments");
            DropForeignKey("dbo.Sch_Classes", "Sch_Courses_Id", "dbo.Sch_Courses");
            DropForeignKey("dbo.Sch_Attendance", "Sch_Classes_Id", "dbo.Sch_Classes");
            DropIndex("dbo.Sch_Textbooks", new[] { "Sch_Courses_Id" });
            DropIndex("dbo.Sch_Courses", new[] { "Sch_Departments_Id" });
            DropIndex("dbo.Sch_Classes", new[] { "Sch_Students_Id" });
            DropIndex("dbo.Sch_Classes", new[] { "Sch_Courses_Id" });
            DropIndex("dbo.Sch_Attendance", new[] { "Sch_Students_Id" });
            DropIndex("dbo.Sch_Attendance", new[] { "Sch_Classes_Id" });
            DropTable("dbo.Sch_Inventory");
            DropTable("dbo.Sch_Students");
            DropTable("dbo.Sch_Textbooks");
            DropTable("dbo.Sch_Departments");
            DropTable("dbo.Sch_Courses");
            DropTable("dbo.Sch_Classes");
            DropTable("dbo.Sch_Attendance");
        }
    }
}
