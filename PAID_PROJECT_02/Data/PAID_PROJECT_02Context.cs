using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PAID_PROJECT_02.Data
{
    public class PAID_PROJECT_02Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PAID_PROJECT_02Context() : base("name=PAID_PROJECT_02Context")
        {
        }

        public System.Data.Entity.DbSet<PAID_PROJECT_02.Models.Sch_Attendance> Sch_Attendance { get; set; }

        public System.Data.Entity.DbSet<PAID_PROJECT_02.Models.Sch_Classes> Sch_Classes { get; set; }

        public System.Data.Entity.DbSet<PAID_PROJECT_02.Models.Sch_Courses> Sch_Courses { get; set; }

        public System.Data.Entity.DbSet<PAID_PROJECT_02.Models.Sch_Departments> Sch_Departments { get; set; }

        public System.Data.Entity.DbSet<PAID_PROJECT_02.Models.Sch_Inventory> Sch_Inventory { get; set; }

        public System.Data.Entity.DbSet<PAID_PROJECT_02.Models.Sch_Students> Sch_Students { get; set; }

        public System.Data.Entity.DbSet<PAID_PROJECT_02.Models.Sch_Textbooks> Sch_Textbooks { get; set; }
    }
}
