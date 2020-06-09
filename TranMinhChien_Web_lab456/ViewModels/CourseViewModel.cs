using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TranMinhChien_Web_lab456.Models;

namespace TranMinhChien_Web_lab456.ViewModels
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}