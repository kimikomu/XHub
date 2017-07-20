using Xhub.Models;

namespace Xhub.Migrations
{
	using System.Data.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<Xhub.Models.ApplicationDbContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(Xhub.Models.ApplicationDbContext context)
		{
			context.EventTypes.AddOrUpdate(
				t => t.Id,
				new EventType() { Id = 0, Type = "Class Requirement"},
				new EventType() { Id = 1, Type = "Just for Fun" },
				new EventType() { Id = 2, Type = "X-tra Credit" },
				new EventType() { Id = 3, Type = "Club Event" },
				new EventType() { Id = 4, Type = "Sport Event" },
				new EventType() { Id = 5, Type = "Field Trip" },
				new EventType() { Id = 6, Type = "Danger Room Event" },
				new EventType() { Id = 7, Type = "School Assembly" },
				new EventType() { Id = 8, Type = "Disaster Drill" },
				new EventType() { Id = 9, Type = "Other" }
				);

		}
	}
}
