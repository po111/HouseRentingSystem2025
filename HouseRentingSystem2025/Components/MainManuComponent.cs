using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem2025.Components
{
    public class MainManuComponent: ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult > (View());
        }
    }
}
