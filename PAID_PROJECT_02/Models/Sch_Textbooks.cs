namespace PAID_PROJECT_02.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sch_Textbooks
    {
        public int Id { get; set; }

        public int? CourseId { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public string Description { get; set; }

        [StringLength(50)]
        public string ISBN { get; set; }

        public decimal? Price { get; set; }

        public bool? Deleted { get; set; }

        public bool? Active { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual Sch_Courses Sch_Courses { get; set; }
    }
}
