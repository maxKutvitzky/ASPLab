﻿using Microsoft.EntityFrameworkCore;
using ASPLab.Data.Models;

namespace ASPLab.Data.DB.Context
{
    public class AppDBContent: DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        { }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Category> Category { get; set; }

    }
}
