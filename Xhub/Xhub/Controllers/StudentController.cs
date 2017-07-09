using System.Linq;
using System.Web.Mvc;
using Xhub.Models;
using Xhub.ViewModels;

namespace Xhub.Controllers
{
	public class StudentController : Controller
	{
		private readonly ApplicationDbContext _context;

		public StudentController()
		{
			_context = new ApplicationDbContext();
		}
		
		public ActionResult StudentProfile()
		{
			var viewModel = new ProfileFormViewModel
			{
				Grades = _context.Grades.ToList()
			};

			return View(viewModel);
		}
	}
}