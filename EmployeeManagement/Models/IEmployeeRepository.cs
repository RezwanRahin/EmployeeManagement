namespace EmployeeManagement.Models;

public interface IEmployeeRepository
{
    Employee GetEmployee(int Id);
    IEnumerable<Employee> GetAllEmployees();
}