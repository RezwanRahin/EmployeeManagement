using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = 1,
                Name = "Mary",
                Department = Dept.IT,
                Email = "mary@g.com",
                PhotoPath = "path1"
            },
            new Employee
            {
                Id = 2,
                Name = "John",
                Department = Dept.IT,
                Email = "john@g.com",
                PhotoPath = "path2"
            }
        );
    }
}
