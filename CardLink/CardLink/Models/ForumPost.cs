namespace CardLink_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ForumPost")]
    public partial class ForumPost
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ForumPost()
        {
            ForumPost1 = new HashSet<ForumPost>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ForumPostID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime Date { get; set; }

        public int ParentForumPost { get; set; }

        public bool IsReply { get; set; }

        public bool IsAnswerToQuestion { get; set; }

        public bool IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ForumPost> ForumPost1 { get; set; }

        public virtual ForumPost ForumPost2 { get; set; }

        public virtual UserTable UserTable { get; set; }
    }
}
