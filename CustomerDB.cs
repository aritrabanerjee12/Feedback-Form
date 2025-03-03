using ASPCoreWebAppWithAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPCoreWebAppWithAPI
{
    public class CustomerDB : DbContext
    {
        public CustomerDB(DbContextOptions<CustomerDB> options) : base(options)
        {
        }

        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Employee> Employees { get; set; }
        

    }
}
