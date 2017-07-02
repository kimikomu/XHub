using System.Web.Mvc;
using Xhub.Models;

namespace Xhub.Controllers
{
	public class HomeController : Controller
	{
		private readonly ApplicationDbContext _context;

		public HomeController()
		{
			_context = new ApplicationDbContext();
		}

		// Homepage is a list of upcoming events
		public ActionResult Index()
		{
			var upcomingEvents = _context.Events;
			return View(upcomingEvents);
		}
	}
}