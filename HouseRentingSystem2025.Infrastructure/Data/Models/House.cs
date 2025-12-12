using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static HouseRentingSystem2025.Infrastructure.Constants.DataConstants;


namespace HouseRentingSystem2025.Infrastructure.Data.Models
{
    [Comment("House to rent")]
    public class House
    {
        [Key]
        [Comment("House Identifier")]
        public int Id { get; init; }

        [Required]
        [MaxLength(HouseTitleMaxLength)]
        [Comment("House title")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(HouseAddressMaxLength)]
        [Comment("House address")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(HouseDescriptionMaxLength)]
        [Comment("House description")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("House image URL")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        //[Range(typeof(decimal), HousePriceMinNumber, HousePriceMaxNumber, ConvertiInInvariantCulture=true)]
        [Column(TypeName ="decimal(18,2)")]
        [Comment("House rent price per month")]
        public decimal PricePerMonth { get; set; }

        [Required]
        [Comment("House category Identifier")]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        [Comment("House agent Identifier")]
        public int AgentId { get; set; }

        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; } = null!;


        [Comment("User Id of the renter")]
        public string? RenterId { get; set; }


    }
}
