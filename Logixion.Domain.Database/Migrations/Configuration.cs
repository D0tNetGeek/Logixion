using Logixion.Domain.Entities;
using System.Data.Entity.Migrations;
namespace Logixion.Domain.Database.Migrations
{  
    
    internal sealed class Configuration : DbMigrationsConfiguration<Logixion.Domain.Database.LogixionDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;            
        }

        protected override void Seed(Logixion.Domain.Database.LogixionDbContext context)
        {
            context.Employees.AddOrUpdate(new Employee
            {
                Achievements = "Developer",
                FirstName = "Faisal",
                Id = 1,
                LastName = "Shahzad",
                Title = "Mr."
            });
            context.Employees.AddOrUpdate(new Employee
            {
                Achievements = "Developer",
                FirstName = "Talha",
                Id = 1,
                LastName = "Umair",
                Title = "Mr."
            });
        }
    }
}
