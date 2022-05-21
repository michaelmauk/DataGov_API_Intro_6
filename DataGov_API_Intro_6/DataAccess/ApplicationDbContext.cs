﻿using Microsoft.EntityFrameworkCore;
using DataGov_API_Intro_6.Models;
namespace DataGov_API_Intro_6.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        { }

        public DbSet<Models.Parks> Parks { get; set; }
        public DbSet<Park> Park { get; set; }
    }
}
