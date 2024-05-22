using Microsoft.AspNetCore.Components;
using S2_Shop_Manager.Shared.Domain;

namespace S2_Shop_Manager.Web.Client.Components
{
    public partial class QuickViewPopup
    {
        [Parameter]
        public Employee GetEmployeeQuickView { get; set; }

        private Employee _employee;

        protected override void OnParametersSet()
        {
            _employee = GetEmployeeQuickView;

        }

        public void Close()
        {
            _employee = null;
        }
    }
}
