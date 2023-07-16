using GameStore.Models;

namespace GameStore.Data.Services
{
    public interface IPlatformsService
    {
        Task<IEnumerable<Platforms>> GetAll();
        Platforms GetById(int id);
        void Add(Platforms Platforms);
        Platforms Update(int id, Platforms newPlatforms);
        void Delete(int id);
    }
}
