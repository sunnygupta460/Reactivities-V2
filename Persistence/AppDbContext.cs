﻿using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    //public class AppDbContext(DBContextOptions options) : DbContext(options)
    //{
    //    //public required DbSet<Activity> Activities { get; set; }
    //}
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public required DbSet<Activity> Activities { get; set; }
    }
}