using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
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
		[Authorize]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult StudentProfile(ProfileFormViewModel viewModel)
		{
			// Ensure form validation
			if (!ModelState.IsValid)
			{
				return View("StudentProfile", viewModel);
			}

			var userId = User.Identity.GetUserId();

			// Creat an Event object from the information from the form for the database
			var student = new Student
			{
				Name = viewModel.Name,
				Alias = viewModel.Alias,
				Ability = viewModel.Ability,
				GradeId = viewModel.Grade,
				Origin = viewModel.Origin,
				StudentUserId = userId
			};

			// Add to database
			_context.Students.Add(student);
			_context.SaveChanges();

			return RedirectToAction("StudentInfo", "Student");
		}

		[Authorize]
		public ActionResult StudentInfo()
		{
			var userId = User.Identity.GetUserId();
			var student = _context.Students.FirstOrDefault(s => s.StudentUserId == userId);
			student.Grade = _context.Grades.FirstOrDefault(x => x.Id == student.GradeId);

			return View(student);
		}
	}
}