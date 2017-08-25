using System.Web.Mvc;

namespace Xhub.Controllers
{
	public class ClassesController : Controller
	{
		// GET: Classes
//		public ActionResult Index()
//		{
//			var model = from c in _classes
//				orderby c.Id
//				select c;
//
//			return View(model);
//		}

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
