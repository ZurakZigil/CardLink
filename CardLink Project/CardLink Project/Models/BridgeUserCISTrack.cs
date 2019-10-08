namespace CardLink_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BridgeUserCISTrack
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TrackID { get; set; }

        public bool? IsActive { get; set; }

        public virtual CISTrack CISTrack { get; set; }

        public virtual UserTable UserTable { get; set; }
    }
}
