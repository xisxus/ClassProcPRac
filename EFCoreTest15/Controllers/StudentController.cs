using EFCoreTest15.Contracts;
using EFCoreTest15.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace EFCoreTest15.Controllers
{
    public class StudentController : Controller
    {
      private readonly AppDbContext _db;
     private readonly IStudent _student;

        public StudentController(AppDbContext db, IStudent student)
        {
            _db = db;
            _student = student;
        }
        public IActionResult Index()
        {
            var ssd = _db.Students;
            return View(ssd);
            
        }
      
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddStudent(Student student)
        {
            var response = await _student.AddStudent(student);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            
            return View(_student.GetStudentByID(id));
        }

        [HttpPost]
        public async Task<IActionResult> UpdateStudent(int id, Student updatedStudent)
        {
            if (id != updatedStudent.Id)
            {
                return BadRequest();
            }

            var student = await _student.GetStudentByID(id);
            if (student == null)
            {
                return NotFound();
            }

            _student.UpdateStudent(id, updatedStudent);
           

            return RedirectToAction(nameof(Index));
        }

        [AcceptVerbs("GET", "POST")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
           await _student.DeleteStudent(id);
           return RedirectToAction(nameof(Index));
      
        }



    }
}
