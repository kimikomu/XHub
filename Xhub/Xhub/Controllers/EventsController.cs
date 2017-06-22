using System.Linq;
using System.Web.Mvc;
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

		// Action methods
		public ActionResult Add()
		{
			// Create a view model with the list of event types to return
			var viewModel = new EventsFormViewModel
			{
				EventTypes = _context.EventTypes.ToList()
			};

			return View(viewModel);
		}
	}
}