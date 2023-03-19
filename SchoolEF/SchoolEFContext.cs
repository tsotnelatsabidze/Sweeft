using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolEF
{
    public class SchoolEFContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<TeacherPupil> TeacherPupil { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LATSW510-2\\SQLEXPRESS;Initial Catalog=EFCoreDB;User ID=sa;Password=123456;TrustServerCertificate=Yes");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasKey(x => x.ID);
            modelBuilder.Entity<Pupil>().HasKey(x => x.ID);

            modelBuilder.Entity<TeacherPupil>().HasKey(sc => new { sc.TeacherID, sc.PupilID });

            modelBuilder.Entity<Teacher>().HasData(new Teacher() 
            {
                ID = 1,
                Name = "Gela",
                LastName = "Gelashvili",
                Sex = "Male",
                Subject = "Math",
            });

            modelBuilder.Entity<Teacher>().HasData(new Teacher()
            {
                ID = 2,
                Name = "Beka",
                LastName = "Latsabidze",
                Sex = "Male",
                Subject = "Software",
            });

            modelBuilder.Entity<Pupil>().HasData(new Pupil()
            {
                ID = 1,
                Name = "Giorgi",
                LastName = "Gelashvili",
                Sex = "Male",
                Class = "8a",
            });

            modelBuilder.Entity<TeacherPupil>().HasData(new TeacherPupil() 
            {
                TeacherID = 1,
                PupilID = 1
            });

            base.OnModelCreating(modelBuilder);
        }

    }
}
