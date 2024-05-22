using Microsoft.AspNetCore.Components;
using S2_Shop_Manager.UI.State;

namespace S2_Shop_Manager.UI.Components.Widgets
{
    public partial class InboxWidget
    {
        [Inject]
        public ApplicationState _applicationState { get; set; }

        public int MessageCount { get; set; } = 0;

        protected override void OnInitialized()
        {
            //MessageCount = new Random().Next(10);
            MessageCount = _applicationState.NumberOfMessages;
        }
    }
}
