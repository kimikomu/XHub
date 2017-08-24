using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Xhub.Models;

namespace Xhub.Controllers
{
	public class ClassesController : Controller
	{
		// GET: Classes
		public ActionResult Index()
		{
			var model = from c in _classes
				orderby c.Id
				select c;

			return View(model);
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


		// Temporary date
		static List<Teacher> _teachers = new List<Teacher>
		{
			new Teacher
			{
				Id = 1,
				TeacherFirstName = "Logan",
				TeacherLastName = "Logan",
				TeacherAlias = "Wolverine"
			},

			new Teacher
			{
				Id = 2,
				TeacherFirstName = "Emma",
				TeacherLastName = "Frost",
				TeacherAlias = "White Queen"
			},

			new Teacher
			{
				Id = 3,
				TeacherFirstName = "Katherine",
				TeacherLastName = "Pryde",
				TeacherAlias = "Shadow Cat"
			}
		};

		static List<Class> _classes = new List<Class>
		{
			new Class
			{
				Id = 1,
				ClassName = "Math",
				TeacherId = 3,
				ClassLocation = "Room 01",
				FirstClass = new DateTime(2017, 9, 4, 10, 0, 0),
				LastClass = new DateTime(2018, 5, 28, 10, 0, 0),
				LengthInMinutes = 60
			},

			new Class
			{
			Id = 2,
			ClassName = "English",
			TeacherId = 2,
			ClassLocation = "Room 02",
			FirstClass = new DateTime(2017, 9, 6, 9, 0, 0),
			LastClass = new DateTime(2018, 5, 30, 9, 0, 0),
			LengthInMinutes = 60
		},

			new Class
			{
				Id = 3,
				ClassName = "Death",
				TeacherId = 1,
				ClassLocation = "Room 03",
				FirstClass = new DateTime(2017, 9, 4, 11, 15, 0),
				LastClass = new DateTime(2018, 5, 28, 11, 15, 0),
				LengthInMinutes = 60
			}
		};
	}
}
