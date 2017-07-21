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
		
		// Get the form
		[Authorize]
		public ActionResult CreateProfile()
		{
			var viewModel = new ProfileFormViewModel
			{
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
				return View("ProfileForm", viewModel);
			}

			var userId = User.Identity.GetUserId();

			// New student object takes the information from the form
			var student = new Student
			{
				Name = viewModel.Name,
				Alias = viewModel.Alias,
				Ability = viewModel.Ability,
				Grade = viewModel.Grade,
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
			var student = _context.Students.FirstOrDefault(s => s.StudentUserId == userId);

			// Create a profile if one does not exist
			if (student == null)
			{
				return RedirectToAction("CreateProfile");
			}

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
				Heading = "Edit Your Profile",
				Name = student.Name,
				Alias = student.Alias,
				Ability = student.Ability,
				Grade = student.Grade,
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
				return View("ProfileForm", viewModel);
			}

			var userId = User.Identity.GetUserId();

			// Current student is selected for update
			var student = _context.Students.Single(s => s.Id == viewModel.Id && s.StudentUserId == userId);

			// Student properties are updated by the form
			student.Name = viewModel.Name;
			student.Alias = viewModel.Alias;
			student.Ability = viewModel.Ability;
			student.Grade = viewModel.Grade;
			student.Origin = viewModel.Origin;

			_context.SaveChanges();

			return RedirectToAction("StudentInfo", "Student");
		}
	}
}