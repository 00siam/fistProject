using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myFirstProject.Models;

namespace myFirstProject.Data
{
    public class myFirstProjectContext : DbContext
    {
        public myFirstProjectContext (DbContextOptions<myFirstProjectContext> options)
            : base(options)
        {
        }

        public DbSet<myFirstProject.Models.Student> Student { get; set; } = default!;
    }
}
