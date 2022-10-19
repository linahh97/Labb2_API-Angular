using Microsoft.EntityFrameworkCore;

namespace Labb2_API_Angular.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Employees
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = Guid.NewGuid(),
                FirstName = "Yasmin",
                LastName = "Larian",
                PersonalNumber = "9708191229",
                Email = "pretty_princess10@gmail.com",
                PhoneNumber = "0751231234",
                Address = "Kungsgatan 1",
                Gender = "Female",
                Salary = 34000,
                DepartmentId = 1
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = Guid.NewGuid(),
                FirstName = "Sasha",
                LastName = "Mason",
                PersonalNumber = "9610217483",
                Email = "bunny_boo@gmail.com",
                PhoneNumber = "0735890521",
                Address = "Riksbyvägen 43",
                Gender = "Female",
                Salary = 34200,
                DepartmentId = 2
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = Guid.NewGuid(),
                FirstName = "Cloe",
                LastName = "Santon",
                PersonalNumber = "9702235461",
                Email = "angel85@gmail.com",
                PhoneNumber = "0709876543",
                Address = "Drottninggatan 6b",
                Gender = "Female",
                Salary = 33700,
                DepartmentId = 3
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = Guid.NewGuid(),
                FirstName = "Jade",
                LastName = "Hunter",
                PersonalNumber = "9607111829",
                Email = "koolkat4@gmail.com",
                PhoneNumber = "0721228563",
                Address = "Storgatan 32a",
                Gender = "Female",
                Salary = 33200,
                DepartmentId = 4
            });

            //Departments
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 1, DepartmentName = "Management" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 2, DepartmentName = "Human Resources" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 3, DepartmentName = "Marketing and Sales" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 4, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 5, DepartmentName = "Finance" });
        }
    }
}
