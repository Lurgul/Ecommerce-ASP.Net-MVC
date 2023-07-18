using GameStore.Models;

namespace GameStore.Data.Services
{
    public interface IPlatformsService
    {
        Task<IEnumerable<Platforms>> GetAllAsync();
        Task<Platforms> GetByIdAsync(int id);
        Task AddAsync(Platforms platform);
        Task<Platforms> UpdateAsync(int id, Platforms newplatform);
        Task DeleteAsync(int id);
    }
}