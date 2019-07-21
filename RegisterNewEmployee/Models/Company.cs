namespace RegisterNewEmployee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Company")]
    public partial class Company
    {
        [Key]
        public int ComID { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        public int? Size { get; set; }

        [StringLength(50)]
        public string LegalForm { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
