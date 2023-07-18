using GameStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GameStore.Data.Services
{
    public class PlatformsService : IPlatformsService
    {
        private readonly AppDbContext _context;

        public PlatformsService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Platforms platform)
        {
            _context.Platforms.Add(platform);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Platforms>> GetAll()
        {
            var result = await _context.Platforms.ToListAsync();
            return result;
        }

        public Platforms GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Platforms Update(int id, Platforms newplatform)
        {
            throw new NotImplementedException();
        }
    }
}