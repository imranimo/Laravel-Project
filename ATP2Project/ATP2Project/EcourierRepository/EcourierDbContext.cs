using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcourierRepository
{
    public class EcourierDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<DelevaryInfo> DelevaryInfos { get; set; }
            
    }
}
