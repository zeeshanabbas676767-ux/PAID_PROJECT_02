namespace PAID_PROJECT_02.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sch_Students
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sch_Students()
        {
            Sch_Attendance = new HashSet<Sch_Attendance>();
            Sch_Classes = new HashSet<Sch_Classes>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Student_Id { get; set; }

        [StringLength(50)]
        public string Student_Name { get; set; }

        public string Address { get; set; }

        [StringLength(10)]
        public string City { get; set; }

        [StringLength(10)]
        public string Country { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }

        [Column(TypeName = "date")]
        public DateTime Enrollment_Date { get; set; }

        public bool? Active { get; set; }

        public bool? Deleted { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sch_Attendance> Sch_Attendance { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sch_Classes> Sch_Classes { get; set; }
    }
}
