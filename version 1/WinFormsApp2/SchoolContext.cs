using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;

    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=school.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data
            modelBuilder.Entity<Subject>().HasData(
                new Subject { Id = 1, Name = "Математика" },
                new Subject { Id = 2, Name = "Русский язык" },
                new Subject { Id = 3, Name = "Литература" },
                new Subject { Id = 4, Name = "История" },
                new Subject { Id = 5, Name = "Физика" }
            );
        }
    }
}
