using HouseRentingSystem2025.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem2025.Infrastructure.Data.SeedDb
{
    internal class AgentConfiguration : IEntityTypeConfiguration<Agent>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Agent> builder)
        {
            var data = new SeedData();

            builder.HasData(new Agent[] {data.Agent});
        }
    }
}
