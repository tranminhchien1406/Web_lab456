using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TranMinhChien_Web_lab456.Models;

namespace TranMinhChien_Web_lab456.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourse { get; set; }
        public bool ShowAction { get; set; }
    }
}