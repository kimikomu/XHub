using System;
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
			// Seed Event Types
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

			// Seed Events
			context.Events.AddOrUpdate(
				e => e.Id,
				new Event()
				{
					Id = 1,
					DateTime = new DateTime(2017, 8, 1, 10, 00, 00),
					EventLocation = "The Mean Bean",
					EventTypeId = 1,
					Description = "Come hang with me at our local coffee joint. If you haven't been, it's awesome! " +
						            "I've seen a few new faces around and would love to get to know you before the " +
						            "school year starts. Hope to see you there! -Jubilee",
					EventName = "Coffee Hang Out",
					IsCanceled = false
				},
				new Event()
				{
					Id = 2,
					DateTime = new DateTime(2017, 7, 31, 14, 00, 00),
					EventLocation = "Hedge Maze",
					EventTypeId = 3,
					Description = "Attention All Teleporters! Come join us for a little teleportation practice and " +
					              "skill sharing. If you are new this year, and have this ability, join our club! " +
					              "We'd love to have you! Non-teleporters are free to come hang out and watch.",
					EventName = "Teleportation Practice",
					IsCanceled = false
				},
				new Event()
				{
					Id = 11,
					DateTime = new DateTime(2017, 8, 5, 19, 00, 00),
					EventLocation = "Dormitories",
					EventTypeId = 8,
					Description = "ALL STUDENTS. There will be an attack drill in the evening of Aug 5th. Be prepared to" +
					              " make your way to your designated safe zones. Teachers will be enemies. Prepare to " +
					              "evade them. If you are caught, make your way to the cafetiria. These drills are " +
					              "important and should be taken seriously.",
					EventName = "Attack Drill - MUST READ",
					IsCanceled = false
				},
				new Event()
				{
					Id = 12,
					DateTime = new DateTime(2017, 8, 16, 8, 00, 00),
					EventLocation = "Atrium",
					EventTypeId = 7,
					Description = "Welcome back to class students! We will have a brief meeting in the atrium before " +
					              "you head off to your first period. Looking forward to a good year. - Prof. X",
					EventName = "First Day of Classes",
					IsCanceled = false
				},
				new Event()
				{
					Id = 13,
					DateTime = new DateTime(2017, 8, 10, 22, 00, 00),
					EventLocation = "Observation Tower",
					EventTypeId = 2,
					Description = "Anyone taking astronomy this year can score a little extra credit before classes " +
					              "start by attending this event. A few of the staff members will be watching from " +
					              "the observation tower as well. Alien students are especially encouraged to join, " +
					              "as varrying perspectives on celestial movement would be welcomed and appreciated." +
					              " - Ms. Frost",
					EventName = "Meteor Shower",
					IsCanceled = false
				},
				new Event()
				{
					Id = 14,
					DateTime = new DateTime(2017, 8, 12, 6, 00, 00),
					EventLocation = "Danger Room",
					EventTypeId = 6,
					Description = "Student who are also X-men are not excused from this practice because it is summer " +
					              "break. I'm looking at you, Bobby. -Logan",
					EventName = "X-men Practice",
					IsCanceled = false
				},
				new Event()
				{
					Id = 15,
					DateTime = new DateTime(2017, 8, 8, 11, 00, 00),
					EventLocation = "Basketball Court",
					EventTypeId = 1,
					Description = "Friendly game. All are welcome.",
					EventName = "Basketball Game",
					IsCanceled = true
				},
				new Event()
				{
					Id = 16,
					DateTime = new DateTime(2017, 8, 10, 11, 00, 00),
					EventLocation = "Basketball Court",
					EventTypeId = 1,
					Description = "Friendly game. All are welcome.",
					EventName = "Basketball Game - Rescheduled",
					IsCanceled = false
				}
				);

		}
	}
}
