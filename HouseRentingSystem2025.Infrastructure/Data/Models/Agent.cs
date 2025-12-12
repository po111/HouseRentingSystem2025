using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static HouseRentingSystem2025.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem2025.Infrastructure.Data.Models
{
    public class Agent
    {
        [Key]
        [Comment("House agent identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(AgentPhoneMaxLength)]
        [Comment("Agent phone number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [Comment("Agent user Id")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        public IEnumerable<House> Houses = new List<House>();


    }
}
