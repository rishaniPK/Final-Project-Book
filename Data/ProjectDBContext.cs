using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Data
{
    public class ProjectDBContext : DbContext
    {
        public ProjectDBContext (DbContextOptions<ProjectDBContext> options)
            : base(options)
        {
        }

        public DbSet<Project.Models.Books> Books { get; set; }

        public DbSet<Project.Models.Customer> Customer { get; set; }

        public DbSet<Project.Models.Review> Review { get; set; }
    }
}
