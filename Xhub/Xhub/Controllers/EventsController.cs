using System;
using System.Linq;
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
				EventTypes = _context.EventTypes.ToList()
			};

			return View(viewModel);
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

				return View("Add", viewModel);
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
			var upcomingEvents = _context.Events;
			return View(upcomingEvents);
		}

		// Get the events the user has created and go to the view
		[Authorize]
		public ActionResult MyEvents()
		{
			var userId = User.Identity.GetUserId();

			var myEvents = _context.Events
				.Where(e => e.EventOwnerId == userId && e.DateTime > DateTime.Now)
				.ToList();

			return View(myEvents);
		}

		// Get the events the user is attending and go to view
		public ActionResult Attending()
		{
			var userId = User.Identity.GetUserId();

			var eventsImAttending = _context.Attendances.Where(a => a.AttendeeId == userId).Select(a => a.Event).ToList();

			return View(eventsImAttending);
		}
	}
}