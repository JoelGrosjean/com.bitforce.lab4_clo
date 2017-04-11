namespace com.bitforce.lab4_clo.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CLOContext : DbContext
    {
        public CLOContext()
            : base("name=CLOContext")
        {
        }

        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<ServiceArea> ServiceAreas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>()
                .Property(e => e.Cost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.Events)
                .WithRequired(e => e.Activity)
                .HasForeignKey(e => e.Activity_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceArea>()
                .HasMany(e => e.Events)
                .WithRequired(e => e.ServiceArea)
                .WillCascadeOnDelete(false);
        }
    }
}
