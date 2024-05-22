using Microsoft.AspNetCore.Components;
using S2_Shop_Manager.UI.State;

namespace S2_Shop_Manager.UI.Components
{
    public partial class InboxCounter
    {
        [Inject]
        public ApplicationState _applicationState { get; set; }

        private int MessageCount;

        protected override void OnInitialized()
        {
            MessageCount = new Random().Next(10);

            _applicationState.NumberOfMessages = MessageCount;
        }
    }
}
