using Ajax.Data.Models;
using System.Data.Entity;

namespace Ajax.Data
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext():base("EmployeeConnectionString")
        {

        }
        public DbSet<Employee> Employees { set; get; }
    }
}
