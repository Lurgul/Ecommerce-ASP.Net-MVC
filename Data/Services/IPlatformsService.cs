using GameStore.Models;

namespace GameStore.Data.Services
{
    public interface IPlatformsService
    {
        Task<IEnumerable<Platforms>> GetAll();
        Platforms GetById(int id);
        void Add(Platforms platform);
        Platforms Update(int id, Platforms newplatform);
        void Delete(int id);
    }
}