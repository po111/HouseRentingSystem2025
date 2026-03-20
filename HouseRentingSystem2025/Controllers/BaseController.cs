using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem2025.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        
    }
}
