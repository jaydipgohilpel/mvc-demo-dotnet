using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mvc_demo.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace mvc_demo.Controllers
{
    public class StudentController1 : Controller
    {
        private readonly StudentDBContext studentDB;

        public StudentController1(StudentDBContext studentDB)
        {
            this.studentDB = studentDB;
        }


        // GET: StudentController1
        public ActionResult Index()
        {
            var studentData = studentDB.Students.ToList();
            return Ok(studentData);
            /*return View(studentData);*/
        }

        // GET: StudentController1/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: StudentController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return NotFound();
            }
        }

        // GET: StudentController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
