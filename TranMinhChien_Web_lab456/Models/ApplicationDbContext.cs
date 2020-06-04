﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TranMinhChien_Web_lab456.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ApplicationDbContext()
            : base("Defaultconnection", throwIfV1Schema: false)
            {
            }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}