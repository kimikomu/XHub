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
					              " - Dr. McCoy",
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
				});

			// Seed Teachers
			context.Teachers.AddOrUpdate(
				t => t.Id,
				new Teacher()
				{
					Id = 1,
					TeacherFirstName = "Logan",
					TeacherLastName = "Logan",
					TeacherAlias = "Wolverine"
				},
				new Teacher()
				{
					Id = 2,
					TeacherFirstName = "Emma",
					TeacherLastName = "Frost",
					TeacherAlias = "Emma Frost"
				},

				new Teacher()
				{
					Id = 3,
					TeacherFirstName = "Katherine",
					TeacherLastName = "Pryde",
					TeacherAlias = "Shadow Cat"
				},
				new Teacher()
				{
					Id = 4,
					TeacherFirstName = "Henry",
					TeacherLastName = "McCoy",
					TeacherAlias = "Beast"
				},
				new Teacher()
				{
					Id = 5,
					TeacherFirstName = "Scott",
					TeacherLastName = "Summers",
					TeacherAlias = "Cyclops"
				},
				new Teacher()
				{
					Id = 6,
					TeacherFirstName = "Piotr",
					TeacherLastName = "Rasputin",
					TeacherAlias = "Colossus"
				},
				new Teacher()
				{
					Id = 7,
					TeacherFirstName = "Kurt",
					TeacherLastName = "Wagner",
					TeacherAlias = "Nightcrawler"
				},
				new Teacher()
				{
					Id = 8,
					TeacherFirstName = "Ororo",
					TeacherLastName = "Munroe",
					TeacherAlias = "Storm"
				},
				new Teacher()
				{
					Id = 9,
					TeacherFirstName = "Thomas",
					TeacherLastName = "Corsi",
					TeacherAlias = "Tom Corsi"
				});

			// Seed Classes
			context.Classes.AddOrUpdate(
				c => c.ClassName,
				new Class
				{
					Id = 1012,
					ClassName = "Geometry 100",
					TeacherId = 2,
					ClassLocation = "Classroom 4",
					FirstClass = new DateTime(2017, 9, 4, 10, 15, 0),
					SecondClass = new DateTime(2017, 9, 6, 10, 15, 0),
					LengthInMinutes = 60,
					ClassDescription = "Beginning Geometry"
				},
				new Class
				{
					Id = 41,
					ClassName = "CS 300: Web Design",
					TeacherId = 3,
					ClassLocation = "Classroom 6",
					FirstClass = new DateTime(2017, 9, 5, 11, 20, 0),
					SecondClass = new DateTime(2017, 9, 7, 11, 20, 0),
					LengthInMinutes = 60,
					ClassDescription = "We are moving into exciting territory this semester. Topics will include HTML, CSS, " +
										"and a little Javascript. We will also be covering concepts such as mobile-first" +
										"and accessability in applications, as well as good layout practices and design."
				},
				new Class
				{
					Id = 42,
					ClassName = "Combat: Avoiding Death 101",
					TeacherId = 1,
					ClassLocation = "Danger Room",
					FirstClass = new DateTime(2017, 9, 4, 8, 30, 0),
					SecondClass = new DateTime(2017, 9, 6, 8, 30, 0),
					LengthInMinutes = 75,
					ClassDescription = "Avoid death. Learn how to defend yourself."
				},
				new Class
				{
					Id = 43,
					ClassName = "Biology 201",
					TeacherId = 4,
					ClassLocation = "Classroom 3",
					FirstClass = new DateTime(2017, 9, 5, 10, 15, 0),
					SecondClass = new DateTime(2017, 9, 7, 10, 15, 0),
					LengthInMinutes = 60,
					ClassDescription = "We will be branching into two specific areas of science this semester: Zoology and Ecology." +
										"And we will be studying the various mutations that have been discovered within these fields. " +
										"Students, be prepared for several excursions to geological locations where we can get some " +
										"exciting hands-on experience."

				},
				new Class
				{
					Id = 45,
					ClassName = "Art Appreciation",
					TeacherId = 6,
					ClassLocation = "Classroom 8",
					FirstClass = new DateTime(2017, 9, 4, 11, 20, 0),
					SecondClass = new DateTime(2017, 9, 6, 11, 20, 0),
					LengthInMinutes = 60,
					ClassDescription = "Come with an open mind. Leave with an open heart."
				},
				new Class
				{
					Id = 46,
					ClassName = "Cinematic Drama in a Digital Society",
					TeacherId = 7,
					ClassLocation = "Classroom 3",
					FirstClass = new DateTime(2017, 9, 5, 13, 30, 0),
					SecondClass = new DateTime(2017, 9, 7, 13, 30, 0),
					LengthInMinutes = 60,
					ClassDescription = "Let us explore the ways in which drama and theater have evolved in today's digital world."
				},
				new Class
				{
					Id = 47,
					ClassName = "Gym",
					TeacherId = 9,
					ClassLocation = "Danger Room",
					FirstClass = new DateTime(2017, 9, 5, 14, 35, 0),
					SecondClass = new DateTime(2017, 9, 7, 14, 35, 0),
					LengthInMinutes = 60,
					ClassDescription = "Don't be late."
				},
				new Class
				{
					Id = 48,
					ClassName = "Cultural Studies: Diversity in American Social Structures",
					TeacherId = 8,
					ClassLocation = "Classroom 1",
					FirstClass = new DateTime(2017, 9, 5, 8, 45, 0),
					SecondClass = new DateTime(2017, 9, 7, 8, 45, 0),
					LengthInMinutes = 60,
					ClassDescription = "Students, come with questions and be prepared to discuss some touchy subjects in a respectful " +
										"way with your fellow classmates. Opinions and viewpoints are welcome. Disrespect is not."
				},
				new Class
				{
					Id = 49,
					ClassName = "English 200",
					TeacherId = 2,
					ClassLocation = "Classroom 2",
					FirstClass = new DateTime(2017, 9, 4, 13, 30, 0),
					SecondClass = new DateTime(2017, 9, 6, 13, 30, 0),
					LengthInMinutes = 60,
					ClassDescription = "Make sure to have completed your reading assignment over the summer break. There may or may not " +
										"be a quiz."
				},
				new Class
				{
					Id = 50,
					ClassName = "Astronomy",
					TeacherId = 4,
					ClassLocation = "Observation Tower",
					FirstClass = new DateTime(2017, 9, 8, 21, 0, 0),
					SecondClass = new DateTime(2017, 9, 15, 21, 0, 0),
					LengthInMinutes = 60,
					ClassDescription = "Come study the wonders of this demension's universe. We are fortunate this year to have several " +
										"intergalactic special guest speakers."
				});
		}
	}
}
