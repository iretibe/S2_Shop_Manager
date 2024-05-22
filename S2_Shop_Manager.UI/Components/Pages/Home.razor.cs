using S2_Shop_Manager.UI.Components.Widgets;

namespace S2_Shop_Manager.UI.Components.Pages
{
    public partial class Home
    {
        public List<Type> Widgets { get; set; } = new List<Type>()
        {
            typeof(EmployeeCountWidget), typeof(InboxWidget)
        };
    }
}
