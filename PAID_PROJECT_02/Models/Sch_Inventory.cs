namespace PAID_PROJECT_02.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sch_Inventory
    {
        public int Id { get; set; }

        public int? ResourceId { get; set; }

        [StringLength(50)]
        public string ResourceName { get; set; }

        public bool? InStock { get; set; }

        public int? Quantity { get; set; }

        [StringLength(50)]
        public string Rack { get; set; }

        [StringLength(50)]
        public string Shelf { get; set; }

        [StringLength(50)]
        public string Condition { get; set; }

        public bool? Deleted { get; set; }

        public bool? Active { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
