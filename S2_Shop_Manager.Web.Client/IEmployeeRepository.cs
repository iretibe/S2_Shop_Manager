using S2_Shop_Manager.Shared.Domain;

namespace S2_Shop_Manager.Web.Client
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int employeeId);
        Task<Employee> AddEmployee(Employee entity);
        Task<Employee> UpdateEmployee(Employee entity);
        Task DeleteEmployee(int employeeId);
    }
}
