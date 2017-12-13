using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Xhub.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public DbSet<Event> Events { get; set; }
		public DbSet<EventType> EventTypes { get; set; }
		public DbSet<Attendance> Attendances { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Class> Classes { get; set; }
	    public DbSet<Enrollment> Enrollments { get; set; }

		public ApplicationDbContext()
			: base("DefaultConnection", throwIfV1Schema: false)
		{
		}

		public static ApplicationDbContext Create()
		{
			return new ApplicationDbContext();
		}

		// Prevent cascade delete between events and attendances to avoid multiple cascade paths 
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Attendance>()
				.HasRequired(a => a.Event)
				.WithMany(e => e.Attendances)
				.WillCascadeOnDelete(false);

            modelBuilder.Entity<Enrollment>()
                .HasRequired(e => e.Class)
                .WithMany(e => e.Enrollments)
                .WillCascadeOnDelete(false);

			base.OnModelCreating(modelBuilder);
		}
	}
}