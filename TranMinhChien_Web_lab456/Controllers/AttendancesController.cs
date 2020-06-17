using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TranMinhChien_Web_lab456.Controllers
{
    public class AttendancesController : ApiController
    {
        private ApplicationDbcontext _dbContext;

        public AttendancesController()
        {
            _dbContext = new ApplicationDbcontext();
        }
        [HttpPost]
        public IHttpActionResult Attend([FromBody] int courseId)
        {
            var userId = User.Identity.GetUseeerId();
            if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == courseId))
                return BadRequest("The Attendance Already Exist!");
            var attendance = new Attendace
            {
                CourseId = courseId,
                AttendeeId = userId()
            };
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
