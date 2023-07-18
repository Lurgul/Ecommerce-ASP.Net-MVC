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
        public async Task AddAsync(Platforms platform)
        {
            await _context.Platforms.AddAsync(platform);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Platforms>> GetAllAsync()
        {
            var result = await _context.Platforms.ToListAsync();
            return result;
        }

        public async Task<Platforms> GetByIdAsync(int id)
        {
            var result = await _context.Platforms.FirstOrDefaultAsync(n => n.PlatformId == id);
            return result;
        }

        public async Task<Platforms> UpdateAsync(int id, Platforms newplatform)
        {
            _context.Update(newplatform);
            await _context.SaveChangesAsync();
            return newplatform;
        }
    }
}