using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.QuickGrid;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using S2_Shop_Manager.Shared.Domain;
using S2_Shop_Manager.Shared.Models;
using S2_Shop_Manager.UI.Contracts.Repositories;
using S2_Shop_Manager.Web.Client;

namespace S2_Shop_Manager.UI.Components.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public int EmployeeId { get; set; }

        public Employee GetEmployee {  get; set; } = new Employee();

        public List<TimeRegistration> GetTimeRegistrations { get; set; } = [];

        [Inject]
        public IEmployeeRepository GetEmployeeRepository { get; set; }

        [Inject]
        public ITimeRegistrationRepository GetTimeRegistrationRepository { get; set; }

        private float itemHeight = 50;
        protected IQueryable<TimeRegistration> itemsQueryable;
        protected int queryableCount = 0;

        public PaginationState pagination = new()
        {
            ItemsPerPage = 10,
        };

        public List<Marker> MapMarkers { get; set; } = new List<Marker>();

        protected override async Task OnInitializedAsync()
        {
            await LoadEmployeeByIdAsync();
            await LoadEmployeeTimeRegistrationsAsync();

            if (GetEmployee.Longitude.HasValue && GetEmployee.Latitude.HasValue)
            {
                MapMarkers = new List<Marker>()
                {
                    new Marker{Description = $"{GetEmployee.FirstName} {GetEmployee.LastName}",
                    ShowPopup = false,
                    X = GetEmployee.Longitude.Value,
                    Y = GetEmployee.Latitude.Value}
                };
            }

            //GetEmployee = MockDataService.Employees.Single(e => e.EmployeeId == EmployeeId);
        }

        public async ValueTask<ItemsProviderResult<TimeRegistration>> LoadTimeRegistrations(ItemsProviderRequest request)
        {
            int totalNumberOfTimeRegistrations = await GetTimeRegistrationRepository.GetTimeRegistrationCountForEmployeeId(EmployeeId);

            var numberOfTimeRegistrations = Math.Min(request.Count, totalNumberOfTimeRegistrations - request.StartIndex);
            var listItems = await GetTimeRegistrationRepository.GetPagedTimeRegistrationsForEmployee(EmployeeId, numberOfTimeRegistrations, request.StartIndex);

            return new ItemsProviderResult<TimeRegistration>(listItems, totalNumberOfTimeRegistrations);
        }

        private async Task LoadEmployeeByIdAsync()
        {
            try
            {
                var employee = await GetEmployeeRepository.GetEmployeeById(EmployeeId);

                GetEmployee = employee;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private async Task LoadEmployeeTimeRegistrationsAsync()
        {
            try
            {
                var employeeTimeRegistration = await GetTimeRegistrationRepository.GetTimeRegistrationsForEmployee(EmployeeId);

                //GetTimeRegistrations = employeeTimeRegistration;
                itemsQueryable = employeeTimeRegistration.AsQueryable();
                queryableCount = itemsQueryable.Count();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void ChangeHolidayState()
        {
            GetEmployee.IsOnHoliday = !GetEmployee.IsOnHoliday;
        }
    }
}
