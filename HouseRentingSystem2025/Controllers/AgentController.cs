using HouseRentingSystem2025.Core.Contracts;
using HouseRentingSystem2025.Core.Models.Agent;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem2025.Controllers
{
    public class AgentController : BaseController
    {

        private readonly IAgentService agentService;

        public AgentController(IAgentService _agentService)
        {
                agentService = _agentService;
        }
        [HttpGet]
        public async Task<IActionResult> Become()
        {             
            var model =  new BecomeAgentFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Become (BecomeAgentFormModel agent)
        {
            return RedirectToAction(nameof(HouseController.All), "House");
        }
    }
}
