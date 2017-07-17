using System.Data.Entity;
using System.Linq;
using System.Net;
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


		public ActionResult Delete(int? eventId)
		{
			// Avoid null exception
			if (eventId == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
					
			var userId = User.Identity.GetUserId();
			var attendance = _context.Attendances.Single(a => a.AttendeeId == userId && a.EventId == eventId);

			// Check if attendance exists
			if (attendance == null)
			{
				return HttpNotFound();
			}

			// Delete Attendance from database
			_context.Entry(attendance).State = EntityState.Deleted;
			_context.SaveChanges();

			return RedirectToAction("Attending", "Events");
		}
	}
}