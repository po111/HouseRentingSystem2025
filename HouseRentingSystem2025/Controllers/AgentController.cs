using HouseRentingSystem2025.Attributes;
using HouseRentingSystem2025.Core.Contracts;
using HouseRentingSystem2025.Core.Models.Agent;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static HouseRentingSystem2025.Core.Constants.MessageConstants;

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
        [NotAnAgent]
        public async Task<IActionResult> Become()
        {
            var model =  new BecomeAgentFormModel();

            return View(model);
        }

        [HttpPost]
        [NotAnAgent]
        public async Task<IActionResult> Become (BecomeAgentFormModel model)
        {
            var userId = User.Id();

            if (await agentService.UserWithPhoneNumberExistsAsync(model.PhoneNumber))
            {
                ModelState.AddModelError(nameof(model.PhoneNumber),PhoneExists);
            }

            if (await agentService.UserHasRentsAsync(User.Id()))
            {
                ModelState.AddModelError("Error", UserHasRents);
            }

            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            await agentService.CreateAsync(User.Id(), model.PhoneNumber);

            return RedirectToAction(nameof(HouseController.All), "House");
        }
    }
}
