using Microsoft.AspNetCore.Components;
using S2_Shop_Manager.Shared.Domain;

namespace S2_Shop_Manager.Web.Client.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee> Employees { get; set; }
        private Employee _selectedEmployee;

        private string Title = "Employee Overview";

        [Inject]
        public IEmployeeRepository GetEmployeeDataService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await GetEmployeeDataService.GetAllEmployees()).ToList();
            //await Task.Delay(2000);
            //Employees = MockDataService.Employees;
        }

        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }
    }
}
