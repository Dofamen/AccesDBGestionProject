using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AccesDBGestionProject.Models;

namespace AccesDBGestionProject.Data
{
    public class DPEdbContext : DbContext
    {
        public DbSet<Departement> departements { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Assignment> assignments { get; set; }

        public DPEdbContext() : base("GPdb")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignment>()
                .HasKey(c => new { c.EmployeeID, c.ProjectID });
        }


    }
}
