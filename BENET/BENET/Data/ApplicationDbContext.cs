using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BENET.Models;

namespace BENET.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BENET.Models.ExerciseRecommendation> ExerciseRecommendation { get; set; }
        public DbSet<BENET.Models.User> User { get; set; }
        public DbSet<BENET.Models.Admin> Admin { get; set; }
        public DbSet<BENET.Models.Customer> Customer { get; set; }
    }
}
