using Blazored.LocalStorage;
using S2_Shop_Manager.Shared.Domain;
using S2_Shop_Manager.Web.Client.Helpers;
using System.Text.Json;

namespace S2_Shop_Manager.Web.Client.Services
{
    public class ClientEmployeeService : IEmployeeRepository
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorageService;

        public ClientEmployeeService(HttpClient httpClient, ILocalStorageService localStorageService)
        {
            _httpClient = httpClient;
            _localStorageService = localStorageService;
        }

        public Task<Employee> AddEmployee(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            bool employeeExpirationExists = await _localStorageService.ContainKeyAsync(LocalStorageConstants.EmployeesListExpirationKey);
            if (employeeExpirationExists)
            {
                DateTime employeeListExpiration = await _localStorageService.GetItemAsync<DateTime>(LocalStorageConstants.EmployeesListExpirationKey);
                if (employeeListExpiration > DateTime.Now)
                {
                    if (await _localStorageService.ContainKeyAsync(LocalStorageConstants.EmployeesListKey))
                    {
                        return await _localStorageService.GetItemAsync<List<Employee>>(LocalStorageConstants.EmployeesListKey);
                    }
                }
            }

            var list = await JsonSerializer.DeserializeAsync<IEnumerable<Employee>>(await _httpClient.GetStreamAsync("/api/employee"), 
                    new JsonSerializerOptions()
                    {
                        PropertyNameCaseInsensitive = true
                    });

            return list;
        }

        public Task<Employee> GetEmployeeById(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateEmployee(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
