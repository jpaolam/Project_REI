using Microsoft.AspNetCore.Components;

namespace Project.Components.Layout
{
    public partial class MainLayout
    {
        [Inject]
        private NavigationManager NavigationManager { get; set; }

        private void NavigateToPage(string page)
        {
            NavigationManager.NavigateTo($"/{page}");
        }
    }
}
