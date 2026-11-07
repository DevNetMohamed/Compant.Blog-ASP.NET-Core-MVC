using Compant.Blog.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Compant.Blog.DAL.Data.Contexts
{
    internal class CompanyDbContext : DbContext
    {

        CompanyDbContext() : base( )
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=Comany_Blog; Trasted_Connection= True; TrustServerCertificate = True;");
        }

        public DbSet<Department> Departments { get; set; }
    }
}
