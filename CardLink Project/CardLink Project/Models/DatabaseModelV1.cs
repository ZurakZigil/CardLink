namespace CardLink_Project.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseModelV1 : DbContext
    {
        public DatabaseModelV1()
            : base("name=DatabaseModelV1")
        {
        }

        public virtual DbSet<BridgeUserCISTrack> BridgeUserCISTracks { get; set; }
        public virtual DbSet<BridgeUserCours> BridgeUserCourses { get; set; }
        public virtual DbSet<BridgeUserEvent> BridgeUserEvents { get; set; }
        public virtual DbSet<CISTrack> CISTracks { get; set; }
        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<CrisisReport> CrisisReports { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<ForumPost> ForumPosts { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CISTrack>()
                .Property(e => e.Description)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CISTrack>()
                .HasMany(e => e.BridgeUserCISTracks)
                .WithRequired(e => e.CISTrack)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cours>()
                .Property(e => e.CourseName)
                .IsUnicode(false);

            modelBuilder.Entity<Cours>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Cours>()
                .HasMany(e => e.BridgeUserCourses)
                .WithRequired(e => e.Cours)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CrisisReport>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<CrisisReport>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<CrisisReport>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<CrisisReport>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.BridgeUserEvents)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ForumPost>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<ForumPost>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<ForumPost>()
                .HasMany(e => e.ForumPost1)
                .WithRequired(e => e.ForumPost2)
                .HasForeignKey(e => e.ParentForumPost);

            modelBuilder.Entity<Meeting>()
                .Property(e => e.Occasion)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.Ethnicity)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.LGBTQ)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.JobTitle)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.CurrentEmployer)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .HasMany(e => e.BridgeUserCISTracks)
                .WithRequired(e => e.UserTable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserTable>()
                .HasMany(e => e.BridgeUserCourses)
                .WithRequired(e => e.UserTable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserTable>()
                .HasMany(e => e.BridgeUserEvents)
                .WithRequired(e => e.UserTable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserTable>()
                .HasMany(e => e.ForumPosts)
                .WithRequired(e => e.UserTable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserTable>()
                .HasMany(e => e.Meetings)
                .WithRequired(e => e.UserTable)
                .HasForeignKey(e => e.MenteeUserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserTable>()
                .HasMany(e => e.Meetings1)
                .WithRequired(e => e.UserTable1)
                .HasForeignKey(e => e.MentorUserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserType>()
                .Property(e => e.Description)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UserType>()
                .HasMany(e => e.UserTables)
                .WithRequired(e => e.UserType)
                .WillCascadeOnDelete(false);
        }
    }
}
