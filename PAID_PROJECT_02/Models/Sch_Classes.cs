namespace PAID_PROJECT_02.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sch_Classes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sch_Classes()
        {
            Sch_Attendance = new HashSet<Sch_Attendance>();
        }

        public int Id { get; set; }

        public int? CourseId { get; set; }

        public int? StudentId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EnrollmentDate { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sch_Attendance> Sch_Attendance { get; set; }

        public virtual Sch_Courses Sch_Courses { get; set; }

        public virtual Sch_Students Sch_Students { get; set; }
    }
}
