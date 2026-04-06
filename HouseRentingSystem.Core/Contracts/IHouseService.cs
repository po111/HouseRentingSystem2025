using HouseRentingSystem2025.Core.Models.Home;
using HouseRentingSystem2025.Core.Models.House;
using Microsoft.Data.SqlClient;

namespace HouseRentingSystem2025.Core.Contracts
{
    public interface IHouseService
    {
        Task<IEnumerable<HouseIndexServiceModel>> LastThreeHousesAsync();

        Task<IEnumerable<HouseCategoryServiceModel>> AllCategoriesAsync();

        Task<bool> CategoryExistsAsync(int categoryId);

        Task<int> CreateAsync(HouseFormModel model, int agentId);
    }
}
