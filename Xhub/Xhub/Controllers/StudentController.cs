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
		
		// Return a form with a populated list of grades
		[Authorize]
		public ActionResult CreateProfile()
		{
			var viewModel = new ProfileFormViewModel
			{
				Grades = _context.Grades.ToList(),
				Heading = "Add Your Profile"
			};

			return View("ProfileForm", viewModel);
		}

		// Create a database entry of student
		[Authorize]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult CreateProfile(ProfileFormViewModel viewModel)
		{
			// Ensure form validation
			if (!ModelState.IsValid)
			{
				// Grades list is not null
				viewModel.Grades = _context.Grades.ToList();

				return View("ProfileForm", viewModel);
			}

			var userId = User.Identity.GetUserId();

			// New student object takes the information from the form
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

		// Read the student profile
		[Authorize]
		public ActionResult StudentInfo()
		{
			var userId = User.Identity.GetUserId();
			var student = _context.Students.Single(s => s.StudentUserId == userId);
			student.Grade = _context.Grades.Single(g => g.Id == student.GradeId);

			return View(student);
		}

		// Return a form with the student's information to edit
		[Authorize]
		public ActionResult EditProfile(int id)
		{
			var userId = User.Identity.GetUserId();

			var student = _context.Students.Single(s => s.Id == id && s.StudentUserId == userId);

			var viewModel = new ProfileFormViewModel
			{
				Id = student.Id,
				Grades = _context.Grades.ToList(),
				Heading = "Edit Your Profile",
				Name = student.Name,
				Alias = student.Alias,
				Ability = student.Ability,
				Grade = student.GradeId,
				Origin = student.Origin
			};

			return View("ProfileForm", viewModel);
		}

		// Edit the student profile
		[Authorize]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult EditProfile(ProfileFormViewModel viewModel)
		{
			// Ensure form validation
			if (!ModelState.IsValid)
			{
				// Grades list is not null
				viewModel.Grades = _context.Grades.ToList();

				return View("ProfileForm", viewModel);
			}

			var userId = User.Identity.GetUserId();

			// Student properties are updated by the form
			var student = _context.Students.Single(s => s.Id == viewModel.Id && s.StudentUserId == userId);
			student.Name = viewModel.Name;
			student.Alias = viewModel.Alias;
			student.Ability = viewModel.Ability;
			student.GradeId = viewModel.Grade;
			student.Origin = viewModel.Origin;

			_context.SaveChanges();

			return RedirectToAction("StudentInfo", "Student");
		}
	}
}