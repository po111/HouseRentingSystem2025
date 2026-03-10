using HouseRentingSystem2025.Core.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem2025.Core.Contracts.House
{
    public interface IHouseService
    {
        Task<IEnumerable<HouseIndexServiceModel>> LastThreeHouses();
    }
}
