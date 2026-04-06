using HouseRentingSystem2025.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem2025.Infrastructure.Constants.DataConstants;
using static HouseRentingSystem2025.Core.Constants.MessageConstants;

namespace HouseRentingSystem2025.Core.Models.House
{
    public class HouseFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(HouseTitleMaxLength,
            MinimumLength = HouseTitleMinLength,
            ErrorMessage = LengthMessage)]
        public string Title { get; set; } = null!;


        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(HouseAddressMaxLength,
            MinimumLength = HouseAddressMinLength,
            ErrorMessage = LengthMessage)]
        public string Address { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(HouseDescriptionMaxLength,
            MinimumLength = HouseDescriptionMinLength,
            ErrorMessage = LengthMessage)]
        public string Description { get; set; } = null!;

        [Required]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Range(typeof(decimal),
            HousePriceMinNumber, 
            HousePriceMaxNumber, 
            ConvertValueInInvariantCulture = true,
            ErrorMessage = "Price per month must be a positive number and less than {2}")]
        [Display(Name = "Price Per Month")]
        public decimal  PricePerMonth { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public IEnumerable<HouseCategoryServiceModel> Categories { get; set; } = 
            new List<HouseCategoryServiceModel>();  
    }
}
