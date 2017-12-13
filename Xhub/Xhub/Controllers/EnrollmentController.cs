using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;
using Xhub.Models;

namespace Xhub.Controllers
{
    public class EnrollmentController : Controller
    {
        // Set up the DbContext
        private readonly ApplicationDbContext _context;

        public EnrollmentController()
        {
            _context = new ApplicationDbContext();
        }
        

        // POST: Enrollment/Create
        public ActionResult Enroll(int classId)
        {
            var userId = User.Identity.GetUserId();

            // If the student is already enrolled
            if (_context.Enrollments.Any(e => e.EnrolleeId == userId && e.ClassId == classId))
            {
                return RedirectToAction("AllClasses", "Classes");
            }

            var enrollment = new Enrollment()
            {
                ClassId = classId,
                EnrolleeId = userId
            };

            _context.Enrollments.Add(enrollment);
            _context.SaveChanges();

            return RedirectToAction("AllClasses", "Classes");
        }

        // GET: Enrollment/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Enrollment/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Enrollment/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Enrollment/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
