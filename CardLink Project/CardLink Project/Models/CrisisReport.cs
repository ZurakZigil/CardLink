namespace CardLink_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CrisisReport")]
    public partial class CrisisReport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReportID { get; set; }

        public int? UserID { get; set; }

        [StringLength(50)]
        public string EmailAddress { get; set; }

        public int? PhoneNumber { get; set; }

        [StringLength(25)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime IncidentDate { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Description { get; set; }

        public bool IsActive { get; set; }

        public virtual UserTable UserTable { get; set; }
    }
}
