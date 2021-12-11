using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Data
{
    public class EMSContext : DbContext
    {
        public EMSContext()
        {

        }
        public EMSContext(DbContextOptions<EMSContext> options) : base(options)
        {

        }

        public DbSet<person> Employees {get;set;} 
       
    }
}
