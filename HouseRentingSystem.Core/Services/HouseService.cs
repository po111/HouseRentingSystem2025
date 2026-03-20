using HouseRentingSystem2025.Core.Contracts;
using HouseRentingSystem2025.Core.Models.Home;
using HouseRentingSystem2025.Infrastructure.Data.Common;
using HouseRentingSystem2025.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace HouseRentingSystem2025.Core.Services
{
    public class HouseService : IHouseService
    {
        private readonly IRepository repository;

        public HouseService(IRepository _repository)
        {
            repository = _repository;    
        }
        public async Task<IEnumerable<HouseIndexServiceModel>> LastThreeHouses()
        {
            return await repository
                .AllReadOnly<House>()
                .OrderByDescending(h => h.Id)
                .Take(3)
                .Select(h => new HouseIndexServiceModel()
                {
                    Id = h.Id,
                    ImageUrl = h.ImageUrl,
                    Title = h.Title,
                })
                .ToListAsync();
        }
    }
}
