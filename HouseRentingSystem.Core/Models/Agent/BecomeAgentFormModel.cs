using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem2025.Infrastructure.Constants.DataConstants;
using static HouseRentingSystem2025.Core.Constants.MessageConstants;

namespace HouseRentingSystem2025.Core.Models.Agent
{
    public class BecomeAgentFormModel
    {

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(AgentPhoneMaxLength,
            MinimumLength = AgentPhoneMinLength, 
            ErrorMessage = LengthMessage)]
        [Display(Name = "Phone number")]
        [Phone]
        public string PhoneNumber { get; set; } = null!;
    }
}
