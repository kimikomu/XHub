using System.Linq;
using System.Web.Mvc;
using Xhub.Models;
using Xhub.ViewModels;

namespace Xhub.Controllers
{
	public class StudentController : Controller
	{
		// Set up the DbContext
		private readonly ApplicationDbContext _context;

		public StudentController()
		{
			_context = new ApplicationDbContext();
		}
		
		// Return a viewmodel with a populated list of grades
		[Authorize]
		public ActionResult StudentProfile()
		{
			var viewModel = new ProfileFormViewModel
			{
				Grades = _context.Grades.ToList()
			};

			return View(viewModel);
		}

		// 
		[HttpPost]
		public ActionResult StudentProfile(ProfileFormViewModel viewModel)
		{
			// Ensure form validation
			if (!ModelState.IsValid)
			{
				return View("StudentProfile", viewModel);
			}

			// Creat an Event object from the information from the form for the database


			// Add to database


			return RedirectToAction("Index", "Home");
		}

	}
}