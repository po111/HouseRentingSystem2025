using HouseRentingSystem2025.Core.Contracts;
using HouseRentingSystem2025.Core.Models.Home;
using HouseRentingSystem2025.Core.Models.House;
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

        public async Task<IEnumerable<HouseCategoryServiceModel>> AllCategoriesAsync()
        {
            return await repository
                .AllReadOnly<Category>()
                .Select(c => new HouseCategoryServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToListAsync();
        }

        public async Task<bool> CategoryExistsAsync(int categoryId)
        {
            return await repository.AllReadOnly<Category>()
                .AnyAsync(c=>c.Id == categoryId);
        }

        public async Task<int> CreateAsync(HouseFormModel model, int agentId)
        {
            House house =  new House()
            {
                Address = model.Address,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                AgentId = agentId,
                CategoryId = model.CategoryId,
                PricePerMonth = model.PricePerMonth,
                Title = model.Title,

            };

            await repository.AddAsync(house);
            await repository.SaveChangesAsync();    

            return house.Id;
        }

        public async Task<IEnumerable<HouseIndexServiceModel>> LastThreeHousesAsync()
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
