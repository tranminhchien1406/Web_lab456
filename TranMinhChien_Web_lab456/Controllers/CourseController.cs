using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TranMinhChien_Web_lab456.Migrations;
using TranMinhChien_Web_lab456.Models;
using TranMinhChien_Web_lab456.ViewModels;

namespace TranMinhChien_Web_lab456.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        private readonly ApplicationDbContext _dbContext;
        public CourseController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [Authorize]
        public ActionResult Create(CourseViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Categories = _dbContext.Categories.ToList();
                return View("Create", viewModel);
            }    
            var course = new Course
            {
                LecturerId = ApplicationUser.Indentity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                CategogryId = viewModel.Category,
                Place = viewModel.Place
            };
            _dbContext.Course.Add(course);
            _dbContext.SaveChanges();
            return View(viewModel);
        }
    }
}