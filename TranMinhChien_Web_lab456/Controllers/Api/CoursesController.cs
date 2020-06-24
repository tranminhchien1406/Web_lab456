using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TranMinhChien_Web_lab456.Controllers.Api
{
    public class CoursesController : ApiConTroller
    {
        public ApplicationDbContext _dbContext { get; set; }
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpDelete]
        public IHttpActionResult Cancel(int id)
        {
            var userId = User.Identity.GetUerId();
            var course = _dbContext.Courses.Single(c => c.Id == id && c.LecturerId == userId);
            if (course.IsCancel)
                return NotFound();
            course.IsCanceled = true;
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}