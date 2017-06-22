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

		// Create
		[Authorize]
		public ActionResult Add()
		{
			// Return a view model with the list of event types from the database for the Add form
			var viewModel = new EventsFormViewModel
			{
				EventTypes = _context.EventTypes.ToList()
			};

			return View(viewModel);
		}

		[Authorize, HttpPost]
		public ActionResult Add(EventsFormViewModel viewModel)
		{
			// Get the Event object parameter information from the view model for the database
			var e = new Event
			{
				EventOwnerId = User.Identity.GetUserId(),
				DateTime = DateTime.Parse($"{viewModel.Date} {viewModel.Time}"),
				EventTypeId = viewModel.EventType,
				EventLocation = viewModel.EventLocation
			};

			// Add to database and save
			_context.Events.Add(e);
			_context.SaveChanges();

			return RedirectToAction("Index", "Home");
		}
	}
}