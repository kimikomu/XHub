using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Xhub.Models;

namespace Xhub.Controllers
{
	[Authorize]
	public class AttendanceController : Controller
	{
		// Set up the DbContext
		private readonly ApplicationDbContext _context;

		public AttendanceController()
		{
			_context = new ApplicationDbContext();
		}

		public ActionResult Attend(int eventId)
		{
			var userId = User.Identity.GetUserId();

			// If the attendance is already in the database
			if (_context.Attendances.Any(a => a.AttendeeId == userId && a.EventId == eventId))
			{
				// Temporary. Find a better way!
				ModelState.AddModelError("eventId", "You are already scheduled to attend that event.");
				
				// Temporary redirect to Sorry page
				return RedirectToAction("Sorry");
			}

			var attendance = new Attendance
			{
				AttendeeId = userId,
				EventId = eventId
			};

			// Add attendance to database
			_context.Attendances.Add(attendance);
			_context.SaveChanges();

			return RedirectToAction("Attending", "Events");
		}

		// Temporary Sorry page
		public ActionResult Sorry()
		{
			return View();
		}
	}
}