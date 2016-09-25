namespace Ajax.Data.Migrations
{
    using Ajax.Data.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Ajax.Data.EmployeeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Ajax.Data.EmployeeDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Employees.AddOrUpdate(
              new Employee { Name = "Andrew Peters",Salary=100000, CreatedDate=DateTime.Now, Status=true },
              new Employee { Name = "Brice Lambson", Salary = 200000, CreatedDate = DateTime.Now, Status = true },
              new Employee { Name = "Rowan Miller", Salary = 300000, CreatedDate = DateTime.Now, Status = true },
              new Employee { Name = "Brice ambson", Salary = 400000, CreatedDate = DateTime.Now, Status = true },
            new Employee { Name = "Brice Labson", Salary = 500000, CreatedDate = DateTime.Now, Status = true },
            new Employee { Name = "Brice Laon", Salary = 600000, CreatedDate = DateTime.Now, Status = true },
            new Employee { Name = "Brice son", Salary = 700000, CreatedDate = DateTime.Now, Status = true },
            new Employee { Name = "Be Lambson", Salary = 800000, CreatedDate = DateTime.Now, Status = true },
            new Employee { Name = "Bce Lson", Salary = 900000, CreatedDate = DateTime.Now, Status = true },
            new Employee { Name = "Lambson", Salary = 100000000, CreatedDate = DateTime.Now, Status = true }
            );
            //
            context.SaveChanges();
        }
    }
}
