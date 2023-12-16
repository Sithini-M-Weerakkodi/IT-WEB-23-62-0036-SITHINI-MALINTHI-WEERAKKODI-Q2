using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentInfoApp.Module;

namespace StudentInfoApp.Data
{
    public class StudentInfoAppContext : DbContext
    {
        public StudentInfoAppContext (DbContextOptions<StudentInfoAppContext> options)
            : base(options)
        {
        }

        public DbSet<StudentInfoApp.Module.Student> Student { get; set; } = default!;
        public DbSet<StudentInfoApp.Module.Course> Course { get; set; } = default!;
    }
}
