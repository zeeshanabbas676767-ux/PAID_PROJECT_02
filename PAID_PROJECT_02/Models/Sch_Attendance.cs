namespace PAID_PROJECT_02.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sch_Attendance
    {
        public int Id { get; set; }

        public int? StudentId { get; set; }

        public int? ClassId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AttendanceDate { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public bool? Deleted { get; set; }

        public bool? Active { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual Sch_Classes Sch_Classes { get; set; }

        public virtual Sch_Students Sch_Students { get; set; }
    }
}
