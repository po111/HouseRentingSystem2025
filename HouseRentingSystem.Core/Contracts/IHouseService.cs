using HouseRentingSystem2025.Core.Models.Home;

namespace HouseRentingSystem2025.Core.Contracts
{
    public interface IHouseService
    {
        Task<IEnumerable<HouseIndexServiceModel>> LastThreeHousesAsync();
    }
}
