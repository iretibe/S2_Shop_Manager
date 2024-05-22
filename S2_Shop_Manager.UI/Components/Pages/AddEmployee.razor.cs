using Microsoft.AspNetCore.Components;
using S2_Shop_Manager.Shared.Domain;
using S2_Shop_Manager.Web.Client;

namespace S2_Shop_Manager.UI.Components.Pages
{
    public partial class AddEmployee
    {
        [SupplyParameterFromForm]
        public Employee employeeAdd { get; set; }

        [Inject]
        public IEmployeeRepository employeeRepository { get; set; }

        protected string Message = string.Empty;
        protected bool IsSaved = false;

        protected override void OnInitialized()
        {
            employeeAdd ??= new();
        }

        private async Task OnSubmit()
        {
            await employeeRepository.AddEmployee(employeeAdd);
            IsSaved = true;
            Message = "Employee added successfully!";
        }
    }
}
