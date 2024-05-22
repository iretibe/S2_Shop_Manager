using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using S2_Shop_Manager.Shared.Domain;
using S2_Shop_Manager.UI.Contracts.Repositories;
using S2_Shop_Manager.Web.Client;

namespace S2_Shop_Manager.UI.Components.Pages
{
    public partial class EditEmployee
    {
        [Inject]
        public IEmployeeRepository employeeRepository { get; set; }

        [Inject]
        public ICountryRepository countryRepository { get; set; }

        [Inject]
        public IJobCategoryRepository jobCategoryRepository { get; set; }


        [Parameter]
        public int EmployeeId { get; set; }

        [SupplyParameterFromForm]
        public Employee Employee { get; set; } = new();

        public List<Country> Countries { get; set; } = [];
        public List<JobCategory> JobCategories { get; set; } = [];

        protected bool Saved;
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;

        [Inject]
        public NavigationManager navigationManager { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Saved = false;
            await LoadAllCountriesAsync();
            await LoadAllJobCategoriesAsync();
            await LoadEmployeeByIdAsync(EmployeeId);
        }

        private async Task LoadAllCountriesAsync()
        {
            try
            {
                var allCountries = await countryRepository.GetAllCountries();

                Countries = allCountries.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private async Task LoadAllJobCategoriesAsync()
        {
            try
            {
                var allJobCategories = await jobCategoryRepository.GetAllJobCategories();

                JobCategories = allJobCategories.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private async Task LoadEmployeeByIdAsync(int EmployeeId)
        {
            try
            {
                var employee = await employeeRepository.GetEmployeeById(EmployeeId);

                Employee = employee;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected async Task HandleValidSubmit()
        {
            await employeeRepository.UpdateEmployee(Employee);
            Saved = true;
            StatusClass = "alert-success";
            Message = "Employee updated successfully";
        }

        protected void HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "There are some validation errors. Please try again.";
        }

        protected async Task DeleteEmployee()
        {
            await employeeRepository.DeleteEmployee(EmployeeId);

            StatusClass = "alert-success";
            Message = "Employee deleted successfully.";

            Saved = true;
        }

        protected void NavigateToOverview()
        {
            navigationManager.NavigateTo("/employeeoverview");
        }

        private IBrowserFile selectedFile;

        private async void OnInputFileChange(InputFileChangeEventArgs e)
        {
            if (selectedFile is not null)
            {
                var file = selectedFile;
                Stream stream = file.OpenReadStream();
                MemoryStream memoryStream = new ();

                await stream.CopyToAsync(memoryStream);
                stream.Close();

                Employee.ImageName = file.Name;
                Employee.ImageContent = memoryStream.ToArray();
            }

            selectedFile = e.File;
            StateHasChanged();
        }
    }
}
