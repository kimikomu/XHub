using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Xhub.Models;
using Xhub.ViewModels;

namespace Xhub.Controllers
{
	public class EventsController : Controller
	{
		// Set up the DbContext
		private readonly ApplicationDbContext _context;

		public EventsController()
		{
			_context = new ApplicationDbContext();
		}

		// Return a view model with a populated Events list
		[Authorize]
		public ActionResult Add()
		{
			var viewModel = new EventsFormViewModel
			{
				Heading = "Create an Event",
				EventTypes = _context.EventTypes.ToList()
			};

			return View("EventForm", viewModel);
		}

		[Authorize]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Add(EventsFormViewModel viewModel)
		{
			// Ensure form validation
			if (!ModelState.IsValid || viewModel.DateTimeAvailable() == false)
			{
				ModelState.AddModelError("Date", "The date/time is not available.");
				ModelState.AddModelError("Time", "The date/time is not available.");
				
				// Events list is not null
				viewModel.EventTypes = _context.EventTypes.ToList();

				return View("EventForm", viewModel);
			}

			// Creat an Event object from the information from the form for the database
			var e = new Event
			{
				EventOwnerId = User.Identity.GetUserId(),
				DateTime = viewModel.GetDateTime(),
				EventTypeId = viewModel.EventType,
				EventLocation = viewModel.EventLocation,
				EventName = viewModel.EventName,
				Description = viewModel.Description
			};

			// Add to database
			_context.Events.Add(e);
			_context.SaveChanges();

			return RedirectToAction("MyEvents", "Events");
		}

		// View for upcoming events
		public ActionResult AllEvents()
		{
			var upcomingEvents = _context.Events
				.OrderBy(e => e.DateTime)
				.Include(e => e.Attendances);
			
			return View(upcomingEvents);
		}

		// Get the future events with the user id as the event owner id
		[Authorize]
		public ActionResult MyEvents()
		{
			var userId = User.Identity.GetUserId();

			var myEvents = _context.Events
				.Where(e => e.EventOwnerId == userId && e.DateTime > DateTime.Now)
				.OrderBy(e => e.DateTime)
				.ToList();

			return View(myEvents);
		}

		// Get the events the user is attending and go to view
		public ActionResult Attending()
		{
			var userId = User.Identity.GetUserId();

			var eventsImAttending = _context.Attendances
				.Where(a => a.AttendeeId == userId)
				.Select(a => a.Event)
				.OrderBy(e => e.DateTime)
				.ToList();

			return View(eventsImAttending);
		}

		// Return a view model with a populated Events list
		[Authorize]
		public ActionResult Edit(int eventId)
		{
			var userId = User.Identity.GetUserId();
			var eVent = _context.Events.Single(e => e.Id == eventId && e.EventOwnerId == userId);

			var viewModel = new EventsFormViewModel
			{
				Id = eVent.Id,
				Heading = "Edit an Event",
				EventTypes = _context.EventTypes.ToList(),
				EventName = eVent.EventName,
				Date = eVent.DateTime.ToString("d MMM yyyy"),
				Time = eVent.DateTime.ToString("HH:mm"),
				EventLocation = eVent.EventLocation,
				Description = eVent.Description,
				EventType = eVent.EventTypeId
			};

			return View("EventForm", viewModel);
		}

		[Authorize]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(EventsFormViewModel viewModel)
		{
			// Ensure form validation
			if (!ModelState.IsValid)
			{
				// Events list is not null
				viewModel.EventTypes = _context.EventTypes.ToList();

				return View("EventForm", viewModel);
			}

			var userId = User.Identity.GetUserId();

			// Get the event to change
			var eVent = _context.Events.Single(e => e.Id == viewModel.Id && e.EventOwnerId == userId);

			// Event properties are updated
			eVent.EventName = viewModel.EventName;
			eVent.EventLocation = viewModel.EventLocation;
			eVent.DateTime = viewModel.GetDateTime();
			eVent.Description = viewModel.Description;
			eVent.EventTypeId = viewModel.EventType;

			// Update database
			_context.SaveChanges();

			return RedirectToAction("MyEvents", "Events");
		}

		// Return an event's details to view
		[Authorize]
		public ActionResult Details(int? eventId)
		{
			// Avoid null exception
			if (eventId == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}

			var eVent = _context.Events
				.Include(e => e.Attendances)
				.Single(e => e.Id == eventId);
			eVent.EventType = _context.EventTypes.Single(e => e.Id == eVent.EventTypeId);

			return View(eVent);
		}

		[Authorize]
		public ActionResult MyEventDetails(int? eventId)
		{
			// Avoid null exception
			if (eventId == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}

			var eVent = _context.Events
				.Include(e => e.Attendances)
				.Single(e => e.Id == eventId);
			eVent.EventType = _context.EventTypes.Single(e => e.Id == eVent.EventTypeId);

			return View(eVent);
		}

		public ActionResult Cancel(int eventId)
		{
			var userId = User.Identity.GetUserId();
			var eVent = _context.Events.Single(e => e.Id == eventId && e.EventOwnerId == userId);
			eVent.IsCanceled = true;
			_context.SaveChanges();

			return RedirectToAction("MyEvents");
		}
	}
}