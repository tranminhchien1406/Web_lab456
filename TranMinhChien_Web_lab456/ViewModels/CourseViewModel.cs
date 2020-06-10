﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TranMinhChien_Web_lab456.Models;

namespace TranMinhChien_Web_lab456.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}