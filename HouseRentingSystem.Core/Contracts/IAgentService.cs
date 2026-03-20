using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem2025.Core.Contracts
{
    public interface IAgentService
    {
        Task<bool> existById(string userId);
    }
}
