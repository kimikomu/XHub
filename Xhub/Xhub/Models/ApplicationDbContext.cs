using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Xhub.Models
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public DbSet<Event> Events { get; set; }
		public DbSet<EventType> EventTypes { get; set; }

		public ApplicationDbContext()
			: base("DefaultConnection", throwIfV1Schema: false)
		{
		}

		public static ApplicationDbContext Create()
		{
			return new ApplicationDbContext();
		}
	}
}