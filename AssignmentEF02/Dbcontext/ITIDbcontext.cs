using AssignmentEF02.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF02.Dbcontext
{
    public class ITIDbcontext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =DESKTOP-5Q5HCPF ; DataBase = ITI ; Trusted_Connection = True ; Encrypt = False");
        }

        public DbSet <Students> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Course_Inst> Course_Insts { get; set; }    

        public DbSet<Instructor> Instructors { get; set; }  

        public DbSet<Department> Departments { get; set; }

        public DbSet<Stud_Course>Stud_Courses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stud_Course>()
                .HasKey(SC => new { SC.Course_ID, SC.Stud_ID });

            modelBuilder.Entity<Course_Inst>()
                .HasKey(CI => new { CI.Course_ID, CI.inst_ID });


            modelBuilder.Entity<Instructor>()
            .HasOne(i => i.Departments)
            .WithMany(d => d.Instructors)
            .HasForeignKey(i => i.Dept_ID)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Department>()
                .HasOne(d => d.Instructor)
                .WithMany()
                .HasForeignKey(d => d.Ins_ID)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
