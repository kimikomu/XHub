using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Xhub.Models;

namespace Xhub.Controllers
{
    public class ClassesController : Controller
	{
		private readonly ApplicationDbContext _context;

		public ClassesController()
		{
			_context = new ApplicationDbContext();
		}

		// GET: Classes
		public ActionResult AllClasses()
		{
			var classes = _context.Classes
				.OrderBy(c => c.FirstClass)
				.Include(c => c.Teacher)
				.ToList();
				
			return View(classes);
		}

		// GET: Classes/Details/5
		public ActionResult Details(int id)
		{
			return View("Index");
		}

//		// GET: Classes/Create
//		public ActionResult Create()
//		{
//			return View();
//		}
//
//		// POST: Classes/Create
//		[HttpPost]
//		public ActionResult Create(FormCollection collection)
//		{
//			try
//			{
//				// TODO: Add insert logic here
//
//				return RedirectToAction("Index");
//			}
//			catch
//			{
//				return View();
//			}
//		}
//
//		// GET: Classes/Edit/5
//		public ActionResult Edit(int id)
//		{
//			return View();
//		}
//
//		// POST: Classes/Edit/5
//		[HttpPost]
//		public ActionResult Edit(int id, FormCollection collection)
//		{
//			try
//			{
//				// TODO: Add update logic here
//
//				return RedirectToAction("Index");
//			}
//			catch
//			{
//				return View();
//			}
//		}
//
//		// GET: Classes/Delete/5
//		public ActionResult Delete(int id)
//		{
//			return View();
//		}
//
//		// POST: Classes/Delete/5
//		[HttpPost]
//		public ActionResult Delete(int id, FormCollection collection)
//		{
//			try
//			{
//				// TODO: Add delete logic here
//
//				return RedirectToAction("Index");
//			}
//			catch
//			{
//				return View();
//			}
//		}


	}
}
