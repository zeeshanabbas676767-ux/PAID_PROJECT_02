namespace PAID_PROJECT_02.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sch_Courses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sch_Courses()
        {
            Sch_Classes = new HashSet<Sch_Classes>();
            Sch_Textbooks = new HashSet<Sch_Textbooks>();
        }

        public int Id { get; set; }

        public int? DepartmentId { get; set; }

        [StringLength(50)]
        public string CourseName { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public string Description { get; set; }

        public int? Credits { get; set; }

        public bool? Active { get; set; }

        public bool? Deleted { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sch_Classes> Sch_Classes { get; set; }

        public virtual Sch_Departments Sch_Departments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sch_Textbooks> Sch_Textbooks { get; set; }
    }
}
