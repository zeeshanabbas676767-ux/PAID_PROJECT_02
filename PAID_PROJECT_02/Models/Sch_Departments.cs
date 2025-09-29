namespace PAID_PROJECT_02.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sch_Departments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sch_Departments()
        {
            Sch_Courses = new HashSet<Sch_Courses>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string DepartmentName { get; set; }

        public string Description { get; set; }

        public bool? Deleted { get; set; }

        public bool? Active { get; set; }

        public DateTime? RecordTimeStamp { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sch_Courses> Sch_Courses { get; set; }
    }
}
