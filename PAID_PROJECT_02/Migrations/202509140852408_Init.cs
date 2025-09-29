namespace PAID_PROJECT_02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sch_Departments", "Deleted", c => c.Boolean());
            AlterColumn("dbo.Sch_Departments", "Active", c => c.Boolean());
            AlterColumn("dbo.Sch_Departments", "RecordTimeStamp", c => c.DateTime());
            AlterColumn("dbo.Sch_Departments", "CreatedBy", c => c.Int());
            AlterColumn("dbo.Sch_Departments", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Sch_Departments", "UpdatedBy", c => c.Int());
            AlterColumn("dbo.Sch_Departments", "UpdatedDate", c => c.DateTime());
            AlterColumn("dbo.Sch_Textbooks", "Deleted", c => c.Boolean());
            AlterColumn("dbo.Sch_Textbooks", "Active", c => c.Boolean());
            AlterColumn("dbo.Sch_Textbooks", "CreatedBy", c => c.Int());
            AlterColumn("dbo.Sch_Textbooks", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Sch_Textbooks", "UpdatedBy", c => c.Int());
            AlterColumn("dbo.Sch_Textbooks", "UpdatedDate", c => c.DateTime());
            AlterColumn("dbo.Sch_Students", "Active", c => c.Boolean());
            AlterColumn("dbo.Sch_Students", "Deleted", c => c.Boolean());
            AlterColumn("dbo.Sch_Students", "CreatedBy", c => c.Int());
            AlterColumn("dbo.Sch_Students", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Sch_Students", "UpdatedBy", c => c.Int());
            AlterColumn("dbo.Sch_Students", "UpdatedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sch_Students", "UpdatedDate", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Sch_Students", "UpdatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Sch_Students", "CreatedDate", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Sch_Students", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Sch_Students", "Deleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Sch_Students", "Active", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Sch_Textbooks", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Sch_Textbooks", "UpdatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Sch_Textbooks", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Sch_Textbooks", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Sch_Textbooks", "Active", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Sch_Textbooks", "Deleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Sch_Departments", "UpdatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Sch_Departments", "UpdatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Sch_Departments", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Sch_Departments", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Sch_Departments", "RecordTimeStamp", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Sch_Departments", "Active", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Sch_Departments", "Deleted", c => c.Boolean(nullable: false));
        }
    }
}
