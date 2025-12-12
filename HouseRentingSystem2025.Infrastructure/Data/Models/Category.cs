using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using static HouseRentingSystem2025.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem2025.Infrastructure.Data.Models
{
    [Comment("House category")]
    public class Category
    {
        [Key]
        [Comment("Category Identifier")]
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Category name")]
        public string Name { get; set; } =  string.Empty;

        public IEnumerable<House> Houses { get; init; } =  new List<House>();


    }
}
