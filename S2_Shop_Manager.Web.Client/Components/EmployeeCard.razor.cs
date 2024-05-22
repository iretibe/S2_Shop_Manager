using Microsoft.AspNetCore.Components;
using S2_Shop_Manager.Shared.Domain;

namespace S2_Shop_Manager.Web.Client.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee GetEmployeeCard { get; set; }

        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }

        protected override void OnInitialized()
        {
            if (string.IsNullOrEmpty(GetEmployeeCard.LastName))
            {
                throw new Exception("Last Name cannot be empty!");
            }
        }
    }
}
