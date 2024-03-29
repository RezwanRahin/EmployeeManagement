using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models;

public class SQLEmployeeRepository : IEmployeeRepository
{
    private readonly AppDbContext context;
    private readonly ILogger<SQLEmployeeRepository> _logger;

    public SQLEmployeeRepository(AppDbContext context, ILogger<SQLEmployeeRepository> logger)
    {
        this.context = context;
        _logger = logger;
    }
    
    public Employee GetEmployee(int Id)
    {
        _logger.LogTrace("Trace Log");
        _logger.LogDebug("Debug Log");
        _logger.LogInformation("Information Log");
        _logger.LogWarning("Warning Log");
        _logger.LogError("Error Log");
        _logger.LogCritical("Critical Log");

        return context.Employees.Find(Id);
    }

    public IEnumerable<Employee> GetAllEmployees()
    {
        return context.Employees;
    }

    public Employee Add(Employee employee)
    {
        context.Employees.Add(employee);
        context.SaveChanges();
        return employee;
    }

    public Employee Update(Employee employeeChanges)
    {
        var employee = context.Employees.Attach(employeeChanges);
        employee.State = EntityState.Modified;
        context.SaveChanges();
        return employeeChanges;
    }

    public Employee Delete(int Id)
    {
        Employee employee = context.Employees.Find(Id);
        if (employee != null)
        {
            context.Employees.Remove(employee);
            context.SaveChanges();
        }
        return employee;
    }
}
