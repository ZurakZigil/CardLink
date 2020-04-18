namespace CardLink_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Meeting")]
    public partial class Meeting
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MeetingID { get; set; }

        public int MentorUserID { get; set; }

        public int MenteeUserID { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        [StringLength(200)]
        public string Occasion { get; set; }

        public bool IsActive { get; set; }

        public virtual UserTable UserTable { get; set; }

        public virtual UserTable UserTable1 { get; set; }
    }
}
