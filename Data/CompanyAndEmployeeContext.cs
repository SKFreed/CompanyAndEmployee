#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CompanyAndEmployee.Models;

namespace CompanyAndEmployee.Data
{
    public class CompanyAndEmployeeContext : DbContext
    {
        public CompanyAndEmployeeContext (DbContextOptions<CompanyAndEmployeeContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        
        public DbSet<CompanyAndEmployee.Models.Companies> Companies { get; set; }
        public DbSet<CompanyAndEmployee.Models.Employees> Employees { get; set; }
    }
}
