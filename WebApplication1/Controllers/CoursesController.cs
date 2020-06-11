using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class CoursesController : Controller
    {
        private readonly     ApplicationDbContext _dbContext;
        public CoursesController()
        
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        
        {
            var viewModel = new CourseViewModels
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create (CourseViewModels viewModels)
    {
        if(!ModelState.IsValid  )
        {
            viewModels.Categories = _dbContext.Categories.ToList();
            return View("Create", viewModels);
        }
        var course = new Course
        {
            LecturerId = User.Identity.GetUserId(),
            DateTime = viewModels.GetDateTime(),
            CategoryId = viewModels.category,
            Place = viewModels.place
        };
        _dbContext.Courses.Add(course);
        _dbContext.SaveChanges();

        return RedirectToAction("Index", "Home");

    }
}