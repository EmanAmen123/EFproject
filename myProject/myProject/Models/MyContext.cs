using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace myProject.Models
{
    public class MyContext:DbContext 
    {
        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<MedicalRecords> Medical { get; set; }
        public virtual DbSet<Adoptions> Adoptions { get; set; }
        public virtual DbSet<Pets> Pets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=DESKTOP-AFGBK7M\\SQLEXPRESS01;Database=EFproject;Trusted_Connection=True;Trust Server Certificate=True;");
        }
    }
}
